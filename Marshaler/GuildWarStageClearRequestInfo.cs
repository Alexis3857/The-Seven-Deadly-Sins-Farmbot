public class GuildWarStageClearRequestInfo
{
    public StageClearRequestInfo stageClearRequestInfo = new StageClearRequestInfo();
    public int season;
    public int league;
    public int battleNumber;
    public int AttackGuildSN;
    public int AttackAreaID;
    public List<ClientSyncGuildWarHero> clientSyncGuildWarHeroList = new List<ClientSyncGuildWarHero>();
    public int killCount;
}