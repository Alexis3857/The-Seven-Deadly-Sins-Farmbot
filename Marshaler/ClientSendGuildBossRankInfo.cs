public class ClientSendGuildBossRankInfo
{
    public int mainSkinID;
    public int userExp;
    public string nickName = string.Empty;
    public string guildName = string.Empty;
    public int guildIconID;
    public int guildSubIconID;
    public int guildBGIconID;
    public RedisGuildBossRankInfo redisGuildBossRankInfo = new RedisGuildBossRankInfo();
    public GuildInvitationState guildInvitationState;
}