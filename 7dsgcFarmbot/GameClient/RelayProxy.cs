using Nettention.Proud;
using SevenDSRelayC2R;

namespace GameClient
{
    public class RelayProxy : Proxy
    {
        // This method is called when a message is sent
        public override void NotifySendByProxy(HostID[] remotes, MessageSummary summary, RmiContext rmiContext, Message msg)
        {
            Logger.Log($"[RelayProxy-NotifySendByProxy] rmi: {summary.rmiName}");
        }

        // Without this override method the packets would be sent immediately, so this method allows us to manage how they are sent
        public override bool RmiSend(HostID[] remotes, RmiContext rmiContext, Message msg, string rmiName, RmiID rmiID)
        {
            RelayPacketManager.Instance.EnqueueSendMessage(remotes, rmiContext, msg, rmiName, rmiID);
            return true;
        }

        public bool RmiSend(RelayPacketManager.RmiMessage sendMessage)
        {
            return base.RmiSend(sendMessage.remotes, sendMessage.rmiContext, sendMessage.msg, sendMessage.rmiName, sendMessage.rmiID);
        }
    }
}
