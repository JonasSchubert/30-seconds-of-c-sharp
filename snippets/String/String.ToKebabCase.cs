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
        /// Converts a string to kebab case.
        /// </summary>
        public static string ToKebabCase(this string input) =>
            string.Join("-", Regex.Matches(input, @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g").Select(x => x.Value.ToLower()));
    }
}
