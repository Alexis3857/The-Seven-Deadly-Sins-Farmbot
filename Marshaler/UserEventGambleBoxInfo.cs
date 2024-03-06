public class UserEventGambleBoxInfo
{
    public int eventSEQ;
    public ServerEventType eventType;
    public int eventSubIndex;
    public short step;
    public Dictionary<int, PickInfo> pickedDic = new Dictionary<int, PickInfo>();
}