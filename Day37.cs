using System;
using System.Text.RegularExpressions;

class Day37
{
    public static void Run()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine() ?? "";

        string censored = Censor(input);
        Console.WriteLine("Censored Output: " + censored);
    }

    static string Censor(string input)
    {
        string[] bannedWords = {"fuck", "dead", "patay", "nigga" };
        int starsCount = 4; // constant length ****

        // Build regex to match whole words
        string pattern = @"\b(?:" + string.Join("|", Array.ConvertAll(bannedWords, Regex.Escape)) + @")\b";

        return Regex.Replace(
            input,
            pattern,
            new string('*', starsCount),
            RegexOptions.IgnoreCase
        );
    }
}
