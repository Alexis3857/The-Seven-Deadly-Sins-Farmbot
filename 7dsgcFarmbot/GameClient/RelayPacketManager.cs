using Nettention.Proud;
using System.Diagnostics;

namespace GameClient
{
    public sealed class RelayPacketManager
    {
        private static volatile RelayPacketManager? _instance;

        private static readonly object _syncLock = new object();

        private RelayPacketManager()
        {
            ProcessMessageThread = new Thread(() => ProcessSendMessage());
            ProcessMessageThread.Start();
            UpdateThread = new Thread(() => Update());
            UpdateThread.Start();
        }

        public static RelayPacketManager Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new RelayPacketManager();
                    }
                }
                return _instance;
            }
        }

        public RelayClient RelayClient { get; private set; }

        public bool IsConnected
        {
            get => RelayClient != null && RelayClient.IsConnected;
        }

        private LinkedList<RmiMessage> SendMessageQueue { get; } = new LinkedList<RmiMessage>();  // List containing the next messages to be sent

        private Thread UpdateThread { get; }  // Thread executing the method Update

        private Thread ProcessMessageThread { get; }  // Thread executing the method ProcessSendMessage

        private RmiID[] UnawaitedRmiID = new RmiID[]  // Array of requests that don't need their responses to be waited for
        {
        };

        private long SendSEQ { get; set; }  // Every request increments this counter, this data is written at the beginning of the message content

        public bool IsForceDisconnected { get; private set; } = true;

        private bool IsWaitingResponse { get; set; }

        public void Connect(string ip, ushort port)
        {
            if (IsConnected)
            {
                Logger.Log("[RelayPacketManager-Connect] Already connected");
                return;
            }
            RelayClient = new RelayClient();
            ConsoleWriter.WriteLine("Connecting to the server...");
            Logger.Log($"[RelayPacketManager-Connect] Trying to connect to {ip}:{port}");
            RelayClient.Initialize();
            if (!RelayClient.Connect(ip, port))
            {
                throw new Exception($"Failed to connect to {ip}:{port}");
            }
        }

        public void Disconnect()
        {
            Logger.Log("[RelayPacketManager-Disconnect]");
            SendMessageQueue.Clear();
            IsForceDisconnected = true;
            if (IsConnected)
            {
                RelayClient.Disconnect();
            }
        }

        // Called when the server responds to the connection request
        public void OnJoinServerComplete(ErrorInfo info)
        {
            Logger.Log("[RelayPacketManager-OnJoinServerComplete] " + info.ToString());
            if (info.errorType == ErrorType.ErrorType_Ok)
            {
                IsForceDisconnected = false;
            }
            else if (info.errorType == ErrorType.ErrorType_ProtocolVersionMismatch)
            {
                ConsoleWriter.WriteLine("{FC=Red}Failed to connect to the server because ClientBase.PROTOCOLVERSION is incorrect.");
                throw new Exception("Failed to connect to the server because ClientBase.PROTOCOLVERSION is incorrect.");
            }
            else
            {
                ConsoleWriter.WriteLine("{FC=Red}Failed to connect to the server.");
                throw new Exception("Failed to connect to the server.");
            }
        }

        // Called when the server disconnects the program
        // This method isn't called when Disconnect() is called
        public void OnLeaveServer(ErrorInfo errorInfo)
        {
            ConsoleWriter.WriteLine($"{{FC=Red}}Lost connection to server: {errorInfo}");
            throw new Exception("Lost connection to server.");
        }

        public void OnPacketReceived(string inRmiName)
        {
            if (SendMessageQueue.Count == 0)
            {
                return;
            }
            string value = inRmiName.Replace("OK", string.Empty);
            var rmiMsg = SendMessageQueue.First!.Value;
            if (value == rmiMsg.rmiName)
            {
                SendMessageQueue.RemoveFirst();
                IsWaitingResponse = false;
                rmiMsg.resetEvent.Set();
            }
        }

        public void EnqueueSendMessage(HostID[] remotes, RmiContext rmiContext, Message msg, string rmiName, RmiID rmiID)
        {
            if (!UnawaitedRmiID.Contains(rmiID))
            {
                foreach (RmiMessage rmiMessage in SendMessageQueue)
                {
                    if (rmiMessage.rmiID == rmiID && rmiMessage.msg.Data.data.SequenceEqual(msg.Data.data))
                    {
                        Logger.Log($"[RelayPacketManager-EnqueueSendMessage] duplicated packet : {rmiName}");
                        return;
                    }
                }
                msg.Write(++SendSEQ);
                var rmiMsg = new RmiMessage()
                {
                    remotes = remotes,
                    rmiContext = rmiContext,
                    msg = msg,
                    rmiName = rmiName,
                    rmiID = rmiID
                };
                SendMessageQueue.AddLast(rmiMsg);
                rmiMsg.resetEvent.WaitOne();
            }
        }

        private void ProcessSendMessage()
        {
            while (true)
            {
                if (!IsForceDisconnected && SendMessageQueue.Count != 0)
                {
                    RmiMessage rmiMessage = SendMessageQueue.First!.Value;
                    if (!RelayClient.IsConnected)
                    {
                        Logger.Log($"[RelayPacketManager-ProcessSendMessage] rmi send failed(discon) packet:{rmiMessage.rmiName}");
                        throw new Exception("Failed to send a message due to a disconnection.");
                    }
                    if (!RelayClient.SendProxy.RmiSend(rmiMessage))
                    {
                        Logger.Log($"[RelayPacketManager-ProcessSendMessage] rmi send failed packet:{rmiMessage.rmiName}");
                        throw new Exception("Failed to send a message.");
                    }
                    IsWaitingResponse = true;
                    WaitForResponse(rmiMessage);
                }
            }
        }

        private void WaitForResponse(RmiMessage rmiMessage)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int packetDelayTime = 0;
            while (IsWaitingResponse)
            {
                if (!RelayClient.IsConnected)
                {
                    Logger.Log($"[RelayPacketManager-WaitForResponse] disconnected {rmiMessage.rmiName}, delayTime: {packetDelayTime}");
                    throw new Exception("A disconnection occured while waiting for a response.");
                }
                if (sw.ElapsedMilliseconds > 15000)  // The program disconnects after waiting for a response for more than 15 seconds
                {
                    Logger.Log($"[RelayPacketManager-WaitForResponse] delay {rmiMessage.rmiName}, delayTime: {packetDelayTime}");
                    throw new TimeoutException("Timeout reached, a message took to long to respond.");
                }
                Thread.Sleep(100);
            }
        }

        private void Update()
        {
            while (true)
            {
                // Prevent CPU full usage.
                Thread.Sleep(10);
                if (RelayClient != null)
                {
                    // process received RMI and events.
                    RelayClient.FrameMove();
                }
            }
        }

        public class RmiMessage
        {
            public object ShallowCopy()
            {
                return base.MemberwiseClone();
            }

            public HostID[] remotes;

            public RmiContext rmiContext;

            public Message msg;

            public RmiID rmiID;

            public string rmiName;

            public AutoResetEvent resetEvent = new AutoResetEvent(false);
        }
    }
}
