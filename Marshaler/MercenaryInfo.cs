public class MercenaryInfo
{
    public DateTime mercenaryLastUseTime;
    public long mercenaryUsn;
    public string mercenaryNickname = string.Empty;
    public int mercenaryUserExp;
    public int mercenaryRemainUsingSec;
    public FriendState mercenaryState;
    public List<MercenarySlotInfo> mercenarySlotInfoList = new List<MercenarySlotInfo>();
    public string guildName = string.Empty;
    public int guildIconID;
    public int guildSubIconID;
    public int guildBGIconID;
}