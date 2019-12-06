using System.Text.RegularExpressions;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Splits a multiline string into an array of lines.
        /// </summary>
        public static string[] SplitLines(this string input) => Regex.Split(input, "\r?\n");
    }
}
