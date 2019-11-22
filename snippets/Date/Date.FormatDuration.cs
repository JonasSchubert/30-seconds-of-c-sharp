using System;
using System.Collections.Generic;
using System.Linq;

namespace JonasSchubert.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Returns the human readable format of the given number of milliseconds.
        /// </summary>
        public static string FormatDuration(ulong milliseconds)
        {
            var dictionary = new Dictionary<string, Tuple<ulong, uint>>
            {
                { "week", new Tuple<ulong, uint>(7* 24 * 60 * 60 * 1000, int.MaxValue) },
                { "day", new Tuple<ulong, uint>(24 * 60 * 60 * 1000, 7) },
                { "hour", new Tuple<ulong, uint>(60 * 60 * 1000, 24) },
                { "minute", new Tuple<ulong, uint>(60 * 1000, 60) },
                { "second", new Tuple<ulong, uint>(1000, 60) },
                { "millisecond", new Tuple<ulong, uint>(1, 1000) }
            };

            var stringArray = dictionary
                .Select(item =>
                    ((milliseconds / item.Value.Item1) % item.Value.Item2) > 0
                    ? $"{((milliseconds / item.Value.Item1) % item.Value.Item2)} {item.Key}{(((milliseconds / item.Value.Item1) % item.Value.Item2) > 1 ? "s" : string.Empty)}"
                    : string.Empty)
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();

            return stringArray.Length > 0
                ? string.Join(", ", stringArray)
                : "0 millisecond";
        }
    }
}
