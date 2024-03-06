public class FriendlyMatchClearRequest
{
    public int roomSN;
    public bool isWin;
    public IngameMissionProgressRequest missionRequest = new IngameMissionProgressRequest();
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public bool isAutoPlay;
    public int turnCount;
    public int battlePowerPoint;
    public byte teamIndex;
    public OtherPlayerTeamInfo teamInfo = new OtherPlayerTeamInfo();
}