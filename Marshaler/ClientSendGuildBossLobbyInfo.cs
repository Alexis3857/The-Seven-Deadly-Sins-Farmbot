public class ClientSendGuildBossLobbyInfo
{
    public int startRemainSec;
    public int endRamainSec;
    public int rank;
    public int totalRankUpCount;
    public int currentRankPoint;
    public int userWeeklyContribution;
    public int currentMissionGroupID;
    public bool stageLocked;
    public short currentGuildBossSeq;
    public bool isJoinFirstWeek;
    public byte currentSeasonGroup;
    public List<GuildBossRankPoint> guildBossRankPointList = new List<GuildBossRankPoint>();
    public GuildBossRankPointReward guildBossRankPointReward = new GuildBossRankPointReward();
    public List<GuildBossOffSeasonRankPoint> guildBossOffSeasonRankPointList = new List<GuildBossOffSeasonRankPoint>();
    public int currentSeasonID;
    public List<ClientSendGuildBossRankInfo> guildBossRankInfoList = new List<ClientSendGuildBossRankInfo>();
    public int joinFirstWeekRemainSec;
    public List<GuildBossOffSeasonInfo> guildBossOffSeasonInfoList = new List<GuildBossOffSeasonInfo>();
    public bool isGuildBossHellOpened;
}