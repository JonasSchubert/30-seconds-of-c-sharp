using System;

namespace conplement.snippets.Date
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
        /// Also have a look at: https://github.com/conplementAG/FluentTimeSpan
        public static double GetDaysDiffBetweenDates(DateTime dateTime1, DateTime dateTime2)
        {
            return (dateTime1 - dateTime2).TotalDays;
        }
    }
}
