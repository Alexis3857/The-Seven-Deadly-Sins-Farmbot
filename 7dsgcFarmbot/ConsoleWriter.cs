using System.Text.RegularExpressions;

public static class ConsoleWriter  // Code taken from https://stackoverflow.com/a/69650936
{
    public static void Write(string msg)
    {
        if (string.IsNullOrEmpty(msg))
        {
            return;
        }

        Match color_match = Regex.Match(msg, @"{[FB]C=[a-z]+}|{\/[FB]C}", RegexOptions.IgnoreCase);
        if (color_match.Success)
        {
            ConsoleColor initial_background_color = Console.BackgroundColor;
            ConsoleColor initial_foreground_color = Console.ForegroundColor;
            List<ConsoleColor> background_color_history = new List<ConsoleColor>();
            List<ConsoleColor> foreground_color_history = new List<ConsoleColor>();

            int current_index = 0;

            while (color_match.Success)
            {
                if ((color_match.Index - current_index) > 0)
                {
                    Console.Write(msg.Substring(current_index, color_match.Index - current_index));
                }

                if (color_match.Value.StartsWith("{BC=", StringComparison.OrdinalIgnoreCase)) // set background color
                {
                    string background_color_name = GetColorNameFromMatch(color_match);
                    Console.BackgroundColor = GetParsedColorAndAddToHistory(background_color_name, background_color_history, initial_background_color);
                }
                else if (color_match.Value.Equals("{/BC}", StringComparison.OrdinalIgnoreCase)) // revert background color
                {
                    Console.BackgroundColor = GetLastColorAndRemoveFromHistory(background_color_history, initial_background_color);
                }
                else if (color_match.Value.StartsWith("{FC=", StringComparison.OrdinalIgnoreCase)) // set foreground color
                {
                    string foreground_color_name = GetColorNameFromMatch(color_match);
                    Console.ForegroundColor = GetParsedColorAndAddToHistory(foreground_color_name, foreground_color_history, initial_foreground_color);
                }
                else if (color_match.Value.Equals("{/FC}", StringComparison.OrdinalIgnoreCase)) // revert foreground color
                {
                    Console.ForegroundColor = GetLastColorAndRemoveFromHistory(foreground_color_history, initial_foreground_color);
                }

                current_index = color_match.Index + color_match.Length;
                color_match = color_match.NextMatch();
            }

            Console.Write(msg.Substring(current_index));

            Console.BackgroundColor = initial_background_color;
            Console.ForegroundColor = initial_foreground_color;
        }
        else
        {
            Console.Write(msg);
        }
    }

    public static void WriteLine(string msg)
    {
        Write(msg);
        Console.WriteLine();
    }

    private static string GetColorNameFromMatch(Match match)
    {
        return match.Value.Substring(4, match.Value.IndexOf("}") - 4);
    }

    private static ConsoleColor GetParsedColorAndAddToHistory(string colorName, List<ConsoleColor> colorHistory, ConsoleColor defaultColor)
    {
        ConsoleColor new_color = Enum.TryParse<ConsoleColor>(colorName, true, out ConsoleColor parsed_color) ? parsed_color : defaultColor;
        colorHistory.Add(new_color);

        return new_color;
    }

    private static ConsoleColor GetLastColorAndRemoveFromHistory(List<ConsoleColor> colorHistory, ConsoleColor defaultColor)
    {
        if (colorHistory.Any())
        {
            colorHistory.RemoveAt(colorHistory.Count - 1);
        }

        return colorHistory.Any() ? colorHistory.Last() : defaultColor;
    }
}