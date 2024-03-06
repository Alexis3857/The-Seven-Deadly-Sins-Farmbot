public class QuestClearResultInfo
{
    public int questID;
    public int userExp;
    public List<ItemResultInfo> getItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> removeItemResultInfoList = new List<ItemResultInfo>();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public int basepointGetExp;
    public BasePointInfo basepointInfo = new BasePointInfo();
    public List<ApRewardInfo> apRewardInfoList = new List<ApRewardInfo>();
    public LobbyVisualType lobbyVisualType;
}