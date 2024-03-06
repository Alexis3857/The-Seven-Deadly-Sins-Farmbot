public class SubdubClearRequestInfo
{
    public int stageID;
    public int turnCount;
    public int teamIndex;
    public int battlePowerPoint;
    public List<BattleSkinInfo> battleSkinInfoList = new List<BattleSkinInfo>();
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public IngameMissionProgressRequest missionRequest = new IngameMissionProgressRequest();
}