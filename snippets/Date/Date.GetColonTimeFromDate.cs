using System;

namespace JonasSchubert.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Returns a string of the form HH:MM:SS from a DateTime struct.
        /// </summary>
        /// Documentation for DateTime: https://docs.microsoft.com/de-de/dotnet/api/system.datetime
        public static string GetColonTimeFromDate(this DateTime dateTime)
        {
            return $"{dateTime.Hour.ToString("D2")}:{dateTime.Minute.ToString("D2")}:{dateTime.Second.ToString("D2")}";
        }

        /// <summary>
        /// Returns a string of the form HH:MM:SS from a TimeSpan struct.
        /// </summary>
        /// Documentation for DateTime: https://docs.microsoft.com/de-de/dotnet/api/system.timespan
        public static string GetColonTimeFromDate(this TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours.ToString("D2")}:{timeSpan.Minutes.ToString("D2")}:{timeSpan.Seconds.ToString("D2")}";
        }
    }
}
