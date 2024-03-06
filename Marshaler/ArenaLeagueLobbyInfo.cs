public class ArenaLeagueLobbyInfo
{
    public ArenaLeagueUserInfo leagueUserInfo = new ArenaLeagueUserInfo();
    public List<ArenaLeagueMatchInfo> matchInfoList = new List<ArenaLeagueMatchInfo>();
    public ArenaLeagueMissionInfo missionInfo = new ArenaLeagueMissionInfo();
    public List<ArenaRealTimePvpShopBuyInfo> shopBuyInfoList = new List<ArenaRealTimePvpShopBuyInfo>();
    public List<DropItemInfo> rewardItemList = new List<DropItemInfo>();
    public ArenaLeagueEventType eventType;
    public ArenaLeagueGrade prevGrade;
    public byte prevGradeNumber;
}