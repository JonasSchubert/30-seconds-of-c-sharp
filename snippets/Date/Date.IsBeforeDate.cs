using System;

namespace JonasSchubert.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Check if a date is before another date.
        /// </summary>
        /// Documentation for DateTime: https://docs.microsoft.com/de-de/dotnet/api/system.datetime
        public static bool IsBeforeDate(this DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.Kind != dateTime2.Kind)
            {
                throw new ArgumentException($"The DateTime values have to be in the same timezone! {nameof(dateTime1)} uses {dateTime1.Kind}, while {nameof(dateTime2)} uses {dateTime2.Kind}!");
            }

            return dateTime1 < dateTime2;
        }
    }
}
