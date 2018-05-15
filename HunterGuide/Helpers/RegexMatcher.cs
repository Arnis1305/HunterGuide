using System.Text.RegularExpressions;

namespace HunterGuide.Helpers 
{
    public static class RegexMatcher
    {
        public static bool IsMatch(string value, string pattern) 
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(value);
        }
    }
}
