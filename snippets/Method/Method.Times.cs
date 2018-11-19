using System;
using System.Collections.Generic;

namespace conplement.snippets.Method
{
    /// <summary>
    /// Partial class for method snippets
    /// </summary>
    public static partial class Method
    {
        /// <summary>
        /// Iterates over a callback `n` times
        /// </summary>
        public static IList<T1> Times<T1>(Func<T1> func, uint times)
        {
            var list = new List<T1>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func());
            }

            return list;
        }

        /// <summary>
        /// Iterates over a callback value `n` times
        /// </summary>
        public static IList<T2> Times<T1, T2>(Func<T1, T2> func, uint times, T1 arg1)
        {
            var list = new List<T2>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func(arg1));
            }

            return list;
        }

        /// <summary>
        /// Iterates over a callback value `n` times
        /// </summary>
        public static IList<T3> Times<T1, T2, T3>(Func<T1, T2, T3> func, uint times, T1 arg1, T2 arg2)
        {
            var list = new List<T3>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func(arg1, arg2));
            }

            return list;
        }

        /// <summary>
        /// Iterates over a callback value `n` times
        /// </summary>
        public static IList<T4> Times<T1, T2, T3, T4>(Func<T1, T2, T3, T4> func, uint times, T1 arg1, T2 arg2, T3 arg3)
        {
            var list = new List<T4>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func(arg1, arg2, arg3));
            }

            return list;
        }

        // ... and so on
    }
}
