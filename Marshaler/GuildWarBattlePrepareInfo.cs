public class GuildWarBattlePrepareInfo
{
    public byte defenceBMSlotCount;
    public byte squadBMSlotCount;
    public List<UserTeam> defenceUserTeamList = new List<UserTeam>();
    public List<GuildWarSquadSlot> guildWarSquadSlotList = new List<GuildWarSquadSlot>();
    public List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList = new List<GuildWarDefenceTeamInfo>();
    public List<GuildWarTeamBuff> guildWarDefenceTeamBuffList = new List<GuildWarTeamBuff>();
}