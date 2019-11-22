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
        /// Removes falsey values from an array.
        /// Filter out falsey values("", false, 0 and null) depending on the type.
        /// </summary>
        public static IEnumerable<T> Compact<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (!enumerable.Any())
            {
                yield break; ;
            }

            foreach (var element in enumerable)
            {

                switch (element)
                {
                    case string y:
                        if (string.IsNullOrEmpty(y))
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case bool y:
                        if (!y)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case byte y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case sbyte y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case short y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case ushort y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case int y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case uint y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case long y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case ulong y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case float y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case double y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case decimal y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    default:
                        if (element == null)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                }
            }
        }
    }
}
