using GameClient.PacketHandler;
using Nettention.Proud;

namespace GameClient
{
    public class GamePacketHandler  // Initializes and stores the stubs with their callbacks
    {
        public SevenDSGameS2C.Stub S2CStub { get; }

        public SevenDSGameS2C_Guild.Stub S2CGuildStub { get; }

        public SevenDSGameS2C_Pvp.Stub S2CPvpStub { get; }

        public SevenDSGameS2C_Shop.Stub S2CShopStub { get; }

        public SevenDSGameS2C_Stage.Stub S2CStageStub { get; }

        public SevenDSGameS2C_Weapon.Stub S2CWeaponStub { get; }

        private readonly AuthPacketHandler _authPacketHandler;  // This object only contains callback method, they are set to a Stub in the constructor

        public GamePacketHandler()
        {
            S2CStub = new SevenDSGameS2C.Stub()
            {
                enableStubProfiling = true,  // If enableStubProfiling is false then BeforeRmiInvocationDelegate and AfterRmiInvocationDelegate won't be called
                AfterRmiInvocation = new RmiStub.AfterRmiInvocationDelegate(AfterRmiInvocation)
            };
            S2CGuildStub = new SevenDSGameS2C_Guild.Stub()
            {
                enableStubProfiling = true,
                AfterRmiInvocation = new RmiStub.AfterRmiInvocationDelegate(AfterRmiInvocation)
            };
            S2CPvpStub = new SevenDSGameS2C_Pvp.Stub()
            {
                enableStubProfiling = true,
                AfterRmiInvocation = new RmiStub.AfterRmiInvocationDelegate(AfterRmiInvocation)
            };
            S2CShopStub = new SevenDSGameS2C_Shop.Stub()
            {
                enableStubProfiling = true,
                AfterRmiInvocation = new RmiStub.AfterRmiInvocationDelegate(AfterRmiInvocation)
            };
            S2CStageStub = new SevenDSGameS2C_Stage.Stub()
            {
                enableStubProfiling = true,
                AfterRmiInvocation = new RmiStub.AfterRmiInvocationDelegate(AfterRmiInvocation),

            };
            S2CWeaponStub = new SevenDSGameS2C_Weapon.Stub()
            {
                enableStubProfiling = true,
                AfterRmiInvocation = new RmiStub.AfterRmiInvocationDelegate(AfterRmiInvocation)
            };
            S2CStub.CG_CommonCancel = new SevenDSGameS2C.Stub.CG_CommonCancelDelegate(CG_CommonCancel);

            _authPacketHandler = new AuthPacketHandler(S2CStub);
        }

        // This method is called when a request is invalid
        private bool CG_CommonCancel(HostID remote, RmiContext rmiContext, RmiID packetID, string rmiName, PacketError error, InvalidRequestType invalidRequestType, bool isSimpleMessageBox)
        {
            throw new Exception($"Request error, rmi: {rmiName}, error: {error}, type: {invalidRequestType}");
        }

        // This method is called after calling the callback of a message
        private void AfterRmiInvocation(AfterRmiSummary summary)
        {
            Logger.Log(string.Format("[GamePacketHandler-AfterRmiInvocation] ReceivedPacketData:{0}", summary.rmiName));
            if (summary.rmiID != SevenDSGameS2C.Common.CG_CommonCancel)
            {
                PacketManager.Instance.OnPacketReceived(summary.rmiName);  // We let PacketManager know so it can process the next message in the queue
            }
            return;
        }
    }
}
