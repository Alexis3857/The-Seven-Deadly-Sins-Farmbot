using Nettention.Proud;

namespace SevenDSWestS2C
{
    public class Common
    {
        public const RmiID CW_CommonCancel = (RmiID)37001;

        public const RmiID CW_RequestForceLogoutOK = (RmiID)37002;

        public const RmiID CW_RequestJoinChannelOK = (RmiID)37003;

        public const RmiID CW_RequestWestSideMoveOK = (RmiID)37004;

        public const RmiID CW_RequestChangeStatusOK = (RmiID)37005;

        public const RmiID CW_RequestChannelUserInfoOK = (RmiID)37006;

        public const RmiID CW_BroadcastingJoinChannelOK = (RmiID)37007;

        public const RmiID CW_BroadcastingWestSideMoveOK = (RmiID)37008;

        public const RmiID CW_BroadcastingChangeStatusOK = (RmiID)37009;

        public const RmiID CW_BroadcastingLeaveUserOK = (RmiID)37010;

        public static RmiID[] RmiIDList = new RmiID[]
        {
            CW_CommonCancel,
            CW_RequestForceLogoutOK,
            CW_RequestJoinChannelOK,
            CW_RequestWestSideMoveOK,
            CW_RequestChangeStatusOK,
            CW_RequestChannelUserInfoOK,
            CW_BroadcastingJoinChannelOK,
            CW_BroadcastingWestSideMoveOK,
            CW_BroadcastingChangeStatusOK,
            CW_BroadcastingLeaveUserOK
        };
    }
}