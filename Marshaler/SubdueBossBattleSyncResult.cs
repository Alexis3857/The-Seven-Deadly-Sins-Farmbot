public class SubdueBossBattleSyncResult
{
    public int gameSN;
    public int totalDamage;
    public bool bossDestroy;
    public int remainBattleEndSec;
    public List<SubdueBossBattleSyncInfo> battleSyncList = new List<SubdueBossBattleSyncInfo>();
    public List<SubdueBossRewardRank> battleRanking = new List<SubdueBossRewardRank>();
}