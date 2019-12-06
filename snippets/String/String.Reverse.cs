using System.Linq;

namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Reverses a string.
        /// </summary>
        public static string Reverse(this string input) => string.Join(string.Empty, input.ToCharArray().Reverse());
    }
}
