using System;
using System.Collections.Generic;

namespace Conplement.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Groups the elements of an enumerable based on the given function and returns the count of elements in each group as dictionary, 
        /// objects as key and count of object as value (uint).
        /// Elements may not be null!
        /// </summary>
        public static IDictionary<T, uint> CountBy<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var dictionary = new Dictionary<T, uint>();

            foreach (var key in enumerable)
            {
                if (key == null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                if (dictionary.ContainsKey(key))
                {
                    dictionary[key]++;
                }
                else
                {
                    dictionary.Add(key, 1u);
                }
            }

            return dictionary;
        }
    }
}
