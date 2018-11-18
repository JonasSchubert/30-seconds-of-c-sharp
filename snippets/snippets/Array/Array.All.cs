using System;
using System.Linq;

namespace snippets.Array
{
    /// <summary>
    /// Partial class for array snippets
    /// </summary>
    public static partial class SnippetsArray
    {
        /// <summary>
        /// Returns `true` if the provided function returns `true` for all elements of an array, `false` otherwise.
        /// </summary>
        /// Already integrated into C#
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=netframework-4.7.2
        public static bool All<T>(Func<T, bool> func, params T[] elements)
        {
            return elements.All(func);
        }
    }
}
