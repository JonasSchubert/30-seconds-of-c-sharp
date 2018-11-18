using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class SnippetsString
    {
        /// <summary>
        /// Check if a string is ends with a given substring using a regex
        /// </summary>
        public static bool EndsWith(string input, Regex regex)
        {
            return regex.IsMatch(input);
        }

        /// <summary>
        /// Check if a string is ends with a given substring.
        /// </summary>
        /// Already integrated into C#
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netframework-4.7.2
        public static bool EndsWith(string input, string value)
        {
            return input.EndsWith(value);
        }

        /// <summary>
        /// Check if a string is ends with a given substring using string comparison.
        /// </summary>
        /// Already integrated into C#
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netframework-4.7.2
        public static bool EndsWith(string input, string value, StringComparison stringComparison)
        {
            return input.EndsWith(value, stringComparison);
        }

        /// <summary>
        /// Check if a string is ends with a given substring using culture info
        /// </summary>
        /// Already integrated into C#
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netframework-4.7.2
        public static bool EndsWith(string input, string value, bool ignoreCase, CultureInfo cultureInfo)
        {
            return input.EndsWith(value, ignoreCase, cultureInfo);
        }
    }
}
