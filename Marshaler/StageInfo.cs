﻿public class StageInfo
{
    public int mainStageTopClearID;
    public int anotherMainStageTopClearID;
    public int anotherFreeStageFlag;
    public int northMainStageTopClearID;
    public int northFreeStageFlag;
    public int disasterMainStageTopClearID;
    public int disasterFreeStageFlag;
    public List<SideStageClearInfo> sideStageClearInfoList = new List<SideStageClearInfo>();
    public List<long> weeklyStageFirstClearInfoList = new List<long>();
    public List<long> questStageFirstClearInfo = new List<long>();
    public List<long> descentStageFirstClearInfo = new List<long>();
    public List<StagePlayCountInfo> stagePlayCountInfoList = new List<StagePlayCountInfo>();
    public DayOfWeek dayofWeek = new DayOfWeek();
    public List<UserExtraStageInfo> extraStageInfoList = new List<UserExtraStageInfo>();
    public int eventGauge;
    public int goldGauge;
    public int upgradeGauge1;
    public int upgradeGauge2;
    public int upgradeGauge3;
    public int evolutionGauge1;
    public int evolutionGauge2;
    public int evolutionGauge3;
    public int timelimitGauge;
    public int timelimitGauge2;
    public int timelimitGauge3;
    public long timelimitStageRemainSec;
    public long timelimitStageRemainSec2;
    public long timelimitStageRemainSec3;
    public TrainingStageInfo trainingStageInfo = new TrainingStageInfo();
    public int eventWeeklyStageID;
    public List<EventDisasterDestroyClearInfo> eventDisasterDestroyClearInfoList = new List<EventDisasterDestroyClearInfo>();
    public int coinDungeonGauge;
    public long coinDungeonStageRemainSec;
    public long coinDungeonWeekResetRemainSec;
    public int coinDungeonWeekOpenCount;
    public int coinDungeonGauge2;
    public long coinDungeonStageRemainSec2;
    public int coinDungeonWeekOpenCount2;
    public int coinDungeonGauge3;
    public long coinDungeonStageRemainSec3;
    public int coinDungeonWeekOpenCount3;
    public List<long> yggdrasilTowerStageFirstClearInfoList = new List<long>();
    public List<ClientSendCreatureNestStageInfo> creatureNestStageInfoList = new List<ClientSendCreatureNestStageInfo>();
    public short weeklyResetRemainSec;
    public short weeklyBuffUseHour;
    public List<UserFinalBossDifficultyRankInfo> finalBossFirstClearInfoList = new List<UserFinalBossDifficultyRankInfo>();
    public CreatureNestColosseumSeasonInfo creatureColosseumSeasonInfo = new CreatureNestColosseumSeasonInfo();
    public List<ClientSendCreatureNestStageInfo> creatureColosseumStageInfoList = new List<ClientSendCreatureNestStageInfo>();
}