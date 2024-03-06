public class GuildWarLowStageStartRequestInfo
{
    public StageStartRequestInfo stageStartRequestInfo = new StageStartRequestInfo();
    public int attackGuildSN;
    public int attackAreaID;
    public long attackUSN;
    public byte attackTeamIndex;
    public List<int> useSkinIDList = new List<int>();
    public bool isContinue;
}