public class ServerEventInfo
{
    public int seq;
    public ServerEventType eventType;
    public string eventJson = string.Empty;
    public string eventTitle = string.Empty;
    public string eventSubTitle = string.Empty;
    public string imgURL = string.Empty;
    public string linkURL = string.Empty;
    public byte priority;
    public string description = string.Empty;
    public byte tabNumber;
    public string tabName = string.Empty;
    public byte tabPriority;
    public int startRemainSec;
    public int endRemainSec;
    public DateTime toDate;
    public DateTime fromDate;
    public EventOpenType eventOpenType;
    public int nextOpenReaminSec;
    public int playAbleRemainSec;
    public int timeIndex;
    public bool maintenance;
    public byte emphasis;
}