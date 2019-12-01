using System.Linq;
using System.Text.RegularExpressions;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Converts a string to title case.
        /// </summary>
        public static string ToTitleCase(this string input) =>
            string.Join(" ", Regex.Matches(input, @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g")
                .Select(x => $"{x.Value.First().ToString().ToUpper()}{x.Value.Substring(1).ToLower()}"));
    }
}
