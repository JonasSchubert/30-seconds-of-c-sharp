using System.Collections.Generic;
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
        /// Converts a given string into a list of words.
        /// </summary>
        public static List<string> Words(this string input, string pattern = @"\w+[^\s]*\w+|\w") =>
            Regex.Matches(input, pattern).Select(x => x.Value).ToList();
    }
}
