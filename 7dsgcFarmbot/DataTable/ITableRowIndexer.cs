public interface ITableRowIndexer  // Each table implement ITableRowIndexer
{
    int GetRowIndex();  // Each element of a table has a different index so that the table can be stored in a Dictionary

    bool ReadToStream(BinaryReader reader);  // Reads and fills the fields of the object and advances the position of the reader before the next object
}
