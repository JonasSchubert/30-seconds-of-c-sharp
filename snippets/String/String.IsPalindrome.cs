using System.Linq;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Returns true if the given string is a palindrome, false otherwise.
        /// </summary>
        public static bool IsPalindrome(this string input) => input.ToLower() == string.Join(string.Empty, input.ToCharArray().Reverse()).ToLower();
    }
}
