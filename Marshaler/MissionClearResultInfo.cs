public class MissionClearResultInfo
{
    public List<int> successChainIDList = new List<int>();
    public int getUserExp;
    public List<ItemResultInfo> itemResultInfoList = new List<ItemResultInfo>();
    public MissionResult missionResult = new MissionResult();
    public List<ApRewardInfo> apRewardInfoList = new List<ApRewardInfo>();
    public PacketError errorType;
    public InvalidRequestType invalidRequestType;
}