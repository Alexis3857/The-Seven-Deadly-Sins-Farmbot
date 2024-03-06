public class BaseTable<ROWTYPE> where ROWTYPE : ITableRowIndexer  // Stores one type of db data and provides basic methods to access it
{
    public static DataTableManager.TableType TableType { get; private set; }  // Every ROWTYPE will have an instance BaseTable<ROWTYPE>

    public List<ROWTYPE> ListDBRows { get; } = new List<ROWTYPE>();

    private Dictionary<int, ROWTYPE> DictDBRows { get; } = new Dictionary<int, ROWTYPE>();

    public BaseTable(IEnumerator<ROWTYPE> dataEnum, DataTableManager.TableType table)
    {
        BaseTable<ROWTYPE>.TableType = table;
        while (dataEnum.MoveNext())
        {
            ROWTYPE rowtype = dataEnum.Current;
            int rowIndex = rowtype.GetRowIndex();
            if (!DictDBRows.ContainsKey(rowIndex))
            {
                DictDBRows.Add(rowIndex, rowtype);
                ListDBRows.Add(rowtype);
            }
        }
    }

    public ROWTYPE? GetData(int rowIndex)
    {
        if (!Contains(rowIndex))
        {
            return default(ROWTYPE);
        }
        return DictDBRows[rowIndex];
    }

    public bool Contains(int rowIndex)
    {
        return DictDBRows.ContainsKey(rowIndex);
    }

    public ROWTYPE? GetData(Predicate<ROWTYPE> condition)
    {
        return ListDBRows.Find(condition);
    }

    public List<ROWTYPE> GetDatas(Predicate<ROWTYPE> condition)
    {
        return ListDBRows.FindAll(condition);
    }
}