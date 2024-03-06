public class GuildWarStageStartRequestInfo
{
    public StageStartRequestInfo stageStartRequestInfo = new StageStartRequestInfo();
    public int season;
    public int league;
    public int battleNumber;
    public int AttackGuildSN;
    public int AttackAreaID;
    public long AttackUSN;
    public byte AttackTeamIndex;
    public List<int> useSkinIDList = new List<int>();
    public bool isContinue;
}