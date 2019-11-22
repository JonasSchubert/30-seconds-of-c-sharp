using System;
using System.Diagnostics;

namespace JonasSchubert.Snippets.Method
{
    /// <summary>
    /// Partial class for method snippets
    /// </summary>
    public static partial class Method
    {
        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz(
            Action action,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                action.Invoke();
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1>(
            Func<T1> func,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func();
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2>(
            Func<T1, T2> func,
            T1 arg1,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3>(
            Func<T1, T2, T3> func,
            T1 arg1, T2 arg2,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4>(
            Func<T1, T2, T3, T4> func,
            T1 arg1, T2 arg2, T3 arg3,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5>(
            Func<T1, T2, T3, T4, T5> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6>(
            Func<T1, T2, T3, T4, T5, T6> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7>(
            Func<T1, T2, T3, T4, T5, T6, T7> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }

        /// <summary>
        /// Returns the number of times a method executed per second. hz is the unit for hertz, the unit of frequency defined as one cycle per second.
        /// </summary>
        public static long Hz<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }
    }
}
