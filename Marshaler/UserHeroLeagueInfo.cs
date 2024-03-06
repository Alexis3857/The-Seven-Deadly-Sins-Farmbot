public class UserHeroLeagueInfo
{
    public byte league;
    public short useTeamCount;
    public byte winCount;
    public byte currentUserGroup;
    public HeroLeagueRewardInfo rewardInfo = new HeroLeagueRewardInfo();
    public HeroLeagueScoreRewardInfo scoreRewardInfo = new HeroLeagueScoreRewardInfo();
    public short season;
    public byte week;
}