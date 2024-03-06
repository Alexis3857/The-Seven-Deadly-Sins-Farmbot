public class NoticeInfo
{
    public int seq;
    public DateTime fromDate;
    public DateTime toDate;
    public string noticeTimeColor = string.Empty;
    public string descriptionColor = string.Empty;
    public short priority;
    public OSType targetOSType;
    public DateTime noticeStartTime;
    public DateTime noticeEndTime;
    public NoticeType noticeType;
    public byte languageSet;
    public List<NoticeLanguageData> noticeLanguageDataList = new List<NoticeLanguageData>();
    public NoticeSpecificData specificData = new NoticeSpecificData();
}