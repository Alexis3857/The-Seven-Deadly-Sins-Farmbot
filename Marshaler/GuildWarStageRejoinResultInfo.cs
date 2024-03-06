public class GuildWarStageRejoinResultInfo
{
    public GuildWarDefenceTeamInfo guildWarDefenceTeamInfo = new GuildWarDefenceTeamInfo();
    public List<GuildWarHero> defenceGuildWarHeroList = new List<GuildWarHero>();
    public List<GuildWarHero> attackGuildWarHeroList = new List<GuildWarHero>();
    public List<int> useHeroIDList = new List<int>();
    public int season;
    public int league;
    public int battleNumber;
    public GuildInfo defenceGuildInfo = new GuildInfo();
    public int defencePlayTitleID;
    public string defenceUserNickName = string.Empty;
    public byte nextDefenceTeamIndex;
    public List<GuildWarTeamBuff> guildWarDefenceTeamBuffList = new List<GuildWarTeamBuff>();
    public List<GuildWarTeamBuff> guildWarAttackTeamBuffList = new List<GuildWarTeamBuff>();
    public GuildWarMagicBuffInfo guildWarMagicBuffInfo = new GuildWarMagicBuffInfo();
    public GuildWarRegionInfo guildWarRegionInfo = new GuildWarRegionInfo();
}