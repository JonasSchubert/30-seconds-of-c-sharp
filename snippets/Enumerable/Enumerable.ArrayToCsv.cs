using System;
using System.Collections.Generic;
using System.Linq;

namespace JonasSchubert.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Checks if a type is of numeric type
        /// </summary>
        /// <param name="type">The type</param>
        /// <returns>True or False if type is numeric</returns>
        private static bool IsNumericType(this Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Converts a 2D array to a comma-separated values (CSV) string.
        /// </summary>
        public static string ArrayToCsv<T>(this IEnumerable<IEnumerable<T>> enumerable, string delimiter = ",")
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var isNumeric = typeof(T).IsNumericType();

            return string.Join("\n", enumerable.Select(subEnumerable => string.Join(delimiter, subEnumerable.Select(value => isNumeric ? value.ToString().Replace(",", ".") : value.ToString()))));
        }
    }
}
