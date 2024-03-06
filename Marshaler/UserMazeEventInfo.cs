public class UserMazeEventInfo
{
    public int eventSEQ;
    public int eventSubIndex;
    public int stageID;
    public int rewardedIndex;
    public int randomBattleStageID;
    public int randomStageID1;
    public int randomStageID2;
    public int randomValue1;
    public int randomValue2;
    public int startedStageID;
    public byte heroRefreshCount;
    public byte passiveRefreshCount;
    public int topSpotID;
    public MazeClearBonusProgressType clearBonusProgressType;
    public int seasonShopBuyPoint;
    public List<int> selectablePassiveIDList = new List<int>();
    public List<int> selectableHeroIDList = new List<int>();
    public List<int> passiveIDList = new List<int>();
    public List<int> lastPassiveIDList = new List<int>();
    public List<int> savedPassiveIDList = new List<int>();
    public List<MazeHeroInfo> mazeHeroInfoList = new List<MazeHeroInfo>();
    public List<MazeHeroInfo> savedHeroInfoList = new List<MazeHeroInfo>();
    public List<int> shopPassiveIDList = new List<int>();
    public List<int> shopIDList = new List<int>();
    public List<int> shopBuyProductIDList = new List<int>();
    public List<int> shopBuffIDList = new List<int>();
    public List<int> shopBuyBuffIDList = new List<int>();
    public List<EventMazeBuffInfo> buffInfoList = new List<EventMazeBuffInfo>();
    public List<MazeHeroInfo> lastHeroInfoList = new List<MazeHeroInfo>();
    public List<EventMazeSeasonShopBuyInfo> seasonShopBuyInfoList = new List<EventMazeSeasonShopBuyInfo>();
    public bool isSeasonShopInitialized;
}