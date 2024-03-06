public class StageStartRequestInfo
{
    public int stageID;
    public long mercenaryUSN;
    public int mercenarySkinID;
    public FriendState mercenaryState;
    public int teamIndex;
    public int eventSEQ;
    public int battlePowerPoint;
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public List<int> stageNpcIDList = new List<int>();
    public byte stageIndex;
}