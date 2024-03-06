public class OtherPlayerWeapon
{
    public int weaponSerial;
    public int weaponBaseID;
    public byte upgrade;
    public byte evolution;
    public List<UserWeaponPassiveSkill> addPassiveSkillList = new List<UserWeaponPassiveSkill>();
    public UserWeaponPassiveSkill addMagicSkill = new UserWeaponPassiveSkill();
    public int defaultOptionValue;
    public byte carveHeroGroup;
}