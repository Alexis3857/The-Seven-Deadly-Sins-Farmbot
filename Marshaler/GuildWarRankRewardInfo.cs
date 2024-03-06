public class GuildWarRankRewardInfo
{
    public GuildRankRedisInfo guildWarRankInfo = new GuildRankRedisInfo();
    public List<NeedItemInfo> rewardItemInfoList = new List<NeedItemInfo>();
    public int league;
    public int season;
    public List<NeedItemInfo> costumeRewardItemInfoList = new List<NeedItemInfo>();
    public bool isCostumeReceived;
    public DateTime costumeReceiveExpireDate;
    public List<NeedItemInfo> winRewardItemInfoList = new List<NeedItemInfo>();
}