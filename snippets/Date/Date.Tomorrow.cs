using System;

namespace Conplement.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Returns tomorrow's date.
        /// You can provide a DateTimeKind value to select Local Or Utc
        /// Default is Utc
        /// </summary>
        public static DateTime Tomorrow(DateTimeKind dateTimeKind = DateTimeKind.Utc)
        {
            return (dateTimeKind == DateTimeKind.Local
                ? DateTime.Now
                : DateTime.UtcNow)
                + TimeSpan.FromDays(1);
            // Instead of TimeSpan you can also use https://github.com/conplementAG/FluentTimeSpan to add one day like tomorrow = DateTime.UtcNow + 1.Days()
        }
    }
}
