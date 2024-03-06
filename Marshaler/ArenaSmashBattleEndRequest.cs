public class ArenaSmashBattleEndRequest
{
    public bool isWin;
    public long opponentUSN;
    public byte teamIndex;
    public int battlePowerPoint;
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public List<SkinStatInfo> opponentSkinStatInfoList = new List<SkinStatInfo>();
    public IngameMissionProgressRequest missionRequest = new IngameMissionProgressRequest();
    public bool isAutoPlay;
    public int turnCount;
}