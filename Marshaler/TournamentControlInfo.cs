public class TournamentControlInfo
{
    public int SEQ;
    public DateTime prepareFromTime;
    public DateTime openFromTime;
    public DateTime postToTime;
    public DateTime replayToTime;
    public string title = string.Empty;
    public string bannerURL = string.Empty;
    public string contents = string.Empty;
    public List<long> playerUSNList = new List<long>();
    public int rewardGroupID;
    public bool isWeaponUse;
    public int damageRate;
    public int damageIncRate;
}