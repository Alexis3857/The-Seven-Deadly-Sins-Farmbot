public class GuildWarLobbyInfo
{
    public int league;
    public GuildWarScheduleInfo currentGuildWarScheduleInfo = new GuildWarScheduleInfo();
    public GuildWarScheduleInfo nextGuildWarScheduleInfo = new GuildWarScheduleInfo();
    public List<GuildInfo> guildInfoList = new List<GuildInfo>();
    public List<GuildWarLeagueRankInfo> guildWarLeagueRankInfoList = new List<GuildWarLeagueRankInfo>();
    public List<GuildWarVersusRecord> guildWarVersusRecordList = new List<GuildWarVersusRecord>();
    public List<GuildWarVersusScheduleInfo> guildWarVersusScheduleInfoList = new List<GuildWarVersusScheduleInfo>();
    public int nextSeasonRemainSec;
    public GuildWarUserSquadInfo guildWarUserSquadInfo = new GuildWarUserSquadInfo();
    public bool isGuildWarPlayable;
    public GuildWarLeagueRankInfo currentSeasonGuildWarLeagueRankInfo = new GuildWarLeagueRankInfo();
    public GuildWarLeagueRankInfo prevSeasonGuildWarLeagueRankInfo = new GuildWarLeagueRankInfo();
}