using System.Text.RegularExpressions;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Check if a string starts with a given substring using a regex
        /// </summary>
        public static bool StartsWithRegex(this string input, string substring) => new Regex($"^{substring}").IsMatch(input);
    }
}
