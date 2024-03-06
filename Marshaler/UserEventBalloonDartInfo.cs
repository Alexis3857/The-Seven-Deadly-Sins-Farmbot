public class UserEventBalloonDartInfo
{
    public int eventSEQ;
    public ServerEventType eventType;
    public int eventSubIndex;
    public short step;
    public int score;
    public int totalScore;
    public byte dartType;
    public List<BalloonInfo> balloonList = new List<BalloonInfo>();
    public byte chanceType;
    public List<int> chanceBalloonList = new List<int>();
    public List<int> stepRewardedList = new List<int>();
    public List<int> totalRewardedList = new List<int>();
}