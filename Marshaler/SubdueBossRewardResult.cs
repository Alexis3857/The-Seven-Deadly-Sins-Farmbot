public class SubdueBossRewardResult
{
    public bool isVictory;
    public List<SubdueBossRewardRank> rankList = new List<SubdueBossRewardRank>();
    public List<long> defeatMemberUSNs = new List<long>();
    public ItemResultInfo goldItemResultInfo = new ItemResultInfo();
    public List<ItemResultInfo> rewardHostResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> rewardRankResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> rewardLostResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> rewardDamageRangeResultInfoList = new List<ItemResultInfo>();
    public UserADViewInfo adViewRouletteInfo = new UserADViewInfo();
    public List<UserGlobalDropEventInfo> updateUserGlobalDropEventInfoList = new List<UserGlobalDropEventInfo>();
    public List<ItemResultInfo> rewardGlobalDropResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> rewardSoloResultInfoList = new List<ItemResultInfo>();
    public List<int> usedEventLobbyBuffIdList = new List<int>();
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
}