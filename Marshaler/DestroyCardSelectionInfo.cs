public class DestroyCardSelectionInfo
{
    public long usn;
    public short roundID;
    public int selectedCardIndex;
    public byte autoInput;
    public List<int> targetCampList = new List<int>();
    public List<int> targetIndexList = new List<int>();
    public byte isMove;
    public int targetCardIndex;
}