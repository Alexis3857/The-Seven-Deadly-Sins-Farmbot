public class ArenaRealTimePvpInfo
{
    public bool needJoin;
    public int arenaRealTimePvpRemainSec;
    public int arenaRealTimeDecisionRemainSec;
    public ArenaLeagueEventType eventType;
    public ArenaLeagueGrade prevGrade;
    public byte prevGradeNumber;
    public List<bool> placementMatchList = new List<bool>();
    public int arenaRealTimePvpLimitHeroCostRemainTimeSec;
}