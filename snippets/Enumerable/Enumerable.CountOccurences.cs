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
        /// Counts the occurrences of a value in an enumerable.
        /// Basically the same as implemented in System.Linq:
        /// public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        /// </summary>
        public static int CountOccurences<T>(this IEnumerable<T> enumerable, T value)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            return enumerable.Count(x => x.Equals(value));
        }
    }
}
