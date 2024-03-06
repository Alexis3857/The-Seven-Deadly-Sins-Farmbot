public class EmergencyNoticeInfo
{
    public int seq;
    public DateTime fromDate;
    public DateTime toDate;
    public DateTime maintenanceStartTime;
    public DateTime maintenanceEndTime;
    public OSType targetOSType;
    public bool isDisplayTime;
    public int displayTermSec;
    public string message = string.Empty;
}