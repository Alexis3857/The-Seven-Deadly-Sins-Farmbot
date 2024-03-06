public class GuildMemberInfo
{
    public int guildSN;
    public long usn;
    public GuildMemberGrade grade;
    public string nickname = string.Empty;
    public int userExp;
    public int skinID;
    public int remainSecToJoinEnable;
    public DateTime joinEnableTime;
    public DateTime joinTime;
    public int afterLoginMin;
    public int accumdContribution;
    public int weeklyContribution;
    public int prevWeeklyContirbution;
    public short weeklySeq;
    public UserLoginState loginState;
    public DateTime lastAttendTime;
    public bool bTodayAttend;
    public short stageClearCount;
    public short joinTimeWeeklySeq;
    public int playTitleID;
    public int joinBattlePoint;
    public byte joinConstellationGroup;
    public int guildOrderMissionMileageRewardIndex;
    public DateTime attendRewardTime;
    public string netmarblePID = string.Empty;
}