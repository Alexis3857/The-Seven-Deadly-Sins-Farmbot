public class ClientSendUserAttendanceInfo
{
    public bool isRewardedToday;
    public AttendanceType attendanceType;
    public byte attendanceGroup;
    public byte rewardIndex;
    public byte welcomeRewardIndex;
    public bool comebackMissionEnable;
    public int combackEndRemainSec;
    public bool pvpComebackMissionEnable;
    public int pvpCombackEndRemainSec;
    public AttendanceType lastRewardedType;
    public byte lastRewardedGroup;
    public byte lastRewardedIndex;
}