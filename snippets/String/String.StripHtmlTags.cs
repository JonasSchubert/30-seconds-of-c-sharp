using System.Text.RegularExpressions;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Removes HTML/XML tags from string.
        /// Use a regular expression to remove HTML/XML tags from a string.
        /// </summary>
        public static string StripHtmlTags(this string input) => Regex.Replace(input, "<[^>]*>", "");
    }
}
