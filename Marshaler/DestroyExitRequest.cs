public class DestroyExitRequest
{
    public DestroyExitStatus exitStatus;
    public int roomSN;
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public bool isAutoPlay;
    public byte teamIndex;
    public int battlePowerPoint;
    public byte phase;
}