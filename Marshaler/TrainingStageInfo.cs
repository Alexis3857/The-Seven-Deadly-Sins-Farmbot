public class TrainingStageInfo
{
    public int remainSecToReset;
    public int remainSecToClose;
    public List<TrainingStageSlotInfo> stageList = new List<TrainingStageSlotInfo>();
    public int rewardGauge;
    public int point;
    public OtherPlayerTeamInfo mirrorTeamInfo = new OtherPlayerTeamInfo();
    public int trainingTaskID;
    public int trainingTaskCount;
    public List<TrainingStageClearStarInfo> clearStarInfoList = new List<TrainingStageClearStarInfo>();
}