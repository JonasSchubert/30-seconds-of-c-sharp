using System;

namespace Conplement.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
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
    }
}
