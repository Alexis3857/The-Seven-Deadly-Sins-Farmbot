using Nettention.Proud;

namespace SevenDSWestS2C
{
    public class Proxy : RmiProxy
    {
        public bool CW_CommonCancel(HostID remote, RmiContext rmiContext, RmiID packetID, string packetName, PacketError error, InvalidRequestType invalidRequesttype, bool isSimpleMessageBox)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_CommonCancel);
            CommonPacket.Marshaler.Write(message, packetID);
            CommonPacket.Marshaler.Write(message, packetName);
            CommonPacket.Marshaler.Write(message, error);
            CommonPacket.Marshaler.Write(message, invalidRequesttype);
            CommonPacket.Marshaler.Write(message, isSimpleMessageBox);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_CommonCancel, Common.CW_CommonCancel);
        }

        public bool CW_RequestForceLogoutOK(HostID remote, RmiContext rmiContext, PacketError error)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestForceLogoutOK);
            CommonPacket.Marshaler.Write(message, error);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestForceLogoutOK, Common.CW_RequestForceLogoutOK);
        }

        public bool CW_RequestJoinChannelOK(HostID remote, RmiContext rmiContext, int channelID, List<WestSideUserInfo> westSideUserInfoList, string talkWestsidePrefix, WestRoomType joinRoomType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestJoinChannelOK);
            CommonPacket.Marshaler.Write(message, channelID);
            CommonPacket.Marshaler.Write(message, westSideUserInfoList);
            CommonPacket.Marshaler.Write(message, talkWestsidePrefix);
            CommonPacket.Marshaler.Write(message, joinRoomType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestJoinChannelOK, Common.CW_RequestJoinChannelOK);
        }

        public bool CW_RequestWestSideMoveOK(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestWestSideMoveOK);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestWestSideMoveOK, Common.CW_RequestWestSideMoveOK);
        }

        public bool CW_RequestChangeStatusOK(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestChangeStatusOK);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestChangeStatusOK, Common.CW_RequestChangeStatusOK);
        }

        public bool CW_RequestChannelUserInfoOK(HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_RequestChannelUserInfoOK);
            CommonPacket.Marshaler.Write(message, westSideUserInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_RequestChannelUserInfoOK, Common.CW_RequestChannelUserInfoOK);
        }

        public bool CW_BroadcastingJoinChannelOK(HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_BroadcastingJoinChannelOK);
            CommonPacket.Marshaler.Write(message, westSideUserInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_BroadcastingJoinChannelOK, Common.CW_BroadcastingJoinChannelOK);
        }

        public bool CW_BroadcastingWestSideMoveOK(HostID remote, RmiContext rmiContext, List<WestSideMoveInfo> westSideMoveInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_BroadcastingWestSideMoveOK);
            CommonPacket.Marshaler.Write(message, westSideMoveInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_BroadcastingWestSideMoveOK, Common.CW_BroadcastingWestSideMoveOK);
        }

        public bool CW_BroadcastingChangeStatusOK(HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_BroadcastingChangeStatusOK);
            CommonPacket.Marshaler.Write(message, westSideUserInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_BroadcastingChangeStatusOK, Common.CW_BroadcastingChangeStatusOK);
        }

        public bool CW_BroadcastingLeaveUserOK(HostID remote, RmiContext rmiContext, long usn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CW_BroadcastingLeaveUserOK);
            CommonPacket.Marshaler.Write(message, usn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CW_BroadcastingLeaveUserOK, Common.CW_BroadcastingLeaveUserOK);
        }

        public override RmiID[] GetRmiIDList()
        {
            return Common.RmiIDList;
        }

        public const string RmiName_CW_CommonCancel = "CW_CommonCancel";

        public const string RmiName_CW_RequestForceLogoutOK = "CW_RequestForceLogoutOK";

        public const string RmiName_CW_RequestJoinChannelOK = "CW_RequestJoinChannelOK";

        public const string RmiName_CW_RequestWestSideMoveOK = "CW_RequestWestSideMoveOK";

        public const string RmiName_CW_RequestChangeStatusOK = "CW_RequestChangeStatusOK";

        public const string RmiName_CW_RequestChannelUserInfoOK = "CW_RequestChannelUserInfoOK";

        public const string RmiName_CW_BroadcastingJoinChannelOK = "CW_BroadcastingJoinChannelOK";

        public const string RmiName_CW_BroadcastingWestSideMoveOK = "CW_BroadcastingWestSideMoveOK";

        public const string RmiName_CW_BroadcastingChangeStatusOK = "CW_BroadcastingChangeStatusOK";

        public const string RmiName_CW_BroadcastingLeaveUserOK = "CW_BroadcastingLeaveUserOK";

        public const string RmiName_First = "CW_CommonCancel";

    }
}
