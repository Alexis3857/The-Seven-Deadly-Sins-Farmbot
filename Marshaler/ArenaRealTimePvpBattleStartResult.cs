public class ArenaRealTimePvpBattleStartResult
{
    public ArenaRealTimePvpOpponentUserInfo arenaRealTimePvpOppUserInfo = new ArenaRealTimePvpOpponentUserInfo();
    public OtherPlayerTeamInfo otherPlayerTeamInfo = new OtherPlayerTeamInfo();
    public APInfo apInfo = new APInfo();
    public RelayServerInfo relayServerInfo = new RelayServerInfo();
    public bool isCPU;
    public long firstAttackUSN;
    public int changeRankPoint;
    public ItemResultInfo getCoinItemResultInfo = new ItemResultInfo();
    public bool isBuffUsed;
    public FoodBuffInfo foodBuffInfo = new FoodBuffInfo();
    public ItemResultInfo useItemResultInfo = new ItemResultInfo();
    public long playKey;
    public byte playMode;
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public List<UserPlayCountEventInfo> userPlayCountEventInfoList = new List<UserPlayCountEventInfo>();
    public bool isPlacementMatching;
}