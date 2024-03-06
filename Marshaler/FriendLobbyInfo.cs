public class FriendLobbyInfo
{
    public long friendUSN;
    public string friendNickName = string.Empty;
    public int friendExp;
    public bool friendCookingEatAlready;
    public short friendCookingEatTotalCount;
    public List<FriendLobbyNpcInfo> friendLobbyNpcInfoList = new List<FriendLobbyNpcInfo>();
    public LobbyVisualType friendLobbyVisualType;
    public List<FriendLobbyFurnitureInfo> friendLobbyFurnitureInfoList = new List<FriendLobbyFurnitureInfo>();
    public int topClearMainStageID;
    public QuestProgressInfo storyQuestProgressInfo = new QuestProgressInfo();
    public List<UserTutorialInfo> userTutorialInfoLIst = new List<UserTutorialInfo>();
    public FriendLobbyMusicInfo friendMusicInfo = new FriendLobbyMusicInfo();
}