public class GuildDonationResult
{
    public List<ItemResultInfo> useItemResultInfoList = new List<ItemResultInfo>();
    public List<ItemResultInfo> getItemResultInfoList = new List<ItemResultInfo>();
    public int currentGuildExp;
    public int currentAccumGuildContribution;
    public int currentWeeklyContribution;
    public byte guildDonationID;
    public byte guildDonationCount;
    public byte guildDonationContribution;
    public MissionResult missionResult = new MissionResult();
}