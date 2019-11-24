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
        /// Returns true if the provided predicate function returns false for all elements in a collection, false otherwise.
        /// </summary>
        public static bool None<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            try
            {
                return enumerable.First(predicate) == null;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
