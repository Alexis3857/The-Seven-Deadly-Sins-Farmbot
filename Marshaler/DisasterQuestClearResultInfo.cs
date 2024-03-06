public class DisasterQuestClearResultInfo
{
    public int questID;
    public int userExp;
    public List<ItemResultInfo> getItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> removeItemResultInfoList = new List<ItemResultInfo>();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public List<ApRewardInfo> apRewardInfoList = new List<ApRewardInfo>();
}