public class LobbyCollectResult
{
    public List<RecipeCollectInfo> recipeCollectInfoList = new List<RecipeCollectInfo>();
    public int buffNpcID;
    public int buffNpcValue;
    public int friendCookingEatCount;
    public byte collectPassiveUseCount;
    public ItemResultInfo goldRewardResultInfo = new ItemResultInfo();
    public List<ItemResultInfo> passiveItemResultInfoList = new List<ItemResultInfo>();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
}