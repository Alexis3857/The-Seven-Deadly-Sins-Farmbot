public class HeroLeagueStageClearRequestInfo
{
    public StageClearRequestInfo stageClearRequestInfo = new StageClearRequestInfo();
    public int season;
    public int league;
    public bool isGiveUp;
    public List<ClientSyncHeroLeagueHero> ClientSyncHeroLeagueHeroList = new List<ClientSyncHeroLeagueHero>();
}