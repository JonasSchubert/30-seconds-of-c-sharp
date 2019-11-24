using System;
using System.Linq;

namespace JonasSchubert.Snippets.Utility
{
    /// <summary>
    /// Partial class for utility snippets
    /// </summary>
    public static partial class Utility
    {
        /// <summary>
        /// Converts a number in bytes to a human-readable string.
        /// </summary>
        public static string PrettyBytes(ulong bytes)
        {
            var units = new string[] { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

            var stringArray = units
                .Select((unit, index) =>
                    Math.Floor(bytes / Math.Pow(1e3, index) % 1e3) > 0
                    ? $"{Math.Floor(bytes / Math.Pow(1e3, index) % 1e3)} {unit}{(Math.Floor(bytes / Math.Pow(1e3, index) % 1e3) > 1 ? "s" : string.Empty)}"
                    : string.Empty)
                .Where(x => !string.IsNullOrEmpty(x))
                .Reverse()
                .ToArray();

            return stringArray.Length > 0
                ? string.Join(", ", stringArray)
                : "0 B";
        }
    }
}
