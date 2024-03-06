public class EventCookingResult
{
    public SuccessType successType;
    public byte dailyMeliodasCookingCount;
    public List<ItemResultInfo> useMaterialItemInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> getItemResultInfoList = new List<ItemResultInfo>();
    public UserEventRecipeInfo userRecipeInfo = new UserEventRecipeInfo();
    public MissionResult missionResult = new MissionResult();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public int cookingCount;
    public UserNpcResult npcResult = new UserNpcResult();
    public bool isImmediately;
}