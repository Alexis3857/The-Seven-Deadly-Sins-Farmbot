public class MercenaryDetailInfo
{
    public long usn;
    public UserHero mercenaryHero = new UserHero();
    public UserSkin mercenarySkin = new UserSkin();
    public List<UserWeapon> mercenaryWeaponList = new List<UserWeapon>();
    public List<UserCostumeSkin> skinCostumeList = new List<UserCostumeSkin>();
    public List<UserCostumeWeapon> weaponCostumeList = new List<UserCostumeWeapon>();
    public List<UserCostumeHead> headCostumeList = new List<UserCostumeHead>();
    public List<UserCostumeCraftUpgradeInfo> costumeCraftUpgradeInfoList = new List<UserCostumeCraftUpgradeInfo>();
}