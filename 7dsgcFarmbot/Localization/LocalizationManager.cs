using System.Text.RegularExpressions;

public static class LocalizationManager
{
    private const string RegexPattern = @"\[[A-F0-9\-]*?\]";  // The strings may contain color codes, we can get rid of them with this regex pattern

    private static SqliteLocalize? Localizer { get; set; }

    public static void Initialize(string localizationPath)
    {
        if (Localizer == null || !Localizer.IsLoaded)
        {
            ConsoleWriter.WriteLine("Initializing the localization...");
            Localizer = new SqliteLocalize();
            Localizer.Load(localizationPath);
        }
    }

    public static void Clear()
    {
        if (Localizer != null)
        {
            Localizer.Reset();
        }
    }

    public static string Localize(this int si)
    {
        if (si == -1 || Localizer == null)
        {
            return SqliteLocalize.NotFoundString;
        }
        return Regex.Replace(Localizer.GetString(si), RegexPattern, string.Empty);
    }

    public static string Localize(this string id)
    {
        if (string.IsNullOrEmpty(id) || Localizer == null)
        {
            return SqliteLocalize.NotFoundString;
        }
        return Regex.Replace(Localizer.GetString(id), RegexPattern, string.Empty);
    }
}