public class UserEventDiceInfo
{
    public int eventSEQ;
    public int eventSubIndex;
    public int rollCount;
    public int position;
    public int activeQuestionID;
    public int raceCount;
    public int raceRewardFlag;
    public bool isBonusDice;
    public List<int> currentRollList = new List<int>();
    public bool isNeedEvent;
}