using System.Text.RegularExpressions;

namespace LikeSpecFlow
{
    public static class StringExtensions
    {
        private static readonly Regex _regex = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
        public static string SplitByCapitalLetters(this string s)
        {
            return _regex.Replace(s, " ");
        }
    }
}
