public class OtherPlayerSlotInfo
{
    public byte index;
    public int heroID;
    public int skinID;
    public int skinExp;
    public byte skinAwaken;
    public List<byte> researchList = new List<byte>();
    public List<OtherPlayerWeapon> equipWeaponList = new List<OtherPlayerWeapon>();
    public int skinCostumeGroupID;
    public int weaponCostumeGroupID;
    public int headCostumeGroupID;
    public bool isHeadStyleChanged;
    public byte skillLevelUpCount;
    public byte maxLevelCount;
    public byte passiveSkillLevel;
    public List<int> registeredCostumeGroupList = new List<int>();
    public byte transcend;
    public byte skinExceed;
    public int registeredMadeCostumeGroup;
}