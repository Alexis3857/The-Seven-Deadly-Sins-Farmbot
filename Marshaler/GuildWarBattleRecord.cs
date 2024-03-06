public class GuildWarBattleRecord
{
    public int recordID;
    public byte defenceTeamIndex;
    public int winGuildSerial;
    public byte battleEnd;
    public int attackerGuildSerial;
    public string attackerNickame = string.Empty;
    public List<int> attackSkinIDList = new List<int>();
    public List<int> deadHeroIDList = new List<int>();
    public int guildSerial;
    public int areaID;
    public byte battleNumber;
    public long attackerUSN;
}