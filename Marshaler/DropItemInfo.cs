public class DropItemInfo
{
    public int dropItemID;
    public int dropItemCount;
    public DropBoxGrade dropBoxGrade;
    public int dropItemEvolutionCount;
    public int dropItemBuffAddCount;
    public int dropItemOptionValue;
    public List<int> addPassiveIDList = new List<int>();
    public List<int> addPassiveValueList = new List<int>();
    public int ownerHeroID;
    public int heroCoinID;
    public int heroCoinCount;
    public int skinLevel;
    public int skinExp;
    public byte skinAwaken;
    public byte skinMaxLevelCount;
    public byte heroGroupID;
    public int costumeGroupID;
    public int costumeReplaceItemID;
    public int costumeReplaceItemCount;
    public byte upgradeCount;
    public int ownerCostumeItemID;
    public DateTime expireDate;
    public bool weaponOptionMax;
    public bool selectedWeaponBaseOptionMax;
    public byte selectedWeaponRandomOptionFlag;
    public int selectedWeaponRandomOptionValue;
    public List<byte> selectedRandomPassiveIDList = new List<byte>();
}