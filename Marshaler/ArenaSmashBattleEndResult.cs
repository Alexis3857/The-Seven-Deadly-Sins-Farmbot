public class ArenaSmashBattleEndResult
{
    public bool isWin;
    public byte userWin;
    public byte opponentWin;
    public bool isMatchPlay;
    public ArenaSmashUserInfo arenaSmashUserInfo = new ArenaSmashUserInfo();
    public MissionResult missionResult = new MissionResult();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public UserADViewInfo adViewRouletteInfo = new UserADViewInfo();
}