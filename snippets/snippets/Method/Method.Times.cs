using System;
using System.Collections.Generic;

namespace snippets.Method
{
    /// <summary>
    /// Partial class for method snippets
    /// </summary>
    public static partial class SnippetsMethod
    {
        /// <summary>
        /// Iterates over a callback `n` times
        /// </summary>
        public static IList<T> Times<T>(Func<T> func, uint times)
        {
            var list = new List<T>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func());
            }

            return list;
        }

        /// <summary>
        /// Iterates over a callback value `n` times
        /// </summary>
        public static IList<T2> Times<T1, T2>(Func<T1, T2> func, uint times, T1 argument)
        {
            var list = new List<T2>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func(argument));
            }

            return list;
        }

        /// <summary>
        /// Iterates over a callback value `n` times
        /// </summary>
        public static IList<T3> Times<T1, T2, T3>(Func<T1, T2, T3> func, uint times, T1 argument1, T2 argument2)
        {
            var list = new List<T3>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func(argument1, argument2));
            }

            return list;
        }

        // ... and so on
    }
}
