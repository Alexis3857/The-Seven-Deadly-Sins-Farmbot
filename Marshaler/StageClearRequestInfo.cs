public class StageClearRequestInfo
{
    public int stageID;
    public bool isWin;
    public List<BattleSkinInfo> battleSkinInfoList = new List<BattleSkinInfo>();
    public FriendBattleSkinInfo friendBattleSkinInfo = new FriendBattleSkinInfo();
    public int teamIndex;
    public int eventSEQ;
    public long mercenaryUSN;
    public int battlePowerPoint;
    public IngameMissionProgressRequest missionRequest = new IngameMissionProgressRequest();
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public bool isAutoPlay;
    public int turnCount;
    public int clientTimeSec;
    public double deltaTime;
    public long packetSendTick;
    public int tickCount;
    public int stopwatch;
    public int dateTime;
    public byte stageIndex;
    public int battlePoint;
    public byte phase;
    public DateTime clearDateTime;
    public string stageString = string.Empty;
    public string battleAbuseLog = string.Empty;
    public string battleSimulationLog = string.Empty;
    public int battleEncounter;
}