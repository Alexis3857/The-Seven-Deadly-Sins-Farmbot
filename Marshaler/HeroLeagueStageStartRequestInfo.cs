public class HeroLeagueStageStartRequestInfo
{
    public StageStartRequestInfo stageStartRequestInfo = new StageStartRequestInfo();
    public int season;
    public int league;
    public int targetUserGroup;
    public byte teamNumber;
    public List<int> useSkinIDList = new List<int>();
    public bool isContinue;
}