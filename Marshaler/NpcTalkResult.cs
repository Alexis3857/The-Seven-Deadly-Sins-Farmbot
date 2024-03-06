public class NpcTalkResult
{
    public UserNpc userNpc = new UserNpc();
    public List<ItemResultInfo> getItemResultInfoList = new List<ItemResultInfo>();
    public MissionResult missionResult = new MissionResult();
    public int interactiveQuestionID;
    public InteractiveChoice choice;
    public int guestID;
    public int interactiveTalkID;
}