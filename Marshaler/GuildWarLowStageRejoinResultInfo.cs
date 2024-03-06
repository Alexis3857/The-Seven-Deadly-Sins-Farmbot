public class GuildWarLowStageRejoinResultInfo
{
    public GuildWarLowDefenceTeamInfo guildWarLowDefenceTeamInfo = new GuildWarLowDefenceTeamInfo();
    public List<GuildWarLowHero> defenceGuildWarLowHeroList = new List<GuildWarLowHero>();
    public List<GuildWarLowHero> attackGuildWarLowHeroList = new List<GuildWarLowHero>();
    public List<int> useHeroIDList = new List<int>();
    public int season;
    public GuildInfo defenceGuildInfo = new GuildInfo();
    public int defencePlayTitleID;
    public string defenceUserNickName = string.Empty;
    public byte nextDefenceTeamIndex;
    public List<int> guildWarLowPassiveSkillIDList = new List<int>();
    public int attackCount;
    public bool isContinue;
}