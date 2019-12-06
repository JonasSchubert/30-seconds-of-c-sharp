using System.Text.RegularExpressions;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Converts a string from camelcase.
        /// Makes all words lowercase and combines them using a provided separator (default is one whitespace).
        /// Of the param isSentence == true, the first letter of the sentence will be uppercase and a dot will be added at the end (default is true).
        /// </summary>
        public static string FromCamelCase(this string input, string separator = " ", bool isSentence = true)
        {
            var value = string
                .Join(separator, Regex.Matches(input, @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g"))
                .ToLower();
            return isSentence ? $"{char.ToUpperInvariant(value[0])}{value.Substring(1)}." : value;
        }
    }
}
