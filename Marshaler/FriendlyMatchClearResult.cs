public class FriendlyMatchClearResult
{
    public int roomSN;
    public bool isWin;
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public List<UserPlayCountEventInfo> playCountEventInfoList = new List<UserPlayCountEventInfo>();
    public int usedFoodID;
}