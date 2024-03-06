public class CheatResult
{
    public List<ItemResultInfo> itemResultInfoList = new List<ItemResultInfo>();
    public List<SideStageClearInfo> sideStageClearInfoList = new List<SideStageClearInfo>();
    public UserDailyReset dailyReset = new UserDailyReset();
    public int userExp;
    public int mainStageTopClearID;
    public int guildPoint;
    public List<UserTeam> userTeamList = new List<UserTeam>();
    public int clearQuestID;
    public int removeQuestID;
    public DestroyDiscoverInfo destroyDiscoverInfo = new DestroyDiscoverInfo();
    public List<UserTutorialInfo> userTutorialInfoList = new List<UserTutorialInfo>();
    public List<UserNpc> userNpcList = new List<UserNpc>();
    public MissionResult missionResult = new MissionResult();
    public DestroyCheatInfo destroyCheatInfo = new DestroyCheatInfo();
    public ApRewardInfo apRewardInfo = new ApRewardInfo();
    public List<QuestProgressInfo> userQuestProgressInfoList = new List<QuestProgressInfo>();
    public UserRecipeInfo userRecipeInfo = new UserRecipeInfo();
    public FoodBuffInfo foodBuffInfo = new FoodBuffInfo();
    public StageInfo stageInfo = new StageInfo();
    public string cheatType = string.Empty;
    public string cheatMessage = string.Empty;
    public int currentTimeAttackMissionDays;
    public UserHeroGachaGaugeInfo gachaGaugeInfo = new UserHeroGachaGaugeInfo();
}