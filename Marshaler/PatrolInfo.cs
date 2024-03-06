public class PatrolInfo
{
    public byte rotationId;
    public int lastRewardElpasedTimeSEC;
    public List<PatrolMissionInfo> patrolMissionInfoList = new List<PatrolMissionInfo>();
    public DateTime eventEndDate;
}