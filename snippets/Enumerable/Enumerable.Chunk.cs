using System;
using System.Collections.Generic;
using System.Linq;

namespace JonasSchubert.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Chunks an enumerable into smaller lists of a specified size.
        /// </summary>
        public static List<List<T>> Chunk<T>(this IEnumerable<T> enumerable, int size)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }

            var list = new List<List<T>>();

            var startIndex = 0;
            while (startIndex < enumerable.Count())
            {
                list.Add(enumerable.Skip(startIndex).Take(size).ToList());
                startIndex += size;
            }

            return list;
        }
    }
}
