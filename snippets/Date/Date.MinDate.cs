using System;
using System.Linq;

namespace Conplement.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Returns the minimum of the given dates.
        /// </summary>
        public static DateTime MinDate(params DateTime[] dateTimeList)
        {
            if (dateTimeList == null || !dateTimeList.Any())
            {
                throw new ArgumentException("The dateTimeList may not be empty!", nameof(dateTimeList));
            }

            if (!dateTimeList.All(x => dateTimeList.First().Kind == x.Kind))
            {
                throw new ArgumentException("All params have to have the same timezone!", nameof(dateTimeList));
            }

            return dateTimeList.Min();
        }
    }
}
