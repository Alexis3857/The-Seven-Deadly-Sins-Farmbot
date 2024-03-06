using Nettention.Proud;

namespace SevenDSWestC2S
{
    public class Common
    {
        public const RmiID CW_RequestJoinChannel = (RmiID)36001;

        public const RmiID CW_RequestWestSideMove = (RmiID)36002;

        public const RmiID CW_RequestChangeStatus = (RmiID)36003;

        public const RmiID CW_RequestChannelUserInfo = (RmiID)36004;

        public static RmiID[] RmiIDList = new RmiID[]
        {
            CW_RequestJoinChannel,
            CW_RequestWestSideMove,
            CW_RequestChangeStatus,
            CW_RequestChannelUserInfo
        };
    }
}
