public class ArenaRankingBattleEndResult
{
    public ArenaRankingLobbyInfo arenaRankingLobbyInfo = new ArenaRankingLobbyInfo();
    public bool isWin;
    public int getRankPoint;
    public MissionResult missionResult = new MissionResult();
    public ItemResultInfo getCoinItemResultInfo = new ItemResultInfo();
    public int getCoinCount;
    public int increaseCoinCountByBuff;
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public bool isFirstPVP;
    public int usedFoodID;
    public UserADViewInfo adViewRouletteInfo = new UserADViewInfo();
    public List<UserPVPWinCountEventWeekInfo> pvpWinCountEventInfoList = new List<UserPVPWinCountEventWeekInfo>();
    public bool isAbuseDetect;
}