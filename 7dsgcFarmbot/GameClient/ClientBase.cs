using Nettention.Proud;

namespace GameClient
{
    public abstract class ClientBase  // Contains the NetClient object and its callback, and methods to use it
    {
        // A GUID that changes with each game version update, if this GUID doesn't match with the one on the game server the connection will be declined
        // and OnJoinServerComplete will be called with ErrorType_ProtocolVersionMismatch.
        public static readonly System.Guid PROTOCOLVERSION = new System.Guid(627039420, 11207, 19326, 130, 198, 217, 84, 55, 53, 77, 153);

        public bool IsConnected
        {
            get => Client != null && !IsOffline && Client.HasServerConnection();
        }

        private NetClient? Client { get; set; }

        private string IP { get; set; } = string.Empty;

        private ushort Port { get; set; }

        private bool IsOffline { get; set; }

        // Creates Client with its callback methods
        protected void InitializeNetClient()
        {
            if (Client != null)
            {
                Client.Dispose();
            }
            Client = new NetClient()
            {
                JoinServerCompleteHandler = new NetClient.JoinServerCompleteDelegate(OnJoinServerComplete),
                LeaveServerHandler = new NetClient.LeaveServerDelegate(OnLeaveServer),
                ErrorHandler = new NetClient.ErrorInfoDelegate(OnError),
                WarningHandler = new NetClient.ErrorInfoDelegate(OnWarning),
                InformationHandler = new NetClient.ErrorInfoDelegate(OnInformation),
                ExceptionHandler = new NetClient.ExceptionDelegate(OnException),
                ServerOfflineHandler = new NetClient.ServerOfflineDelegate(OnServerHandOverOffline),
                ServerOnlineHandler = new NetClient.ServerOnlineDelegate(OnServerHandOverOnline)
            };
        }

        // Event that occurs after the connection attempt
        // It doesn't mean that the connection was accepted
        protected abstract void OnJoinServerComplete(ErrorInfo info, ByteArray replyFromServer);

        // Event that occurs when the connection is terminated
        // Not called when the users diconnect themselves
        protected abstract void OnLeaveServer(ErrorInfo errorInfo);

        // Event that occurs when an internal error has occured
        protected abstract void OnError(ErrorInfo errorInfo);

        // Event that occurs when an internal error has occured, with a priority lower than Error
        protected abstract void OnWarning(ErrorInfo errorInfo);

        // Event that occurs when an internal notification has occured. It does not indicate a problem.
        protected abstract void OnInformation(ErrorInfo errorInfo);

        // When a method called by a ProudNet dll throws an exception it will be catched and OnException will be called at the next client FrameMove
        protected abstract void OnException(HostID remote, Exception e);

        protected virtual void OnServerHandOverOffline(RemoteOfflineEventArgs args)
        {
            IsOffline = true;
        }

        protected virtual void OnServerHandOverOnline(RemoteOnlineEventArgs args)
        {
            IsOffline = false;
        }

        // Starts connection.
        // This method returns immediately, the connection attempt is done in the background and the result is notified by the OnJoinServerComplete event
        public bool Connect(string ip, ushort port)
        {
            if (IsConnected)
            {
                Logger.Log($"[ClientBase-Connect] Already connected to {IP}:{Port}");
                return false;
            }
            NetConnectionParam connectionParameters = new NetConnectionParam()
            {
                serverIP = ip,
                serverPort = port,
                netWorkerThreadModel = ThreadModel.ThreadModel_MultiThreaded,
                userWorkerThreadModel = ThreadModel.ThreadModel_SingleThreaded
            };
            connectionParameters.protocolVersion.Set(PROTOCOLVERSION);
            if (Client == null || !Client.Connect(connectionParameters))
            {
                Logger.Log($"[ClientBase-Connect] Failed to connect to the server, client is null ? : {Client == null}");
                return false;
            }
            IsOffline = false;
            return true;
        }

        public void Disconnect()
        {
            if (Client != null)
            {
                Client.FrameMove();
                Client.Disconnect();
            }
        }

        // Processes received messages and events
        // The messages and events received since the last FrameMove call are accumulated and the callbacks are called all at once
        public void FrameMove()
        {
            if (Client != null)
                Client.FrameMove();
        }

        // Attaches a stub that, when a message is received, will parse its content and call the appropriate callback in /GameClient/PacketHandler/ if implemented
        protected void AttachStub(RmiStub stub)
        {
            if (Client != null)
                Client.AttachStub(stub);
        }

        // Attaches a proxy containing the method to send a message
        protected void AttachProxy(RmiProxy proxy)
        {
            if (Client != null)
                Client.AttachProxy(proxy);
        }

        protected void Dispose()
        {
            if (Client != null)
            {
                Client.FrameMove();
                Client.Dispose();
                Client = null;
            }
        }
    }
}
