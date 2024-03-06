public class StageClearTicketResult
{
    public byte serverClearCount;
    public StageTicketClearInfo ticketClearCountInfo = new StageTicketClearInfo();
    public ItemResultInfo ticketItemResultInfo = new ItemResultInfo();
    public ItemResultInfo useItemResultInfo = new ItemResultInfo();
    public int playStageID;
    public int userExp;
    public APInfo staminaInfo = new APInfo();
    public StageInfo stageInfo = new StageInfo();
    public ItemResultInfo goldItemResultInfo = new ItemResultInfo();
    public List<ItemResultInfo> ingameItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> questItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> clearItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> globalDropItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> gaugeRewardItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> additionalItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> weekEventFixedItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> passiveItemResultInfoList = new List<ItemResultInfo>();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public List<UserPlayCountEventInfo> playCountEventInfoList = new List<UserPlayCountEventInfo>();
    public int ingameGoldBuffAddValue;
    public List<UserGlobalDropEventInfo> updateUserGlobalDropEventInfoList = new List<UserGlobalDropEventInfo>();
    public List<BattleSkinResultInfo> battleSkinResultInfoList = new List<BattleSkinResultInfo>();
    public List<UserNpcResult> npcResultList = new List<UserNpcResult>();
    public List<UserHeroPassiveGroupInfo> heroPassiveGroupInfoList = new List<UserHeroPassiveGroupInfo>();
    public int freeClearTicketUseCount;
    public List<int> usedEventLobbyBuffIdList = new List<int>();
}