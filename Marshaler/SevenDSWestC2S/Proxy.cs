using Nettention.Proud;

namespace SevenDSWestC2S
{
    public class Proxy : RmiProxy
    {
        public bool CW_RequestJoinChannel(HostID remote, RmiContext rmiContext, WestServerLoginInfo westServerLoginInfo, WestSidePoint westSidePoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestJoinChannel);
            CommonPacket.Marshaler.Write(message, westServerLoginInfo);
            CommonPacket.Marshaler.Write(message, westSidePoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestJoinChannel, Common.CW_RequestJoinChannel);
        }

        public bool CW_RequestWestSideMove(HostID remote, RmiContext rmiContext, WestSidePoint point)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestWestSideMove);
            CommonPacket.Marshaler.Write(message, point);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestWestSideMove, Common.CW_RequestWestSideMove);
        }

        public bool CW_RequestChangeStatus(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestChangeStatus);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestChangeStatus, Common.CW_RequestChangeStatus);
        }

        public bool CW_RequestChannelUserInfo(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestChannelUserInfo);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestChannelUserInfo, Common.CW_RequestChannelUserInfo);
        }

        public override RmiID[] GetRmiIDList()
        {
            return Common.RmiIDList;
        }

        public const string RmiName_CW_RequestJoinChannel = "CW_RequestJoinChannel";

        public const string RmiName_CW_RequestWestSideMove = "CW_RequestWestSideMove";

        public const string RmiName_CW_RequestChangeStatus = "CW_RequestChangeStatus";

        public const string RmiName_CW_RequestChannelUserInfo = "CW_RequestChannelUserInfo";

        public const string RmiName_First = "CW_RequestJoinChannel";

    }
}
