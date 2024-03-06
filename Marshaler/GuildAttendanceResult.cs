public class GuildAttendanceResult
{
    public bool bAttendnaceRewardEnable;
    public short attendanceCount;
    public int remainSecToAttendanceEnd;
    public short prevAttendCount;
    public bool bAttendOccur;
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public GuildRewardResult guildRewardResult = new GuildRewardResult();
}