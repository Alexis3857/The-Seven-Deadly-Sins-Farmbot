public class ArenaRealTimePvpRankerBattleStartResult
{
    public byte rank;
    public ArenaLeagueOpponentInfo oppUserInfo = new ArenaLeagueOpponentInfo();
    public RelayServerInfo relayServerInfo = new RelayServerInfo();
    public bool isBuffUsed;
    public FoodBuffInfo foodBuffInfo = new FoodBuffInfo();
    public MissionResult missionResult = new MissionResult();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
}