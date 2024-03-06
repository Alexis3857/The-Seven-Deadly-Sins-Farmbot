public class DBDemonpointStageRow : ITableRowIndexer
{
    public int Id => id;

    public string ControlType => control_type;

    public int Demonpoint => demonpoint;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        control_type = reader.ReadString();
        demonpoint = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string control_type;

    private int demonpoint;
}