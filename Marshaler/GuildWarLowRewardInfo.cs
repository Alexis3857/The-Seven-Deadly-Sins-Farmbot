public class GuildWarLowRewardInfo
{
    public List<NeedItemInfo> winRewardItemInfoList = new List<NeedItemInfo>();
    public List<NeedItemInfo> pointRewardItemInfoList = new List<NeedItemInfo>();
    public int tier;
    public GuildInfo guildInfo = new GuildInfo();
    public GuildInfo opponentGuildInfo = new GuildInfo();
    public int battlePoint;
    public int opponentBattlePoint;
    public bool isRewardExist;
}