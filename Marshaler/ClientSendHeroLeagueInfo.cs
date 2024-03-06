public class ClientSendHeroLeagueInfo
{
    public int remainSeasonInitSec;
    public int remainWeekInitSec;
    public byte week;
    public UserHeroLeagueInfo heroLeagueInfo = new UserHeroLeagueInfo();
    public HeroLeagueSeasonInfo heroLeagueSeasonInfo = new HeroLeagueSeasonInfo();
    public List<HeroLeagueHero> heroLeagueHeroList = new List<HeroLeagueHero>();
    public HeroLeagueBuffInfo heroLeagueSeasonBuffInfo = new HeroLeagueBuffInfo();
    public List<HeroLeagueBuffInfo> heroLeagueSpecialBuffInfoList = new List<HeroLeagueBuffInfo>();
}