public class GuildWarLowStageStartResultInfo
{
    public StageStartResultInfo stageStartResultInfo = new StageStartResultInfo();
    public GuildWarLowDefenceTeamInfo guildWarLowDefenceTeamInfo = new GuildWarLowDefenceTeamInfo();
    public List<GuildWarLowHero> defenceGuildWarLowHeroList = new List<GuildWarLowHero>();
    public int defencePlayTitleID;
    public string defenceUserNickName = string.Empty;
    public List<GuildWarLowHero> attackGuildWarLowHeroList = new List<GuildWarLowHero>();
    public List<int> guildWarLowPassiveSkillIDList = new List<int>();
    public ItemResultInfo playRewardItemResultInfo = new ItemResultInfo();
    public int attackAreaID;
}