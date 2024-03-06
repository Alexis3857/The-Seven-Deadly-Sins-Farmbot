public class EventQuestClearResultInfo
{
    public int eventSeq;
    public int questID;
    public int userExp;
    public List<ItemResultInfo> getItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> removeItemResultInfoList = new List<ItemResultInfo>();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public EventBasepointInfo basepointInfo = new EventBasepointInfo();
    public List<ApRewardInfo> apRewardInfoList = new List<ApRewardInfo>();
    public List<int> resetQuestIDList = new List<int>();
}