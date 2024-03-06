using Nettention.Proud;

namespace GameClient
{
    public class RelayPacketHandler
    {
        public SevenDSRelayR2C.Stub R2CStub { get; }

        public RelayPacketHandler()
        {
            R2CStub = new SevenDSRelayR2C.Stub()
            {
                enableStubProfiling = true,  // If enableStubProfiling is false then BeforeRmiInvocationDelegate and AfterRmiInvocationDelegate won't be called
                AfterRmiInvocation = new RmiStub.AfterRmiInvocationDelegate(AfterRmiInvocation)
            };
            R2CStub.CR_CommonCancel = new SevenDSRelayR2C.Stub.CR_CommonCancelDelegate(CR_CommonCancel);
        }

        // This method is called when a request is invalid
        private bool CR_CommonCancel(HostID remote, RmiContext rmiContext, RmiID packetID, string rmiName, PacketError error, InvalidRequestType invalidRequestType, bool isSimpleMessageBox)
        {
            throw new Exception($"Request error, rmi: {rmiName}, error: {error}, type: {invalidRequestType}");
        }

        // This method is called after calling the callback of a message
        private void AfterRmiInvocation(AfterRmiSummary summary)
        {
            Logger.Log(string.Format("[RelayPacketHandler-AfterRmiInvocation] ReceivedPacketData:{0}", summary.rmiName));
            if (summary.rmiID != SevenDSGameS2C.Common.CG_CommonCancel)
            {
                RelayPacketManager.Instance.OnPacketReceived(summary.rmiName);  // We let PacketManager know so it can process the next message in the queue
            }
            return;
        }
    }
}
