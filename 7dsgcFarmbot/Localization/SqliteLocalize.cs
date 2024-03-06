using Microsoft.Data.Sqlite;
using System.Text;

// The sqlite database is composed of a single table called TRANSLATION
// That table has 3 columns "id", "si" and "translated"
// "id" is a text ie : "DB_hero_name_100100"
// "si" is an int ie : 25909
// "translated" is an xored text ie : "Meliodas" (after decryption)
// "id" and "si" are unique so we can retrieve a string with only one of them
public class SqliteLocalize
{
    public const string NotFoundString = "NONE DB";

    private const string StringXorKey = "NetmarbleFun&Cherry";  // Used to create XorKey in the constructor 

    private const string GetStringFromSiCommand = "SELECT translated FROM TRANSLATION WHERE si = @si";

    private const string GetStringFromIdCommand = "SELECT translated FROM TRANSLATION WHERE id = @id";

    private const int MaxKeyIndex = 1000000;

    public bool IsLoaded { get; private set; }

    private int[] XorKey { get; }  // Xor key built from StringXorKey in the constructor

    private StringBuilder SB { get; } = new StringBuilder();

    private SqliteCommand? SiCommand { get; set; }  // GetStringFromSiCommand

    private SqliteCommand? IdCommand { get; set; }  // GetStringFromIdCommand

    private SqliteConnection? DBConnection { get; set; }

    private SqliteParameter ParamBySi { get; } = new SqliteParameter("@si", SqliteType.Text);

    private SqliteParameter ParamById { get; } = new SqliteParameter("@id", SqliteType.Text);

    public SqliteLocalize()
    {
        XorKey = new int[StringXorKey.Length];
        for (int i = 0; i < XorKey.Length; i++)
        {
            XorKey[i] = char.ConvertToUtf32(StringXorKey, i);
        }
    }

    ~SqliteLocalize()
    {
        Reset();
    }

    public void Load(string dbFilePath)
    {
        if (!File.Exists(dbFilePath))
        {
            throw new FileNotFoundException($"Failed to load the localization database. The file {dbFilePath} was not found.");
        }
        DBConnection = new SqliteConnection($"Data Source={dbFilePath}");
        DBConnection.Open();
        using (SqliteCommand pragmaCommand = DBConnection.CreateCommand())
        {
            pragmaCommand.CommandText = "PRAGMA synchronous=OFF";
            pragmaCommand.ExecuteNonQuery();
            pragmaCommand.CommandText = "PRAGMA temp_store=MEMORY";
            pragmaCommand.ExecuteNonQuery();
        }
        IdCommand = DBConnection.CreateCommand();
        IdCommand.CommandText = GetStringFromIdCommand;
        IdCommand.Parameters.Clear();
        IdCommand.Parameters.Add(ParamById);
        IdCommand.Prepare();

        SiCommand = DBConnection.CreateCommand();
        SiCommand.CommandText = GetStringFromSiCommand;
        SiCommand.Parameters.Clear();
        SiCommand.Parameters.Add(ParamBySi);
        SiCommand.Prepare();
        IsLoaded = true;
    }

    public void Reset()
    {
        if (IsLoaded)
        {
            if (SiCommand != null)
            {
                SiCommand.Dispose();
                SiCommand = null;
            }
            if (IdCommand != null)
            {
                IdCommand.Dispose();
                IdCommand = null;
            }
            if (DBConnection != null)
            {
                DBConnection.Close();
                DBConnection.Dispose();
                DBConnection = null;
            }
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //SqliteConnection.ClearAllPools();
            IsLoaded = false;
        }
    }

    private string ToOriginalString(string str)
    {
        SB.Length = 0;
        int i = 0;
        int length = str.Length;
        while (i < length)
        {
            if (str[i] == '\\' && i + 1 < length)
            {
                char c = str[i + 1];
                if (c != '0')
                {
                    if (c != '\\')
                    {
                        if (c == 'n')
                        {
                            SB.Append('\n');
                            i += 2;
                        }
                    }
                    else
                    {
                        SB.Append('\\');
                        i += 2;
                    }
                }
                else
                {
                    SB.Append('\0');
                    i += 2;
                }
            }
            else
            {
                SB.Append(str[i++]);
            }
        }
        return SB.ToString();
    }

    private string StringDecryption(string str)
    {
        str = ToOriginalString(str);
        int length = str.Length;
        int num = length;
        SB.Length = 0;
        for (int i = 0; i < length; i++)
        {
            SB.Append(char.ConvertFromUtf32(char.ConvertToUtf32(str, i) ^ XorKey[num % XorKey.Length]));
            num += length;
            if (num > MaxKeyIndex)
            {
                num = length;
            }
        }
        return SB.ToString();
    }

    public string GetString(int si)
    {
        if (IsLoaded && SiCommand != null)
        {
            ParamBySi.Value = si;
            using (SqliteDataReader dataReader = SiCommand.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    return StringDecryption(dataReader.GetString(0));
                }
            }
        }
        return NotFoundString;
    }

    public string GetString(string id)
    {
        if (IsLoaded && IdCommand != null)
        {
            ParamById.Value = id;
            using (SqliteDataReader dataReader = IdCommand.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    return StringDecryption(dataReader.GetString(0));
                }
            }
        }
        return NotFoundString;
    }
}