public class EventExchangeCardInfo
{
    public int eventSEQ;
    public int eventSubIndex;
    public int resetCount;
    public int selectCount;
    public bool isCompleteChance;
    public int remainChanceSelectCount;
    public List<int> selectedRewardIDList = new List<int>();
    public List<EventExchangeCardDetailInfo> selectedRewardInfoList = new List<EventExchangeCardDetailInfo>();
    public List<EventExchangeCardDetailInfo> detailInfoList = new List<EventExchangeCardDetailInfo>();
}