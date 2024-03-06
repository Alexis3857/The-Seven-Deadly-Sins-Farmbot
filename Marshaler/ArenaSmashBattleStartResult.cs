public class ArenaSmashBattleStartResult
{
    public long playKey;
    public byte playMode;
    public APInfo apInfo = new APInfo();
    public byte teamIndex;
    public int foodBuffItemID;
    public MissionResult missionResult = new MissionResult();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public List<UserPlayCountEventInfo> userPlayCountEventInfoList = new List<UserPlayCountEventInfo>();
}