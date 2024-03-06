public class DestroyClearVerificationRequest
{
    public bool isClear;
    public List<DestroyUnitStatus> unitStatusList = new List<DestroyUnitStatus>();
    public string stageInfoString = string.Empty;
    public DateTime clearDateTime;
    public int battleEncounter;
}