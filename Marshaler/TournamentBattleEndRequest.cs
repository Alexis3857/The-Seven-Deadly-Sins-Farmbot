public class TournamentBattleEndRequest
{
    public int roomSN;
    public bool isWin;
    public TournamentMatchResultState resultState;
    public IngameMissionProgressRequest missionRequest = new IngameMissionProgressRequest();
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public bool isAutoPlay;
    public int turnCount;
    public int battlePowerPoint;
    public short teamIndex;
    public OtherPlayerTeamInfo teamInfo = new OtherPlayerTeamInfo();
}