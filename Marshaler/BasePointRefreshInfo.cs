public class BasePointRefreshInfo
{
    public bool isGuildKickOut;
    public GuildMemberInfo guildMemberInfo = new GuildMemberInfo();
    public LobbyReddotInfo lobbyReddotInfo = new LobbyReddotInfo();
    public List<ClientSendGuildRankInfo> prevTopGuildRankInfoList = new List<ClientSendGuildRankInfo>();
    public LobbyRandomShopInfo lobbyRandomShopInfo = new LobbyRandomShopInfo();
}