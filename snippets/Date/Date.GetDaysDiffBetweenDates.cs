using System;

namespace JonasSchubert.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Returns the difference (in days) between two dates.
        /// </summary>
        /// Documentation about datetime:  https://docs.microsoft.com/de-de/dotnet/api/system.datetime
        /// Also have a look at: https://github.com/TimeXt/FluentTimeSpan
        public static double GetDaysDiffBetweenDates(DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.Kind != dateTime2.Kind)
            {
                throw new ArgumentException($"The DateTime values have to be in the same timezone! {nameof(dateTime1)} uses {dateTime1.Kind}, while {nameof(dateTime2)} uses {dateTime2.Kind}!");
            }

            return (dateTime1 - dateTime2).TotalDays;
        }
    }
}
