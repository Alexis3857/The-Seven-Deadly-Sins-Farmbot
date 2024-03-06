public class DestroyClearRequest
{
    public int roomSN;
    public IngameMissionProgressRequest missionRequest = new IngameMissionProgressRequest();
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public bool isAutoPlay;
    public int turnCount;
    public int battlePowerPoint;
    public byte teamIndex;
    public byte phase;
}