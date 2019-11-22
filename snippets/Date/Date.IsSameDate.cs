using System;

namespace JonasSchubert.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Check if a date is the same as another date.
        /// </summary>
        public static bool IsSameDate(this DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 == dateTime2 && dateTime1.Kind == dateTime2.Kind;
        }
    }
}
