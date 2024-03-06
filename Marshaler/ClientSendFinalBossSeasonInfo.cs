public class ClientSendFinalBossSeasonInfo
{
    public int currentSeasonID;
    public int currentFinalBossStageFlag;
    public List<FinalBossGroupInfo> finalBossGroupInfoList = new List<FinalBossGroupInfo>();
    public int remainFinalBossInitSec;
    public int currentFinalBossPointItemCount;
    public List<FinalBossSeasonInfo> finalBossSeasonInfoList = new List<FinalBossSeasonInfo>();
    public List<FinalBossBattleScoreInfo> finalBossBattleScoreInfoList = new List<FinalBossBattleScoreInfo>();
    public int prevSeasonID;
    public byte finalBossRankRewardOccured;
    public List<FinalBossVowInfo> finalBossVowInfoList = new List<FinalBossVowInfo>();
}