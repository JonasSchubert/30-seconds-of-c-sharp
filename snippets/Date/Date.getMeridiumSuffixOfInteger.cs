using System;

namespace conplement.snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Converts an integer to a suffixed string, adding am or pm based on its value.
        /// </summary>
        public static string GetMeridiumSuffixOfInteger(this int value)
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentOutOfRangeException($"Invalid value {value} in method {nameof(GetMeridiumSuffixOfInteger)}", nameof(value));
            }

            return value == 0 || value == 24
                ? "12am" : value == 12
                    ? "12pm" : value < 12
                        ? $"{value % 12}am" : $"{value % 12}pm";
        }
    }
}
