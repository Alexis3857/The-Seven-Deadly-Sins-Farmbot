public class UserEventConquesClientSendInfo
{
    public int eventSEQ;
    public int eventSubIndex;
    public ServerEventType eventType;
    public List<EventConquestProductionDepotClientSendInfo> conquestProductionDepotInfoList = new List<EventConquestProductionDepotClientSendInfo>();
    public List<EventConquestAreaClientSendInfo> conquestAreaInfoList = new List<EventConquestAreaClientSendInfo>();
    public int lastedAttackAreaID;
    public int sceneIndex;
    public List<EventConquestUnitClientSendInfo> units = new List<EventConquestUnitClientSendInfo>();
    public List<int> stageClaerAreaList = new List<int>();
}