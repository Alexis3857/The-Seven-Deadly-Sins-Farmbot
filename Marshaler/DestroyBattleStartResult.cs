public class DestroyBattleStartResult
{
    public bool isBuffUsed;
    public FoodBuffInfo foodBuffInfo = new FoodBuffInfo();
    public ItemResultInfo useItemResultInfo = new ItemResultInfo();
    public long playKey;
    public byte playMode;
    public APInfo apInfo = new APInfo();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public OtherPlayerTeamInfo otherTeamInfo = new OtherPlayerTeamInfo();
    public List<int> usedEventLobbyBuffIdList = new List<int>();
}