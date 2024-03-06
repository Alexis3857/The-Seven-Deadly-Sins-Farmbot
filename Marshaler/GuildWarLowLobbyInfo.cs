public class GuildWarLowLobbyInfo
{
    public GuildWarLowScheduleInfo currentScheduleInfo = new GuildWarLowScheduleInfo();
    public GuildWarLowScheduleInfo nextScheduleInfo = new GuildWarLowScheduleInfo();
    public GuildInfo guildInfo = new GuildInfo();
    public GuildInfo opponentGuildInfo = new GuildInfo();
    public int nextSeasonRemainSec;
    public int lastSeason;
    public int tier;
    public int attackCount;
    public int receivedPlayRewardID;
    public int battlePoint;
    public int opponentBattlePoint;
    public bool isLate;
    public byte registAccountBPGuildMemberCount;
    public byte saveDefenceTeamGuildMemberCount;
    public List<int> useHeroIDList = new List<int>();
    public List<GuildWarLowAreaInfo> areaInfoList = new List<GuildWarLowAreaInfo>();
    public int areaID;
}