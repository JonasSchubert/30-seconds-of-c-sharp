using System;

namespace snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class SnippetsDate
    {
        /// <summary>
        /// Returns the day of the current year
        /// </summary>
        /// Already integrated into C#
        /// https://docs.microsoft.com/de-de/dotnet/api/system.datetime.dayofyear?view=netframework-4.7.2
        public static int DayOfYear()
        {
            return DateTime.Now.DayOfYear;
        }

        /// <summary>
        /// Returns the day of the year in the parameter
        /// </summary>
        /// Already integrated into C#
        /// https://docs.microsoft.com/de-de/dotnet/api/system.datetime.dayofyear?view=netframework-4.7.2
        public static int DayOfYear(DateTime dateTime)
        {
            return dateTime.DayOfYear;
        }
    }
}
