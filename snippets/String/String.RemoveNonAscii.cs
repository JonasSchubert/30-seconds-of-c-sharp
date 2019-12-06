using System.Text.RegularExpressions;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Removes non-printable ASCII characters.
        /// Use a regular expression to remove non-printable ASCII characters.
        /// </summary>
        public static string RemoveNonAscii(this string input) => Regex.Replace(input, "[^\x20-\x7E]", "");
    }
}
