public class GuildWarLowBattleRecord
{
    public int recordID;
    public byte defenceTeamIndex;
    public int winGuildSerial;
    public byte battleEnd;
    public int attackerGuildSerial;
    public string attackerNickame = string.Empty;
    public List<int> attackSkinIDList = new List<int>();
    public int guildSerial;
    public int defenceUSN;
    public long attackerUSN;
}