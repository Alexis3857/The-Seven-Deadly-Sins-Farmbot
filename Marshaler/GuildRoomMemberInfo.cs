public class GuildRoomMemberInfo
{
    public long userUSN;
    public string nickName = string.Empty;
    public GuildMemberGrade grade;
    public GuildRoomMemberState state;
    public int skinID;
    public int skinCostumeGroupID;
    public int weaponCostumeGroupID;
    public int headCostumeGroupID;
    public bool isHeadStyleChanged;
    public GuildRoomPoint point = new GuildRoomPoint();
    public GuildRoomMemberEmojiState emojiState;
    public int playTitleID;
}