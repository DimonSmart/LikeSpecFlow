using System.Text.RegularExpressions;

namespace LikeSpecFlow;

public static class StringExtensions
{
    private static readonly Regex Regex = new(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

    public static string SplitByCapitalLetters(this string s)
    {
        return Regex.Replace(s, " ");
    }
}