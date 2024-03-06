public class ServerEventDBInfo
{
    public int seq;
    public ServerEventType eventType;
    public string eventJson = string.Empty;
    public string eventTitle = string.Empty;
    public string eventSubTitle = string.Empty;
    public string imageURL = string.Empty;
    public string linkURL = string.Empty;
    public byte priority;
    public string description = string.Empty;
    public byte tabNumber;
    public string tabName = string.Empty;
    public byte tabPriority;
    public DateTime toDate;
    public DateTime fromDate;
    public bool maintenance;
    public byte emphasis;
    public List<int> subIndexList = new List<int>();
}