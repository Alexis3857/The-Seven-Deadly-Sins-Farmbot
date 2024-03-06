public class GuildWarLowStageClearRequestInfo
{
    public StageClearRequestInfo stageClearRequestInfo = new StageClearRequestInfo();
    public int season;
    public int attackGuildSN;
    public int attackAreaID;
    public long attackUSN;
    public List<ClientSyncGuildWarLowHero> clientSyncGuildWarLowHeroList = new List<ClientSyncGuildWarLowHero>();
}