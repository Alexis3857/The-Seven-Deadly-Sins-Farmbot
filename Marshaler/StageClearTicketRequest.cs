public class StageClearTicketRequest
{
    public int stageID;
    public byte clearCount;
    public byte teamIndex;
    public List<BattleSkinInfo> battleSkinInfoList = new List<BattleSkinInfo>();
    public int eventSEQ;
    public int freeTicketEventSEQ;
}