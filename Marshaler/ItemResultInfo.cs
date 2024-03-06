public class ItemResultInfo
{
    public ItemType itemType;
    public UserCommonItem userItemInfo = new UserCommonItem();
    public UserHero userHeroInfo = new UserHero();
    public UserSkin userSkinInfo = new UserSkin();
    public UserWeapon userWeaponInfo = new UserWeapon();
    public UserCostumeSkin userCostumeSkin = new UserCostumeSkin();
    public UserCostumeWeapon userCostumeWeapon = new UserCostumeWeapon();
    public UserCostumeHead userCostumeHead = new UserCostumeHead();
    public UserArtifact userArtifact = new UserArtifact();
    public int getItemCount;
    public DropBoxGrade ingameResultDropBoxGrade;
    public int ownerSkinID;
    public int ownerCostumeID;
    public int skinExp;
    public int buffAddCount;
    public int ownerArtifactCardID;
    public bool isGrowthPointUpdate;
    public int growthPoint;
    public bool upgradeSkin;
    public int prevSkinID;
}