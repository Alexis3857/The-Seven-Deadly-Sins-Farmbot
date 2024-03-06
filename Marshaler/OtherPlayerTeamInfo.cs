public class OtherPlayerTeamInfo
{
    public long usn;
    public int foodBuffItemID;
    public List<OtherPlayerSlotInfo> teamSlotList = new List<OtherPlayerSlotInfo>();
    public List<OtherPlayerSlotInfo> fateSlotList = new List<OtherPlayerSlotInfo>();
    public List<UserCostumeSkin> skinCostumeList = new List<UserCostumeSkin>();
    public List<UserCostumeWeapon> weaponCostumeList = new List<UserCostumeWeapon>();
    public List<UserCostumeHead> headCostumeList = new List<UserCostumeHead>();
    public List<int> lobbyBuffItemIDList = new List<int>();
    public List<int> guildSkillUseList = new List<int>();
    public int aiLevel;
    public List<int> playTitleIDList = new List<int>();
    public AICustomizingInfo aiCustomizingInfo = new AICustomizingInfo();
    public OtherArtifactInfo artifactInfo = new OtherArtifactInfo();
    public List<OtherConstellationStatusInfo> constellationStatusInfoList = new List<OtherConstellationStatusInfo>();
    public List<UserCostumeCraftUpgradeInfo> costumeCraftUpgradeInfoList = new List<UserCostumeCraftUpgradeInfo>();
}