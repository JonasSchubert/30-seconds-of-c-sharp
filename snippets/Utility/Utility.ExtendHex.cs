using System.Linq;

namespace JonasSchubert.Snippets.Utility
{
    /// <summary>
    /// Partial class for utility snippets
    /// </summary>
    public static partial class Utility
    {
        /// <summary>
        /// Extends a 3-digit color code to a 6-digit color code.
        /// </summary>
        public static string ExtendHex(this string hex) =>
            $"{string.Join("", (hex.StartsWith('#') ? hex : $"#{hex}").Select(x => x == '#' ? $"{x}" : $"{x}{x}"))}";
    }
}
