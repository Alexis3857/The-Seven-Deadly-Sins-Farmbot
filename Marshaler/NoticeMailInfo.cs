public class NoticeMailInfo
{
    public int noticeMailSEQ;
    public int expireRemainSEC;
    public string noticeTitle = string.Empty;
    public string noticeContents = string.Empty;
    public List<NeedItemInfo> getItemList = new List<NeedItemInfo>();
    public bool rewardGetStatus;
    public string linkURL = string.Empty;
    public bool isRefundMail;
    public NoticeMailType noticeMailType;
}