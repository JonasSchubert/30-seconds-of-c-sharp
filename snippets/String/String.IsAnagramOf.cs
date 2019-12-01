using System.Linq;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Checks if a string is an anagram of another string (case-insensitive).
        /// </summary>
        public static bool IsAnagramOf(this string input, string compare) => input.TransformToCompare() == compare.TransformToCompare();

        /// <summary>
        /// Transforms the string to make it comparable
        /// </summary>
        private static string TransformToCompare(this string input) => string.Join(string.Empty, input.ToLower().OrderBy(x => x));
    }
}
