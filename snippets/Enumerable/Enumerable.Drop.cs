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
        /// Returns a new array with n elements removed from the left.
        /// Equal to Skip
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skip?view=netframework-4.7.2
        /// </summary>
        public static IEnumerable<T> Drop<T>(this IEnumerable<T> enumerable, uint dropCount)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() < dropCount)
            {
                throw new ArgumentOutOfRangeException(nameof(enumerable));
            }

            return enumerable.Skip((int)dropCount);
        }
    }
}
