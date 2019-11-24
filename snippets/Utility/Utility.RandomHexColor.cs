using System;

namespace JonasSchubert.Snippets.Utility
{
    /// <summary>
    /// Partial class for utility snippets
    /// </summary>
    public static partial class Utility
    {
        /// <summary>
        /// Generates a random hexadecimal color code.
        /// </summary>
        public static string RandomHexColor() =>
            $"#{(new Random().Next() * 0xFFFFFF * 1000000).ToString("X").PadLeft(6, '0').Substring(0, 6)}";
    }
}
