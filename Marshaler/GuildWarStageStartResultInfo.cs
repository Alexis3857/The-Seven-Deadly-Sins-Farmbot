public class GuildWarStageStartResultInfo
{
    public StageStartResultInfo stageStartResultInfo = new StageStartResultInfo();
    public GuildWarDefenceTeamInfo guildWarDefenceTeamInfo = new GuildWarDefenceTeamInfo();
    public List<GuildWarHero> defenceGuildWarHeroList = new List<GuildWarHero>();
    public List<GuildWarTeamBuff> guildWarDefenceTeamBuffList = new List<GuildWarTeamBuff>();
    public List<GuildWarTeamBuff> guildWarAttackTeamBuffList = new List<GuildWarTeamBuff>();
    public List<ItemResultInfo> useGuildWarBuffItemResultInfoList = new List<ItemResultInfo>();
    public List<GuildWarHero> attackGuildWarHeroList = new List<GuildWarHero>();
    public GuildWarMagicBuffInfo guildWarMagicBuffInfo = new GuildWarMagicBuffInfo();
}