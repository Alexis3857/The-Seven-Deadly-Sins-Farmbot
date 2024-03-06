public class ArenaRealTimePVPClearRequest
{
    public bool isWin;
    public byte teamIndex;
    public int battlePowerPoint;
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public List<SkinStatInfo> targetSkinStatInfoList = new List<SkinStatInfo>();
    public IngameMissionProgressRequest missionRequest = new IngameMissionProgressRequest();
}