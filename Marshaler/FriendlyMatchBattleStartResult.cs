﻿public class FriendlyMatchBattleStartResult
{
    public APInfo apInfo = new APInfo();
    public bool isBuffUsed;
    public FoodBuffInfo foodBuffInfo = new FoodBuffInfo();
    public ItemResultInfo useItemResultInfo = new ItemResultInfo();
    public long playKey;
    public byte playMode;
    public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>();
    public MissionResult missionResult = new MissionResult();
    public OtherPlayerTeamInfo otherPlayerTeamInfo = new OtherPlayerTeamInfo();
}