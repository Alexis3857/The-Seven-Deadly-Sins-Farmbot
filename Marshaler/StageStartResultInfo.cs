public class StageStartResultInfo
{
    public int stageID;
    public int ingameGold;
    public bool isGoldManta;
    public List<StageMonsterInfo> stageMonsterList = new List<StageMonsterInfo>();
    public APInfo apInfo = new APInfo();
    public MissionResult missionResult = new MissionResult();
    public bool isBuffUsed;
    public FoodBuffInfo foodBuffInfo = new FoodBuffInfo();
    public ItemResultInfo useItemResultInfo = new ItemResultInfo();
    public bool isRejoinEnable;
    public string rejoinData = string.Empty;
    public long playKey;
    public byte playMode;
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public byte stageIndex;
    public List<int> guildSkillUseList = new List<int>();
    public List<int> usedEventLobbyBuffIdList = new List<int>();
    public int battleEncounter;
}