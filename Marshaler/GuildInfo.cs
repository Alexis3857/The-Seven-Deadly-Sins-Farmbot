public class GuildInfo
{
    public int guildSN;
    public string guildName = string.Empty;
    public int guildExp;
    public long masterUSN;
    public string description = string.Empty;
    public string noticeTitle = string.Empty;
    public string notice = string.Empty;
    public bool showNotice;
    public int emblemIconID;
    public int emblemSubIconID;
    public int emblemBgID;
    public int guildPoint;
    public int skillPoint;
    public GuildJoiningApprovalType joiningApprovalType;
    public byte joiningLevelCondition;
    public short memberCount;
    public short applicantCount;
    public string masterName = string.Empty;
    public short attendSeq;
    public short attendCount;
    public short prevAttendCount;
    public List<int> skillUseList = new List<int>();
    public GuildMemberGrade invitationGrade;
    public short guildWarSeedSeason;
    public byte expBoostStack;
    public int joiningBattlePoint;
    public byte joiningCurrentConstellationGroup;
    public string recruitNotice = string.Empty;
    public int recruitEndRemainSec;
    public byte level;
    public short lastGuildMissionResetSeq;
    public int lastGuildMissionResetExp;
    public LanguageType languageType;
    public short expBoostStackUpdateSeq;
    public DateTime recruitExpireTime;
    public short currentAPWeekResetSEQ;
}