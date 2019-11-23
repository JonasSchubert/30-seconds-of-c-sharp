using System.Collections.Generic;

namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Generates an list, containing the Fibonacci sequence, up until the nth term.
        /// </summary>
        public static List<int> Fibonaci(int length)
        {
            var list = new List<int>();

            for (var index = 0; index < length; index++)
            {
                list.Add(index <= 1 ? index : list[index - 1] + list[index - 2]);
            }

            return list;
        }
    }
}
