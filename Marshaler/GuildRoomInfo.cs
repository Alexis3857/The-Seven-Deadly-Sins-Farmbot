public class GuildRoomInfo
{
    public byte resultCode;
    public RelayServerInfo relayServerInfo = new RelayServerInfo();
    public List<GuildRoomMemberInfo> guildRoomMenberInfoList = new List<GuildRoomMemberInfo>();
    public GuildMemberInfo guildMemberInfo = new GuildMemberInfo();
    public int guildRankStartRemainSec;
    public int guildRankEndRemainSec;
    public GuildRankRewardInfo guildRankRewardInfo = new GuildRankRewardInfo();
    public List<NeedItemInfo> guildBossWeekRewardList = new List<NeedItemInfo>();
    public GuildMemberRankInfo guildMemberRanker = new GuildMemberRankInfo();
    public int registerTeamBattlePoint;
    public int registerAccountBattlePoint;
    public GuildWarRankRewardInfo guildWarRankRewardInfo = new GuildWarRankRewardInfo();
    public List<GuildWarLeagueRankInfo> prevSeasonGuildWarLeagueRankInfoList = new List<GuildWarLeagueRankInfo>();
    public GuildWarLowRewardInfo guildWarLowRewardInfo = new GuildWarLowRewardInfo();
}