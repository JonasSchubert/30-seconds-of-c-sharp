using System;
using System.Diagnostics;

namespace JonasSchubert.Snippets.Utility
{
    /// <summary>
    /// Partial class for utility snippets
    /// </summary>
    /// Stopwatch documentation
    /// https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch
    public static partial class Utility
    {
        /// <summary>
        /// Measures the time taken by a function to execute.
        /// </summary>
        public static (long, T1) TimeTaken<T1>(Func<T1> func)
        {
            var watch = Stopwatch.StartNew();
            T1 result = func.Invoke();
            watch.Stop();
            return (watch.ElapsedMilliseconds, result);
        }

        /// <summary>
        /// Measures the time taken by a function to execute.
        /// </summary>
        public static (long, T2) TimeTaken<T1, T2>(Func<T1, T2> func, T1 arg)
        {
            var watch = Stopwatch.StartNew();
            T2 result = func.Invoke(arg);
            watch.Stop();
            return (watch.ElapsedMilliseconds, result);
        }

        /// <summary>
        /// Measures the time taken by a function to execute.
        /// </summary>
        public static (long, T3) TimeTaken<T1, T2, T3>(Func<T1, T2, T3> func, T1 arg1, T2 arg2)
        {
            var watch = Stopwatch.StartNew();
            T3 result = func.Invoke(arg1, arg2);
            watch.Stop();
            return (watch.ElapsedMilliseconds, result);
        }

        /// <summary>
        /// Measures the time taken by a function to execute.
        /// </summary>
        public static (long, T4) TimeTaken<T1, T2, T3, T4>(Func<T1, T2, T3, T4> func, T1 arg1, T2 arg2, T3 arg3)
        {
            var watch = Stopwatch.StartNew();
            T4 result = func.Invoke(arg1, arg2, arg3);
            watch.Stop();
            return (watch.ElapsedMilliseconds, result);
        }

        // ... and so on
    }
}
