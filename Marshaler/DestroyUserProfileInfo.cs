public class DestroyUserProfileInfo
{
    public long usn;
    public string nickname = string.Empty;
    public int userExp;
    public List<int> skinIDList = new List<int>();
    public List<int> skinChangeIDList = new List<int>();
    public List<int> weaponChangeIDList = new List<int>();
    public List<int> headChangeIDList = new List<int>();
    public List<bool> skinHeadStyleChangedList = new List<bool>();
    public int bossStageTopClearRegion;
    public int topClearStoryQuestID;
    public DestroyUserState userState;
    public int mainSkinID;
    public string guildName = string.Empty;
    public int guildIconID;
    public int guildSubIconID;
    public int guildBGIconID;
    public bool isAIEnable;
    public int playTitleID;
}