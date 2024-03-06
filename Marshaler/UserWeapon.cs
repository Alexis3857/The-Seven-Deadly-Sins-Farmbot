public class UserWeapon
{
    public bool isEvolutionRewarded;
    public int weaponSerial;
    public int weaponBaseID;
    public byte upgrade;
    public byte evolution;
    public List<UserWeaponPassiveSkill> addPassiveSkillList = new List<UserWeaponPassiveSkill>();
    public UserWeaponPassiveSkill addMagicSkill = new UserWeaponPassiveSkill();
    public DateTime getWeaponTime;
    public bool isEquip;
    public int defaultOptionValue;
    public bool isLock;
    public byte carveHeroGroup;
}