using Nettention.Proud;
using SevenDSGameC2S;

namespace GameClient
{
    public class GameProxy : Proxy
    {
        // This method is called when a message is sent
        public override void NotifySendByProxy(HostID[] remotes, MessageSummary summary, RmiContext rmiContext, Message msg)
        {
            Logger.Log($"[GameProxy-NotifySendByProxy] rmi: {summary.rmiName}");
        }

        // Without this override method the packets would be sent immediately, so this method allows us to manage how they are sent
        public override bool RmiSend(HostID[] remotes, RmiContext rmiContext, Message msg, string rmiName, RmiID rmiID)
        {
            PacketManager.Instance.EnqueueSendMessage(remotes, rmiContext, msg, rmiName, rmiID);
            return true;
        }

        public bool RmiSend(PacketManager.RmiMessage sendMessage)
        {
            return base.RmiSend(sendMessage.remotes, sendMessage.rmiContext, sendMessage.msg, sendMessage.rmiName, sendMessage.rmiID);
        }
    }
}
