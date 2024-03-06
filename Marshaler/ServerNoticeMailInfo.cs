public class ServerNoticeMailInfo
{
    public int noticeMailSEQ;
    public DateTime sendDate;
    public DateTime expireDate;
    public List<NeedItemInfo> getItemList = new List<NeedItemInfo>();
    public bool checkAccountCreateTime;
    public byte languageSet;
    public List<NoticeMailLanguageData> noticeMailLanguageDataList = new List<NoticeMailLanguageData>();
    public NoticeMailLanguageData specificData = new NoticeMailLanguageData();
}