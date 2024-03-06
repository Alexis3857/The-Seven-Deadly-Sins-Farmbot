public class ExtensionStageInfo
{
    public byte openType;
    public int remainPlayTimeSec;
    public int nextOpenTimeSec;
    public int remainKeyOpenTimeSec;
    public DayOfWeek dayOfWeek = new DayOfWeek();
    public List<WeekStageType> openStageTypeList = new List<WeekStageType>();
}