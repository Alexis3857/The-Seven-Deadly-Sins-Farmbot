public class StageClearResultInfo
{
    public int userExp;
    public APInfo apInfo = new APInfo();
    public bool isWin;
    public List<BattleSkinResultInfo> battleSkinResultInfoList = new List<BattleSkinResultInfo>();
    public List<UserNpcResult> npcResultList = new List<UserNpcResult>();
    public ItemResultInfo goldItemResultInfo = new ItemResultInfo();
    public List<ItemResultInfo> ingameItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> questItemResultInfoList = new List<ItemResultInfo>();
    public ItemResultInfo firstItemResultInfo = new ItemResultInfo();
    public ItemResultInfo clearItemResultInfo = new ItemResultInfo();
    public List<ItemResultInfo> globalDropItemResultInfoList = new List<ItemResultInfo>();
    public ItemResultInfo gaugeRewardItemResultInfo = new ItemResultInfo();
    public ItemResultInfo passiveDropItemInfo = new ItemResultInfo();
    public ItemResultInfo additionalItemResultInfo = new ItemResultInfo();
    public List<ItemResultInfo> fixedItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> firstClearItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> inGameMissionRewardItemResultInfoList = new List<ItemResultInfo>();
    public ItemResultInfo demonPointItemResultInfo = new ItemResultInfo();
    public bool isFirstClear;
    public int playStageID;
    public StageInfo stageInfo = new StageInfo();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public List<UserPlayCountEventInfo> playCountEventInfoList = new List<UserPlayCountEventInfo>();
    public int ingameGoldBuffAddValue;
    public int usedFoodID;
    public List<UserGlobalDropEventInfo> updateUserGlobalDropEventInfoList = new List<UserGlobalDropEventInfo>();
    public UserADViewInfo adViewRouletteInfo = new UserADViewInfo();
    public List<UserHeroPassiveGroupInfo> heroPassiveGroupInfoList = new List<UserHeroPassiveGroupInfo>();
    public List<int> usedEventLobbyBuffIdList = new List<int>();
    public bool isAbuseDetect;
}