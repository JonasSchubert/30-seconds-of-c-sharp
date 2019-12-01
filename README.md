![Logo](/logo.png)

<p align="center">
  <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-blue.svg"/></a>
  <a href="http://makeapullrequest.com"><img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg"/></a>
  <a href="https://github.com/JonasSchubert/30-seconds-of-c-sharp/"><img src="https://img.shields.io/github/stars/JonasSchubert/30-seconds-of-c-sharp.svg"/></a>
  <a href="https://github.com/JonasSchubert/30-seconds-of-c-sharp/"><img src="https://img.shields.io/github/forks/JonasSchubert/30-seconds-of-c-sharp.svg"/></a>
  <a href="https://github.com/JonasSchubert/30-seconds-of-c-sharp/"><img src="https://img.shields.io/github/issues/JonasSchubert/30-seconds-of-c-sharp.svg"/></a>
  <a href="https://github.com/JonasSchubert/30-seconds-of-c-sharp/"><img src="https://img.shields.io/github/contributors/JonasSchubert/30-seconds-of-c-sharp.svg"/></a>
</p>

<p align="center"><h6 style="text-align: center;">Support me</h6></p>

<p align="center">
  <a href="https://www.paypal.me/GuepardoApps"><img src="https://img.shields.io/badge/paypal-support-blue.svg"/></a>
</p>

> A curated collection of useful C# snippets that you can understand in 30 seconds or less.

Note: This project is inspired by [30 Seconds of Code](https://github.com/Chalarangelo/30-seconds-of-code), but there is no affiliation with that project.

##### Official 30 Seconds of * projects

* [30 Seconds of Code](https://github.com/Chalarangelo/30-seconds-of-code/)
* [30 Seconds of CSS](https://30-seconds.github.io/30-seconds-of-css/)
* [30 Seconds of Interviews](https://30secondsofinterviews.org/)
* [30 Seconds of React](https://github.com/30-seconds/30-seconds-of-react)
* [30 Seconds of Python](https://github.com/30-seconds/30-seconds-of-python-code)
* [30 Seconds of PHP](https://github.com/30-seconds/30-seconds-of-php-code)
* [30 Seconds of Knowledge](https://chrome.google.com/webstore/detail/30-seconds-of-knowledge/mmgplondnjekobonklacmemikcnhklla)

##### Unofficial 30 Seconds of * projects

* [30 Seconds of Kotlin](https://github.com/IvanMwiruki/30-seconds-of-kotlin)

## Table of Contents

### ⏱️ Date

<details>
<summary>View contents</summary>

* [`dayOfYear`](#dayOfYear)
* [`formatDuration`](#formatDuration)
* [`getColonTimeFromDate`](#getColonTimeFromDate)
* [`getDaysDiffBetweenDates`](#getDaysDiffBetweenDates)
* [`getMeridiumSuffixOfInteger`](#getMeridiumSuffixOfInteger)
* [`isAfterDate`](#isAfterDate)
* [`isBeforeDate`](#isBeforeDate)
* [`isSameDate`](#isSameDate)
* [`maxDate`](#maxDate)
* [`minDate`](#minDate)
* [`tomorrow`](#tomorrow)

</details>

### 📚 Enumerable

<details>
<summary>View contents</summary>

* [`allEqual`](#allEqual)
* [`bifurcate`](#bifurcate)
* [`bubbleSort`](#bubbleSort)
* [`chunk`](#chunk)
* [`compact`](#compact)
* [`countBy`](#countBy)
* [`countOccurences`](#countOccurences)
* [`deepFlatten`](#deepflatten)
* [`difference`](#difference)
* [`differenceSelect`](#differenceSelect)
* [`differenceWhere`](#differenceWhere)
* [`drop`](#drop)
* [`dropRight`](#dropRight)
* [`dropRightWhile`](#dropRightWhile)
* [`dropWhile`](#dropWhile)
* [`everyNth`](#everyNth)
* [`filterNonUnique`](#filterNonUnique)
* [`filterNonUniqueBy`](#filterNonUniqueBy)
* [`findLast`](#findLast)
* [`findLastIndex`](#findLastIndex)
* [`flatten`](#flatten)
* [`forEachRight`](#forEachRight)
* [`hasDuplicates`](#hasDuplicates)
* [`indexOfAll`](#indexOfAll)
* [`initial`](#initial)
* [`initialize2DArray`](#initialize2DArray)
* [`initializeArrayWithRange`](#initializeArrayWithRange)
* [`initializeArrayWithRangeRight`](#initializeArrayWithRangeRight)
* [`initializeArrayWithValues`](#initializeArrayWithValues)
* [`initializeNDArray`](#initializeNDArray)
* [`intersection`](#intersection)
* [`intersectionSelect`](#intersectionSelect)
* [`intersectionWhere`](#intersectionWhere)
* [`jsonToCsv`](#jsonToCsv)
* [`longestItem`](#longestItem)
* [`maxN`](#maxN)
* [`minN`](#minN)
* [`none`](#none)
* [`nthElement`](#nthElement)
* [`offset`](#offset)
* [`orderBy`](#orderBy)
* [`partition`](#partition)
* [`permutations`](#permutations)
* [`pluck`](#pluck)
* [`pull`](#pull)
* [`pullAtIndex`](#pullAtIndex)
* [`pullAtValue`](#pullAtValue)
* [`pullBy`](#pullBy)
* [`reduceFilter`](#reduceFilter)
* [`reduceSuccessive`](#reduceSuccessive)
* [`reduceWhich`](#reduceWhich)
* [`reject`](#reject)
* [`remove`](#remove)
* [`sample`](#sample)
* [`sampleSize`](#sampleSize)
* [`shank`](#shank)
* [`shuffle`](#shuffle)
* [`similarity`](#similarity)
* [`sortedDirection`](#sortedDirection)
* [`sortedIndex`](#sortedIndex)
* [`sortedIndexBy`](#sortedIndexBy)
* [`sortedLastIndex`](#sortedLastIndex)
* [`sortedLastIndexBy`](#sortedLastIndexBy)
* [`stableSort`](#stableSort)
* [`symmetricDifference`](#symmetricDifference)
* [`symmetricDifferenceBy`](#symmetricDifferenceBy)
* [`symmetricDifferenceWith`](#symmetricDifferenceWith)
* [`tail`](#tail)
* [`take`](#take)
* [`takeRight`](#takeRight)
* [`takeRightWhile`](#takeRightWhile)
* [`takeWhile`](#takeWhile)
* [`toCsv`](#toCsv)
* [`toHash`](#toHash)
* [`union`](#union)
* [`unionBy`](#unionBy)
* [`unionWith`](#unionWith)
* [`uniqueElements`](#uniqueElements)
* [`uniqueElementsBy`](#uniqueElementsBy)
* [`uniqueElementsByRight`](#uniqueElementsByRight)
* [`uniqueSymmetricDifference`](#uniqueSymmetricDifference)
* [`without`](#without)
* [`xProd`](#xProd)

</details>

### ➗ Math

<details>
<summary>View contents</summary>

* [`approximatelyEqual`](#approximatelyEqual)
* [`average`](#average)
* [`averageBy`](#averageBy)
* [`binomialCoefficient`](#binomialCoefficient)
* [`degToRads`](#degToRads)
* [`digitize`](#digitize)
* [`distance`](#distance)
* [`factorial`](#factorial)
* [`fibonacci`](#fibonacci)
* [`gcd`](#gcd)
* [`geometricProgression`](#geometricProgression)
* [`inRange`](#inRange)
* [`isDivisibleBy`](#isDivisibleBy)
* [`isEven`](#isEven)
* [`isPrime`](#isPrime)
* [`isOdd`](#isOdd)
* [`lcm`](#lcm)
* [`luhnCheck`](#luhnCheck)
* [`max`](#max)
* [`median`](#median)
* [`min`](#min)
* [`primes`](#primes)
* [`radToDeg`](#radToDeg)
* [`randomIntArrayInRange`](#randomIntArrayInRange)
* [`randomIntegerInRange`](#randomIntegerInRange)
* [`randomNumberInRange`](#randomNumberInRange)
* [`round`](#round)
* [`sdbm`](#sdbm)
* [`standardDeviation`](#standardDeviation)
* [`sum`](#sum)
* [`sumBy`](#sumBy)

</details>

### 🎛️ Method

<details>
<summary>View contents</summary>

* [`hz`](#hz)
* [`times`](#times)

</details>

### 📜 String

<details>
<summary>View contents</summary>

* [`byteSize`](#byteSize)
* [`capitalize`](#capitalize)
* [`capitalizeEveryWord`](#capitalizeEveryWord)
* [`countVowels`](#countVowels)
* [`csvToArray`](#csvToArray)
* [`csvToJson`](#csvToJson)
* [`decapitalize`](#decapitalize)
* [`endsWithRegex`](#endsWithRegex)
* [`escapeHtml`](#escapeHtml)
* [`escapeRegExp`](#escapeRegExp)
* [`fromCamelCase`](#fromCamelCase)
* [`indentString`](#indentString)
* [`isAbsoluteUrl`](#isAbsoluteUrl)
* [`isAnagram`](#isAnagram)
* [`isLowerCase`](#isLowerCase)
* [`isUpperCase`](#isUpperCase)
* [`mask`](#mask)
* [`pad`](#pad)
* [`palindrome`](#palindrome)
* [`pluralize`](#pluralize)
* [`removeNonAscii`](#removeNonAscii)
* [`reverseString`](#reverseString)
* [`sortCharactersInString`](#sortCharactersInString)
* [`splitLines`](#splitLines)
* [`startsWithRegex`](#startsWithRegex)
* [`stringPermutations`](#stringPermutations)
* [`stripHtmlTags`](#stripHtmlTags)
* [`toCamelCase`](#toCamelCase)
* [`toKebabCase`](#toKebabCase)
* [`toSnakeCase`](#toSnakeCase)
* [`toTitleCase`](#toTitleCase)
* [`truncate`](#truncate)
* [`urlJoin`](#urlJoin)
* [`words`](#words)

</details>

### 📃️ Type

<details>
<summary>View contents</summary>

* [`isNumericType`](#isNumericType)

</details>

### 🔧 Utility

<details>
<summary>View contents</summary>

* [`extendHex`](#extendHex)
* [`hexToRgb`](#hexToRgb)
* [`prettyBytes`](#prettyBytes)
* [`randomHexColor`](#randomHexColor)
* [`rgbToHex`](#rgbToHex)
* [`timeTaken`](#timeTaken)
* [`yesNo`](#yesNo)

</details>

---
 ## ⏱️ Date

### dayOfYear

Returns the day of the current year.

Already integrated [here](https://docs.microsoft.com/en-us/dotnet/api/system.datetime.dayofyear).

``` c#
using System;

namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static int DayOfYear()
        {
            return DateTime.UtcNow.DayOfYear;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
JonasSchubert.Snippets.Date.DayOfYear() # 12/31/2016: day 366 of 2016 (Leap Year)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### formatDuration

Returns the human readable format of the given number of milliseconds.

```c#
namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static string FormatDuration(ulong milliseconds)
        {
            var dictionary = new Dictionary<string, Tuple<ulong, uint>>
            {
                { "week", new Tuple<ulong, uint>(7* 24 * 60 * 60 * 1000, int.MaxValue) },
                { "day", new Tuple<ulong, uint>(24 * 60 * 60 * 1000, 7) },
                { "hour", new Tuple<ulong, uint>(60 * 60 * 1000, 24) },
                { "minute", new Tuple<ulong, uint>(60 * 1000, 60) },
                { "second", new Tuple<ulong, uint>(1000, 60) },
                { "millisecond", new Tuple<ulong, uint>(1, 1000) }
            };

            var stringArray = dictionary
                .Select(item =>
                    ((milliseconds / item.Value.Item1) % item.Value.Item2) > 0
                    ? $"{((milliseconds / item.Value.Item1) % item.Value.Item2)} {item.Key}{(((milliseconds / item.Value.Item1) % item.Value.Item2) > 1 ? "s" : string.Empty)}"
                    : string.Empty)
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();

            return stringArray.Length > 0
                ? string.Join(", ", stringArray)
                : "0 millisecond";
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var actual = Date.FormatDuration(34325055574ul); # "56 weeks, 5 days, 6 hours, 44 minutes, 15 seconds, 574 milliseconds"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### getColonTimeFromDate

Returns a string of the form `HH:MM:SS` from a `DateTime` or `TimeSpan` object.

```c#
namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static string GetColonTimeFromDate(this DateTime dateTime)
        {
            return $"{dateTime.Hour.ToString("D2")}:{dateTime.Minute.ToString("D2")}:{dateTime.Second.ToString("D2")}";
        }

        public static string GetColonTimeFromDate(this TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours.ToString("D2")}:{timeSpan.Minutes.ToString("D2")}:{timeSpan.Seconds.ToString("D2")}";
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new DateTime(2018, 11, 22, 17, 53, 23).GetColonTimeFromDate() # 17:53:23
new DateTime(1990, 1, 2, 3, 41, 5).GetColonTimeFromDate() # 03:41:05
new TimeSpan(1, 33, 7).GetColonTimeFromDate() # 01:33:07
```

</details>

<br>[↑ Back to top](#table-of-contents)

### getDaysDiffBetweenDates

Returns the difference (in days) between two dates.

``` c#
using System;

namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
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
```

<details>
<summary>Examples</summary>

``` c#
Date.GetDaysDiffBetweenDates(new DateTime(2018, 11, 22), new DateTime(2018, 11, 14)); # 8.0
```

</details>

<br>[↑ Back to top](#table-of-contents)

### getMeridiumSuffixOfInteger

Converts an integer to a suffixed string, adding `am` or `pm` based on its value.

``` c#
using System;

namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static string GetMeridiemSuffixOfInteger(this int value)
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentOutOfRangeException($"Invalid value {value} in method {nameof(GetMeridiemSuffixOfInteger)}", nameof(value));
            }

            return value == 0 || value == 24
                ? "12am" : value == 12
                    ? "12pm" : value < 12
                        ? $"{value % 12}am" : $"{value % 12}pm";
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
0.GetMeridiemSuffixOfInteger(); # 12am
11.GetMeridiemSuffixOfInteger(); # 11am
13.GetMeridiemSuffixOfInteger(); # 1pm
18.GetMeridiemSuffixOfInteger(); # 6pm
24.GetMeridiemSuffixOfInteger(); # 12am
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isAfterDate

Check if a date is after another date.

``` c#
using System;

namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static bool IsAfterDate(this DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.Kind != dateTime2.Kind)
            {
                throw new ArgumentException($"The DateTime values have to be in the same timezone! {nameof(dateTime1)} uses {dateTime1.Kind}, while {nameof(dateTime2)} uses {dateTime2.Kind}!");
            }

            return dateTime1 > dateTime2;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
DateTime(2018, 11, 21).IsAfterDate(new DateTime(2018, 11, 22)) # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isBeforeDate

Check if a date is before another date.

``` c#
using System;

namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static bool IsBeforeDate(this DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.Kind != dateTime2.Kind)
            {
                throw new ArgumentException($"The DateTime values have to be in the same timezone! {nameof(dateTime1)} uses {dateTime1.Kind}, while {nameof(dateTime2)} uses {dateTime2.Kind}!");
            }

            return dateTime1 < dateTime2;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
DateTime(2018, 11, 21).IsBeforeDate(new DateTime(2018, 11, 22)) # true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isSameDate

Check if a date is the same as another date.

```c#
namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static bool IsSameDate(this DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 == dateTime2 && dateTime1.Kind == dateTime2.Kind;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var actual = new DateTime(2018, 11, 26).IsSameDate(new DateTime(2018, 11, 26)); # true
var actual = new DateTime(203940201L).IsSameDate(new DateTime(203940202L)); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### maxDate

Returns the maximum of the given dates.

```c#
namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static DateTime MaxDate(params DateTime[] dateTimeList)
        {
            if (dateTimeList == null || !dateTimeList.Any())
            {
                throw new ArgumentException("The dateTimeList may not be empty!", nameof(dateTimeList));
            }

            if (!dateTimeList.All(x => dateTimeList.First().Kind == x.Kind))
            {
                throw new ArgumentException("All params have to have the same timezone!", nameof(dateTimeList));
            }

            return dateTimeList.Max();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
DateTime[] list = { new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27), new DateTime(2019) };
var actual = Date.MaxDate(list); # new DateTime(2019)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### minDate

Returns the minimum of the given dates.

```c#
namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
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
```

<details>
<summary>Examples</summary>

```c#
DateTime[] list = { new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27), new DateTime(2018) };
var actual = Date.MinDate(list); # new DateTime(2018)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### tomorrow

Returns tomorrow's date.

```c#
namespace JonasSchubert.Snippets.Date
{
    public static partial class Date
    {
        public static DateTime Tomorrow(DateTimeKind dateTimeKind = DateTimeKind.Utc)
        {
            return (dateTimeKind == DateTimeKind.Local
                ? DateTime.Now
                : DateTime.UtcNow)
                + TimeSpan.FromDays(1);
            // Instead of TimeSpan you can also use https://github.com/TimeXt/FluentTimeSpan to add one day like tomorrow = DateTime.UtcNow + 1.Days()
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var actual = Date.Tomorrow(DateTimeKind.Local); # If today is 15.05.2019, it will return 16.05.2019
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 📚 Enumerable

### allEqual

Check if all elements in an array are equal.

``` c#
using System;

namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static bool AllEqual<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var testList = enumerable.ToList();
            if (testList.Count <= 1)
            {
                return true;
            }

            var compareObject = testList[0];
            for (int index = 0; index < testList.Count; index++)
            {
                var entry = testList[index];
                if ((entry == null || !entry.Equals(compareObject))
                    && !(entry == null && compareObject == null))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
new double[] { 1.25, 1.25, 1.5, -1.5 }.AllEqual(); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### bifurcate

Splits values into two groups. If an element in `filter` is truthy, the corresponding element in the collection belongs to the first group; otherwise, it belongs to the second group.

``` c#
using System;

namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static (IEnumerable<T>, IEnumerable<T>) Bifurcate<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            IEnumerable<T> enumerable1 = list.Where(filter);
            IEnumerable<T> enumerable2 = list.Where(x => !enumerable1.Any(y => y.Equals(x)));

            return (enumerable1, enumerable2);
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
var list = new List<int>
{
    1, 2, 3, 4, 1
};
(IEnumerable<int> actual1, IEnumerable<int> actual2) = list.Bifurcate(x => x > 1); # actual1 has three entries (2, 3, 4), actual2 has two entries (1, 1)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### bubbleSort

bubbleSort uses the technique of comparing and swapping

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### chunk

Chunks an enumerable into smaller lists of a specified size.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static List<List<T>> Chunk<T>(this IEnumerable<T> enumerable, int size)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }

            var list = new List<List<T>>();

            var startIndex = 0;
            while (startIndex < enumerable.Count())
            {
                list.Add(enumerable.Skip(startIndex).Take(size).ToList());
                startIndex += size;
            }

            return list;
        }
    }
}

```

<details>
<summary>Examples</summary>

```c#
new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" }.Chunk(6); # will result in two new string arrays => new string[]][] { new string[] { "1", "2", "3", "4", "5", "6" }, new string[] { "7", "8", "9", "10", "11" }}
new int[] { 0, 1, 2 }.Chunk(6); # will result in one integer array => new int[][] { new int[] { 0, 1, 2 } }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### compact

Removes invalid values from an array.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> Compact<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (!enumerable.Any())
            {
                yield break;
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
						
			// ... more definitions necessary, Please have a look into the code
						
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
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new List<object> { new object(), null, new object(), new object(), null, false, true, 1, 0, "Hello", "", "World" }.Compact(); # List with seven entries: new List<object> { new object(), new object(), new object(), true, 1, "Hello", "World" };
```

</details>

<br>[↑ Back to top](#table-of-contents)

### countBy

Groups the elements of an enumerable based on the given function and returns the count of elements in each group as dictionary, objects as key and count of object as value (uint). Elements may not be null!

``` c#
using System;

namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IDictionary<T, uint> CountBy<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var dictionary = new Dictionary<T, uint>();

            foreach (var key in enumerable)
            {
                if (key == null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                if (dictionary.ContainsKey(key))
                {
                    dictionary[key]++;
                }
                else
                {
                    dictionary.Add(key, 1u);
                }
            }

            return dictionary;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
new List<int> { 1, 2, 3, 2, 1 }.CountBy(); # new Dictionary<int, uint> { { 1, 2u }, { 2, 2u }, { 3, 1u } };
```

</details>

<br>[↑ Back to top](#table-of-contents)

### countOccurrences

Counts the occurrences of a value in an enumerable.

``` c#
using System;

namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static int CountOccurences<T>(this IEnumerable<T> enumerable, T value)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            return enumerable.Count(x => x.Equals(value));
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
new string[] { "Hello", "Hello", "Hello", "World", "Hello", "", string.Empty }.CountOccurences("Hello"); # 4
```

</details>

<br>[↑ Back to top](#table-of-contents)

### deepFlatten

Deep flattens an array of arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### difference

Returns the difference between two enumerables.

``` c#
using System;

namespace JonasSchubert.Snippets.Enumerable
{
    public static IEnumerable<T> Difference<T>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2)
    {
        if (enumerable1 == null)
        {
            throw new ArgumentNullException(nameof(enumerable1));
        }

        if (enumerable2 == null)
        {
            throw new ArgumentNullException(nameof(enumerable2));
        }

        return enumerable1.Where(x => !enumerable2.Any(y => x.Equals(y))).Concat(enumerable2.Where(x => !enumerable1.Any(y => x.Equals(y))));
    }
}
```

<details>
<summary>Examples</summary>

``` c#
new List<int>{ 1, 2, 3, 4, 0}.Difference(new List<int>{ 1, 5, 3, 4, 1 }); # new List<int>{ 2, 0, 5}
```

</details>

<br>[↑ Back to top](#table-of-contents)

### differenceSelect

Returns the difference between two enumerables, after applying the provided function to each enumerable element of both.

``` c#
using System;

namespace JonasSchubert.Snippets.Enumerable
{
    public static IEnumerable<K> DifferenceSelect<T, K>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2, Func<T, K> selectFunction)
    {
        if (enumerable1 == null)
        {
            throw new ArgumentNullException(nameof(enumerable1));
        }

        if (enumerable2 == null)
        {
            throw new ArgumentNullException(nameof(enumerable2));
        }

        if (selectFunction == null)
        {
            throw new ArgumentNullException(nameof(selectFunction));
        }

        var selectedEnumerable1 = enumerable1.Select(selectFunction);
        var selectedEnumerable2 = enumerable2.Select(selectFunction);

        return selectedEnumerable1.Where(x => !selectedEnumerable2.Any(y => x.Equals(y))).Concat(selectedEnumerable2.Where(x => !selectedEnumerable1.Any(y => x.Equals(y))));
    }
}
```

<details>
<summary>Examples</summary>

``` c#
new List<int>{ 1, 2, 3, 4, 0}.DifferenceSelect(new List<int>{ 1, 5, 3, 4, 1 }, x => x); # new List<int>{ 2, 0, 5}
```

</details>

<br>[↑ Back to top](#table-of-contents)

### differenceWhere

Filters out all values from an array for which the comparator function does not return `true`.

``` c#
using System;

namespace JonasSchubert.Snippets.Enumerable
{
    public static IEnumerable<T> DifferenceWhere<T>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2, Func<T, bool> whereFunction)
    {
        if (enumerable1 == null)
        {
            throw new ArgumentNullException(nameof(enumerable1));
        }

        if (enumerable2 == null)
        {
            throw new ArgumentNullException(nameof(enumerable2));
        }

        if (whereFunction == null)
        {
            throw new ArgumentNullException(nameof(whereFunction));
        }

        var selectedEnumerable1 = enumerable1.Where(whereFunction);
        var selectedEnumerable2 = enumerable2.Where(whereFunction);

        return selectedEnumerable1.Where(x => !selectedEnumerable2.Any(y => x.Equals(y))).Concat(selectedEnumerable2.Where(x => !selectedEnumerable1.Any(y => x.Equals(y))));
    }
}
```

<details>
<summary>Examples</summary>

``` c#
new List<int>{ 1, 2, 3, 4, 0}.DifferenceWhere(new List<int>{ 1, 5, 3, 4, 1 }, x => x > 1); # new List<int>{ 2, 5}
```

</details>

<br>[↑ Back to top](#table-of-contents)

### drop

Returns a new array with `n` elements removed from the left.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> Drop<T>(this IEnumerable<T> enumerable, uint dropCount)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() < dropCount)
            {
                throw new ArgumentOutOfRangeException(nameof(enumerable));
            }

            return enumerable.Skip((int)dropCount);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new bool[] { false, false, true, true }.Drop(3); # List with one entry: true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### dropRight

Returns a new array with `n` elements removed from the right.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> Drop<T>(this IEnumerable<T> enumerable, uint dropCount)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() < dropCount)
            {
                throw new ArgumentOutOfRangeException(nameof(enumerable));
            }

            return enumerable.Take(enumerable.Count() - (int)dropCount);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new bool[] { false, false, true, true }.DropRight(3); # List with one entry: false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### dropRightWhile

Removes elements from the end of an array until the passed function returns `true`. Returns the remaining elements in the array.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> DropRightWhile<T>(this IEnumerable<T> enumerable, Func<T, bool> filter)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var reachedDropPoint = false;

            for (var index = enumerable.Count() - 1; index >= 0; index--)
            {
                var element = enumerable.ElementAt(index);

                if (!reachedDropPoint && !filter(element))
                {
                    continue;
                }

                reachedDropPoint = true;

                yield return element;
            }

            yield break;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new int[] { 1, 2, 3, 4, 1 }.DropRightWhile(x => x > 2); # List with four entries: new List<int> { 1, 2, 3, 4 }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### dropWhile

Removes elements in an array until the passed function returns `true`. Returns the remaining elements in the array.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> DropWhile<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var reachedDropPoint = false;

            foreach (var element in list)
            {
                if (!reachedDropPoint && !filter(element))
                {
                    continue;
                }

                reachedDropPoint = true;

                yield return element;
            }

            yield break;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new List<int>{ 1, 2, 3, 4, 1}.DropWhile(x => x => x > 2); # new List<int> { 3, 4, 1 }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### everyNth

Returns every nth element in an enumerable.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> EveryNth<T>(this IEnumerable<T> enumerable, uint nth)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (nth == 0u)
            {
                throw new ArgumentNullException(nameof(nth));
            }

            for (var index = nth - 1; index < enumerable.Count(); index += nth)
            {
                yield return enumerable.ElementAt((int)index);
            }
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new List<int>{ 1, 2, 3, 4, 1}.EveryNth(3u); # new List<int> { 3 }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### filterNonUnique

Filters out the non-unique not null values in an enumerable.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> FilterNonUnique<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            for (var index = 0; index < enumerable.Count(); index++)
            {
                if (enumerable.Where(x => x != null && x.Equals(enumerable.ElementAt(index))).Count() == 1)
                {
                    yield return enumerable.ElementAt(index);
                }
            }
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new string[] { "Hello", "world", "organisation", "seconds", "of", "organisation" }.FilterNonUnique(); # new string[] { "Hello", "world", "seconds", "of" }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### filterNonUniqueBy

Filters out the non-unique not null values in an enumerable, based on a provided comparator function (where linq statement).

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> FilterNonUniqueWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            for (var index = 0; index < enumerable.Count(); index++)
            {
                if (enumerable.Where(whereFunction).Where(x => x != null && x.Equals(enumerable.ElementAt(index))).Count() == 1)
                {
                    yield return enumerable.ElementAt(index);
                }
            }
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new string[] { "Hello", "world", "organisation", "seconds", "of", "organisation" }.FilterNonUniqueWhere(x => x != "world"); # new string[] { "Hello", "seconds", "of" }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### findLast

Returns the last element for which the provided function returns a truthy value.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static T FindLast<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            return enumerable.Where(whereFunction).Reverse().FirstOrDefault();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new List<int> { 1, 2, 3, 4, 0 }.FindLast(x => x % 4 == 0 && x != 0); # 4
```

</details>

<br>[↑ Back to top](#table-of-contents)

### findLastIndex

Returns the index of the last element for which the provided function returns a truthy value.
Returns -1 if nothing found at all.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static int FindLastIndex<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            var foundElement = enumerable.Where(whereFunction).Reverse().FirstOrDefault();
            if (foundElement == null)
            {
                return -1;
            }

            for (var index = enumerable.Count() - 1; index > -1; index--)
            {
                if (enumerable.ElementAt(index).Equals(foundElement))
                {
                    return index;
                }
            }

            throw new InvalidOperationException(nameof(FindLastIndex));
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new List<int> { 1, 2, 3, 4, 0 }.FindLastIndex(x => x % 4 == 0 && x != 0); # 3
```

</details>

<br>[↑ Back to top](#table-of-contents)

### flatten

Flattens an array up to the specified depth.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### forEachRight

Executes a provided function once for each enumerable element, starting from the enumerable's last element.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static void ForEachRight<T>(this IEnumerable<T> enumerable, Action<T> function)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (function == null)
            {
                throw new ArgumentNullException(nameof(function));
            }

            foreach (var element in enumerable.Reverse())
            {
                function(element);
            }
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var testString = "";
new string[] { "world", "Hello" }.ForEachRight((string x) => testString = testString + " " + x); # " Hello world"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### hasDuplicates

Checks an enumerable for duplicate values. Returns true if duplicate values exist and false if values are all unique.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static bool HasDuplicates<T>(this IEnumerable<T> enumerable) =>
            enumerable == null
                ? throw new ArgumentNullException(nameof(enumerable))
                : enumerable.Count() != enumerable.Distinct().Count();
    }
}
```

<details>
<summary>Examples</summary>

```c#
new List<uint> { 1u, 2u, 3u, 4u, 0u, 1u }.HasDuplicates(); # true
new string[] { "Hello", "world", "organisation", "seconds", "of" }.HasDuplicates(); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### indexOfAll

Returns all indices of a value in an enumerable. If the value never occurs, returns empty.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<int> IndexOfAll<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            var foundElements = enumerable.Where(whereFunction);
            if (foundElements.Any())
            {
                for (var index = 0; index < enumerable.Count(); index++)
                {
                    if (foundElements.Any(x => x.Equals(enumerable.ElementAt(index))))
                    {
                        yield return index;
                    }
                }
            }
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new List<bool?> { false, false, false, false, false, false, false, false, false }.IndexOfAll(x => x == true); # empty enumerable
new string[] { "Hello", "world", "organisation", "seconds", "or" }.IndexOfAll(x => x.Contains("or")); # new List<int> { 1, 2, 4 };
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initial

Returns all the elements of an array except the last one.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initialize2DArray

Initializes a 2D array of given width and height and value.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static T[,] Initialize2DArray<T>(uint width, uint height, T defaultValue = default(T))
        {
            if (width == 0)
            {
                throw new ArgumentException($"Minimum {nameof(width)} has to be 1", nameof(width));
            }

            if (height == 0)
            {
                throw new ArgumentException($"Minimum {nameof(height)} has to be 1", nameof(height));
            }

            var newArray = new T[width, height];

            for (int widthIndex = 0; widthIndex < width; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < height; heightIndex++)
                {
                    newArray[widthIndex, heightIndex] = defaultValue;
                }
            }

            return newArray;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Enumerable.Initialize2DArray(2, 2, 0) # new int[2, 2] { { 0, 0 }, { 0, 0 } }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeArrayWithRange

Initializes an array containing the numbers in the specified range where `start` and `end` are inclusive with their common difference `step`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeArrayWithRangeRight

Initializes an array containing the numbers in the specified range (in reverse) where `start` and `end` are inclusive with their common difference `step`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeArrayWithValues

Initializes and fills an array with the specified values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeNDArray

Create a n-dimensional array with given value.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### intersection

Returns an enumerable of elements that exist in both enumerables.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> Intersection<T>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2)
        {
            if (enumerable1 == null)
            {
                throw new ArgumentNullException(nameof(enumerable1));
            }

            if (enumerable2 == null)
            {
                throw new ArgumentNullException(nameof(enumerable2));
            }

            return enumerable1.Where(x => enumerable2.Any(y => x.Equals(y))).Concat(enumerable2.Where(x => enumerable1.Any(y => x.Equals(y)))).Distinct();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new string[] { "Hello", "world", "organisation", "seconds", "of", "Hello" }.Intersection(new string[] { "of", "organisation", "GuepardoApps", "Hello", "of" }); # new string[] { "Hello", "organisation", "of" }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### intersectionSelect

Returns an enumerable of elements that exist in both enumerables, after applying the provided function to each enumerable element of both.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<K> IntersectionSelect<T, K>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2, Func<T, K> selectFunction)
        {
            if (enumerable1 == null)
            {
                throw new ArgumentNullException(nameof(enumerable1));
            }

            if (enumerable2 == null)
            {
                throw new ArgumentNullException(nameof(enumerable2));
            }

            if (selectFunction == null)
            {
                throw new ArgumentNullException(nameof(selectFunction));
            }

            var selectedEnumerable1 = enumerable1.Select(selectFunction);
            var selectedEnumerable2 = enumerable2.Select(selectFunction);

            return selectedEnumerable1.Where(x => selectedEnumerable2.Any(y => x.Equals(y))).Concat(selectedEnumerable2.Where(x => selectedEnumerable1.Any(y => x.Equals(y)))).Distinct();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new string[] { "Hello", "world", "organisation", "seconds", "of", "of" }.IntersectionSelect(new string[] { "of", "organisation", "GuepardoApps", "Hello", "of" }, x => x); # new string[] { "Hello", "organisation", "of" }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### intersectionWhere

Returns an enumerable of elements that exist in both enumerables, using a provided comparator function.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> IntersectionWhere<T>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2, Func<T, bool> whereFunction)
        {
            if (enumerable1 == null)
            {
                throw new ArgumentNullException(nameof(enumerable1));
            }

            if (enumerable2 == null)
            {
                throw new ArgumentNullException(nameof(enumerable2));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            var selectedEnumerable1 = enumerable1.Where(whereFunction);
            var selectedEnumerable2 = enumerable2.Where(whereFunction);

            return selectedEnumerable1.Where(x => selectedEnumerable2.Any(y => x.Equals(y))).Concat(selectedEnumerable2.Where(x => selectedEnumerable1.Any(y => x.Equals(y)))).Distinct();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new string[] { "Hello", "world", "organisation", "seconds", "of" }.IntersectionWhere(new string[] { "of", "organisation", "GuepardoApps", "Hello", "of" }, x => x.Contains("or")); # new string[] { "organisation" }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### jsonToCsv
![advanced](/advanced.svg)

Converts an array of objects to a comma-separated values (CSV) string that contains only the `columns` specified.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### longestItem

Takes any number of iterable objects or objects with a `length` property and returns the longest one.
If multiple objects have the same length, the first one will be returned.
Returns `-1` if no arguments are provided.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### maxN

Returns the `n` maximum elements from the provided array.
If `n` is greater than or equal to the provided array's length, then return the original array (sorted in descending order).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### minN

Returns the `n` minimum elements from the provided array.
If `n` is greater than or equal to the provided array's length, then return the original array (sorted in ascending order).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### none

Returns `true` if the provided predicate function returns `false` for all elements in a collection, `false` otherwise.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static bool None<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            try
            {
                return enumerable.First(predicate) == null;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}

```

<details>
<summary>Examples</summary>

```c#
new List<int> { 3, 2, 0 }.None(x => x == 1); # true
new string[] { "Hello", "World" }.None(x => x.Length == 6) # true
new bool[] { true, false }.None(x => !x); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### nthElement

Returns the nth element of an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### offset

Moves the specified amount of elements to the end of the array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### orderBy

Sorts a collection of arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### partition

Groups the elements into two arrays, depending on the provided function's truthiness for each element.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### permutations
![advanced](/advanced.svg)

⚠️ **WARNING**: This function's execution time increases exponentially with each array element.

Generates all permutations of an array's elements (contains duplicates).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pluck

Retrieves all of the values for a given key.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pull

Mutates the original array to filter out the values specified.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pullAtIndex
![advanced](/advanced.svg)

Mutates the original array to filter out the values at the specified indexes.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pullAtValue
![advanced](/advanced.svg)

Mutates the original array to filter out the values specified. Returns the removed elements.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pullBy
![advanced](/advanced.svg)

Mutates the original array to filter out the values specified, based on a given iterator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reduceFilter

Filter an array of objects based on a condition while also filtering out unspecified keys.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reduceSuccessive

Applies a function against an accumulator and each element in the array (from left to right), returning an array of successively reduced values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reduceWhich

Returns the minimum/maximum value of an array, after applying the provided function to set comparing rule.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reject

Takes a predicate and array, like `Array.prototype.filter()`, but only keeps `x` if `pred(x) === false`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### remove

Removes elements from an array for which the given function returns `false`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sample

Returns a random element from an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sampleSize

Gets `n` random elements at unique keys from `array` up to the size of `array`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### shank

This method changes the contents of an array by removing existing elements and/or adding new elements.
Similar to the JavaScript version [`Array.prototype.splice()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/splice)

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### shuffle

Randomizes the order of the values of an array, returning a new array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### similarity

Returns an array of elements that appear in both arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedDirection

Returns `Direction.Ascending` if the enumerable is sorted in ascending order, `Direction.Descending` if it is sorted in descending order or `Direction.NotSorted` if it is not sorted or has only one value.

```c#
namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static Direction SortedDirection<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() <= 1)
            {
                return Direction.NotSorted;
            }

            var direction = enumerable.GetDirection(0, 1);
            if (enumerable.Count() > 2)
            {
                for (var index = 2; index < enumerable.Count(); index++)
                {
                    var currentDirection = enumerable.GetDirection(index - 1, index);
                    direction = direction == Direction.NotSorted ? currentDirection : direction;

                    if (direction != currentDirection)
                    {
                        return Direction.NotSorted;
                    }
                }
            }

            return direction;
        }

        private static Direction GetDirection<T>(this IEnumerable<T> enumerable, int indexStart, int indexEnd)
        {
            var compareResult = Comparer<T>.Default.Compare(enumerable.ElementAt(indexStart), enumerable.ElementAt(indexEnd));
            return compareResult < 0 ? Direction.Ascending : compareResult > 0 ? Direction.Descending : Direction.NotSorted;
        }
    }
}

```

Uses enum JonasSchubert.Snippets.Enumerable.Direction.

```c#
public enum Direction
    {
        NotSorted,
        Ascending,
        Descending
    }
```

<details>
<summary>Examples</summary>

```c#
new List<uint> { 1, 2, 3, 4, 5 }.SortedDirection(); # Direction.Ascending
new string[] { "C", "B", "A" }.SortedDirection(); # Direction.Descending
new List<TestStruct>() { new TestStruct { Byte = 0 }, new TestStruct { Byte = 1 }, new TestStruct { Byte = 0 } }.SortedDirection(); # Direction.NotSorted
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedIndex

Returns the lowest index at which value should be inserted into array in order to maintain its sort order.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedIndexBy

Returns the lowest index at which value should be inserted into array in order to maintain its sort order, based on a provided iterator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedLastIndex

Returns the highest index at which value should be inserted into array in order to maintain its sort order.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedLastIndexBy

Returns the highest index at which value should be inserted into array in order to maintain its sort order, based on a provided iterator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### stableSort
![advanced](/advanced.svg)

Performs stable sorting of an array, preserving the initial indexes of items when their values are the same.
Does not mutate the original array, but returns a new array instead.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### symmetricDifference

Returns the symmetric difference between two arrays, without filtering out duplicate values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### symmetricDifferenceBy

Returns the symmetric difference between two arrays, after applying the provided function to each array element of both.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### symmetricDifferenceWith

Returns the symmetric difference between two arrays, using a provided function as a comparator.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### tail

Returns all elements in an array except for the first one.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### take

Returns an array with n elements removed from the beginning.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### takeRight

Returns an array with n elements removed from the end.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### takeRightWhile

Removes elements from the end of an array until the passed function returns `true`. Returns the removed elements.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### takeWhile

Removes elements in an array until the passed function returns `true`. Returns the removed elements.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toCsv

Converts a 2D enumerable to a comma-separated values (CSV) string.

```c#

namespace JonasSchubert.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static string ToCsv<T>(this IEnumerable<IEnumerable<T>> enumerable, string delimiter = ",")
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            return string.Join("\n", enumerable.Select(subEnumerable => string.Join(delimiter, subEnumerable.Select(value => typeof(T).IsNumericType() ? value.ToString().Replace(",", ".") : value.ToString()))));
        }
    }
}

```

<details>
<summary>Examples</summary>

```c#
new List<List<bool>> { new List<bool> { true, true }, new List<bool> { true, false } }.ToCsv(); # "True,True\nTrue,False"
new double[][] { new double[] { 1.1, 2.2, 3.3 }, new double[] { 4.4, 5.5, 6.6 } }.ToCsv() # "1.1,2.2,3.3\n4.4,5.5,6.6"
new List<List<TestStruct>> { new List<TestStruct> { new TestStruct { Byte = 0 } }, new List<TestStruct> { new TestStruct { Byte = 1 }, new TestStruct { Byte = 2 } } }.ToCsv("-") # "Byte: 0\nByte: 1-Byte: 2"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toHash

Reduces a given Array-like into a value hash (keyed data store).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### union

Returns every element that exists in any of the two arrays once.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### unionBy

Returns every element that exists in any of the two arrays once, after applying the provided function to each array element of both.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### unionWith

Returns every element that exists in any of the two arrays once, using a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueElements

Returns all unique values of an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueElementsBy

Returns all unique values of an array, based on a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueElementsByRight

Returns all unique values of an array, based on a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueSymmetricDifference

Returns the unique symmetric difference between two arrays, not containing duplicate values from either array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### without

Filters out the elements of an array, that have one of the specified values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### xProd

Creates a new array out of the two supplied by creating each possible pair from the arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## ➗ Math

### approximatelyEqual

Checks if two numbers are approximately equal to each other.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### average

Returns the average of two or more numbers.

The method excepts numbers as params and returns the average as a result.

Linq documentation [here](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum).

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static double Average(this uint[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Aggregate(0.0, (current, element) => current + element) / elements.Length;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
{ 4, 5, 9, 1, 0 }.Average() # 3.8
```

</details>

<br>[↑ Back to top](#table-of-contents)

### averageBy

Returns the average of an array, after mapping each element to a value using the provided function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### binomialCoefficient

Evaluates the binomial coefficient of two integers `n` and `k`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### degToRads

Converts an angle from degrees to radians.

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static double DegToRad(this decimal degree) => (double)degree * System.Math.PI / 180.0;

        public static double DegToRad(this double degree) => degree * System.Math.PI / 180.0;

        public static double DegToRad(this float degree) => degree * System.Math.PI / 180.0;

        public static double DegToRad(this int degree) => degree * System.Math.PI / 180.0;

        public static double DegToRad(this uint degree) => degree * System.Math.PI / 180.0;
    }
}
```

<details>
<summary>Examples</summary>

```c#
270.0.DegToRad(); # ~ 4.71
-90u.DegToRad(); # ~ 1.57
720.DegToRad(); # ~ 12.57
```

</details>

<br>[↑ Back to top](#table-of-contents)

### digitize

Converts a number to an array of digits.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### distance

Returns the distance between two points.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### factorial

Calculates the factorial of a number.

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static uint Factorial(uint number)
        {
            var result = 1u;

            for (var index = number; index > 0; index--)
            {
                result *= index;
            }

            return result;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Math.Factorial(0); # 1
Math.Factorial(3); # 6
Math.Factorial(6); # 720
```

</details>

<br>[↑ Back to top](#table-of-contents)

### fibonacci

Generates an list, containing the Fibonacci sequence, up until the nth term.

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static List<int> Fibonaci(int length)
        {
            var list = new List<int>();

            for (var index = 0; index < length; index++)
            {
                list.Add(index <= 1 ? index : list[index - 1] + list[index - 2]);
            }

            return list;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Math.Fibonaci(2); # new List<int>() { 0, 1 }
Math.Fibonaci(7); # new List<int>() { 0, 1, 1, 2, 3, 5, 8 }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### gcd

Calculates the greatest common divisor between two or more numbers/arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### geometricProgression

Initializes an array containing the numbers in the specified range where `start` and `end` are inclusive and the ratio between two terms is `step`.
Returns an error if `step` equals `1`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### inRange

Checks if the given number falls within the given range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isDivisibleBy

Checks if the a number is divisible by another number.

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static bool IsDivisibleBy(this decimal value, decimal divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        public static bool IsDivisibleBy(this double value, double divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        public static bool IsDivisibleBy(this float value, float divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        public static bool IsDivisibleBy(this int value, int divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        public static bool IsDivisibleBy(this uint value, uint divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;
    }
}

```

<details>
<summary>Examples</summary>

```c#
1.IsDivisibleBy(2); # true
-2.0.IsDivisibleBy(2.0); # true
1.0f.IsDivisibleBy(2.0f); # false
2u.IsDivisibleBy(2u); # true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isEven

Returns `true` if the given number is even, `false` otherwise.

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static bool IsEven(this decimal value) => value % 2 == 0;

        public static bool IsEven(this double value) => value % 2 == 0;

        public static bool IsEven(this float value) => value % 2 == 0;

        public static bool IsEven(this int value) => value % 2 == 0;

        public static bool IsEven(this uint value) => value % 2 == 0;
    }
}
```

<details>
<summary>Examples</summary>

```c#
0.IsEven(); # true
1u.IsEven(); # false
-2.0.IsEven(); # true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isPrime

Checks if the provided integer is a prime number.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isOdd

Returns `true` if the given number is odd, `false` otherwise.

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static bool IsOdd(this decimal value) => value % 2 == 1;

        public static bool IsOdd(this double value) => value % 2 == 1;

        public static bool IsOdd(this float value) => value % 2 == 1;

        public static bool IsOdd(this int value) => value % 2 == 1;

        public static bool IsOdd(this uint value) => value % 2 == 1;
    }
}
```

<details>
<summary>Examples</summary>

```c#
0.IsOdd(); # false
1u.IsOdd(); # true
-2.0.IsOdd(); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### lcm

Returns the least common multiple of two or more numbers.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### luhnCheck
![advanced](/advanced.svg)

Implementation of the [Luhn Algorithm](https://en.wikipedia.org/wiki/Luhn_algorithm) used to validate a variety of identification numbers, such as credit card numbers, IMEI numbers, National Provider Identifier numbers etc.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### max

Returns the maximum value from the  provided enumerable.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### median

Returns the median of an array of numbers.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### min

Returns the minimum value from the  provided enumerable.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### primes

Generates primes up to a given number, using the Sieve of Eratosthenes.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### radToDeg

Converts an angle from radians to degrees.

```c#
namespace JonasSchubert.Snippets.Math
{
    public static partial class Math
    {
        public static double RadToDeg(this decimal radians) => (double)radians * 180.0 / System.Math.PI;

        public static double RadToDeg(this double radians) => radians * 180.0 / System.Math.PI;

        public static double RadToDeg(this float radians) => radians * 180.0 / System.Math.PI;

        public static double RadToDeg(this int radians) => radians * 180.0 / System.Math.PI;

        public static double RadToDeg(this uint radians) => radians * 180.0 / System.Math.PI;
    }
}

```

<details>
<summary>Examples</summary>

```c#
(System.Math.PI / 2).RadToDeg() # 90
(System.Math.PI * -2).RadToDeg() # -360
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomIntArrayInRange

Returns an array of n random integers in the specified range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomIntegerInRange

Returns a random integer in the specified range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomNumberInRange

Returns a random number in the specified range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### round

Rounds a number to a specified amount of digits.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sdbm

Hashes the input string into a whole number.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### standardDeviation

Returns the standard deviation of an array of numbers.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sum

Returns the sum of two or more numbers/arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sumBy

Returns the sum of an array, after mapping each element to a value using the provided function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 🎛️ Method

### hz

Returns the number of times a function executed per second. 
`hz` is the unit for `hertz`, the unit of frequency defined as one cycle per second.

```c#
namespace JonasSchubert.Snippets.Method
{
    public static partial class Method
    {
        public static long Hz(
            Action action,
            uint iterations = 100000)
        {
            var watch = Stopwatch.StartNew();

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                action.Invoke();
            }

            watch.Stop();

            return watch.ElapsedMilliseconds > 0
                ? (iterations * 1000) / watch.ElapsedMilliseconds
                : long.MaxValue;
        }
        
        ...
    }
}

```

<details>
<summary>Examples</summary>

```c#
 # will return time depending on your  PC power

int randomInt() => new Random().Next(0, 1000000);
Method.Hz(randomInt);

char[] charArrayFunc(string test) => test.ToCharArray().Select(x => (char)(x * 2)).Where(x => x > 0).ToArray();
Method.Hz(charArrayFunc);
```

</details>

<br>[↑ Back to top](#table-of-contents)

### times

Iterates over a callback `n` times

```c#
namespace JonasSchubert.Snippets.Method
{
    public static partial class Method
    {
        public static IList<T1> Times<T1>(Func<T1> func, uint times)
        {
            var list = new List<T1>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func());
            }

            return list;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Method.Times((() => true), 3) # list of size 3, all values true
Method.Times(((int start, int end) => new Random().Next(start, end)), 6, 0, 100) # list of size 6 with 6 random integers between 0 and 100
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 📜 String

### byteSize

Returns the length of a string in bytes.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### capitalize

Capitalizes the first letter of a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### capitalizeEveryWord

Capitalizes the first letter of every word in a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### countVowels

Returns number of vowels in provided string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### csvToArray

Converts a comma-separated values (CSV) string to a 2D array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### csvToJson
![advanced](/advanced.svg)

Converts a comma-separated values (CSV) string to a 2D array of objects.
The first row of the string is used as the title row.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### decapitalize

Decapitalizes the first letter of a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### endsWithRegex

Check if a string is ends with a given substring using a regex.

The method excepts the string to test and a regex.

Most other checks are already [integrated](https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith).

```c#
namespace JonasSchubert.Snippets.String
{
    public static partial class String
    {
        public static bool EndsWithRegex(this string input, Regex regex) => regex.IsMatch(input);
    }
}
```

<details>
<summary>Examples</summary>

```c#
"Hello World".EndsWithRegex(new Regex(@"[dolrwDOLRW]{5}$")) # true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### escapeHtml

Escapes a string for use in HTML.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### escapeRegExp

Escapes a string to use in a regular expression.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### fromCamelCase

Converts a string from camelcase.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### indentString

Indents each line in the provided string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isAbsoluteUrl

Returns `true` if the given string is an absolute URL, `false` otherwise.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isAnagram

Checks if a string is an anagram of another string (case-insensitive, ignores spaces, punctuation and special characters).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isLowerCase

Checks if a string is lower case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isUpperCase

Checks if a string is upper case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### mask

Replaces all but the last `num` of characters with the specified mask character.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pad

Pads a string on both sides with the specified character, if it's shorter than the specified length.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### palindrome

Returns `true` if the given string is a palindrome, `false` otherwise.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pluralize

Returns the singular or plural form of the word based on the input number. If the first argument is an `object`, it will use a closure by returning a function that can auto-pluralize words that don't simply end in `s` if the supplied dictionary contains the word.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### removeNonAscii

Removes non-printable ASCII characters.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reverseString

Reverses a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortCharactersInString

Alphabetically sorts the characters in a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### splitLines

Splits a multiline string into an array of lines.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### startsWithRegex

Check if a string starts with a given regex.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### stringPermutations
![advanced](/advanced.svg)

⚠️ **WARNING**: This function's execution time increases exponentially with each character.

Generates all permutations of a string (contains duplicates).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### stripHtmlTags

Removes HTML/XML tags from string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toCamelCase

Converts a string to camelcase.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toKebabCase

Converts a string to kebab case.

```c#
namespace JonasSchubert.Snippets.String
{
    public static partial class String
    {
        public static string ToKebabCase(this string input) =>
            string.Join("-", Regex.Matches(input, @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g").Select(x => x.Value.ToLower()));
    }
}

```

<details>
<summary>Examples</summary>

```c#
"camelCase".ToKebabCase(); # "camel-case"
"some text".ToKebabCase(); # "some-text"
"some-mixed_string With spaces_underscores-and-hyphens".ToKebabCase(); # "some-mixed-string-with-spaces-underscores-and-hyphens"
"AllThe-small Things".ToKebabCase(); # "all-the-small-things"
"IAmListeningToFmWhileLoadingDifferentUrlOnMyBrowserAndAlsoEditingXmlAndHtml".ToKebabCase(); # "i-am-listening-to-fm-while-loading-different-url-on-my-browser-and-also-editing-xml-and-html"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toSnakeCase

Converts a string to snake case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toTitleCase

Converts a string to title case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### truncate

Truncates a string up to a specified length.

```c#
namespace JonasSchubert.Snippets.String
{
    public static partial class String
    {
        public static string Truncate(this string input, int maxLength) =>
            input.Length > maxLength ? $"{input.Substring(0, maxLength > 3 ? maxLength - 3 : maxLength)}..." : input;
    }
}
```

<details>
<summary>Examples</summary>

```c#
"Hello World".Truncate(4); # "H..."
"Hello World".Truncate(12); # "Hello World"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### urlJoin
![advanced](/advanced.svg)

Joins all given URL segments together, then normalizes the resulting URL

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### words

Converts a given string into a list of words.

```c#
namespace JonasSchubert.Snippets.String
{
    public static partial class String
    {
        public static List<string> Words(this string input, string pattern = @"\w+[^\s]*\w+|\w") =>
            Regex.Matches(input, pattern).Select(x => x.Value).ToList();
    }
}
```

<details>
<summary>Examples</summary>

```c#
"Hello World".Words(); # new List<string> { "Hello", "World" }
"Hello".Words(); # new List<string> { "Hello" }
"  ".Words(); # new List<string>()
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 📃️ Type

### isNumericType

Checks if the provided type is of a numeric type.

```c#
namespace JonasSchubert.Snippets.Type2
{
    public static partial class Type2
    {
        public static bool IsNumericType(this Type type)
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
    }
}
```

<details>
<summary>Examples</summary>

```c#
typeof(sbyte).IsNumericType(); # true
typeof(short).IsNumericType(); # true
typeof(float).IsNumericType(); # true
typeof(string).IsNumericType(); # false
typeof(int[]).IsNumericType(); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 🔧 Utility

### extendHex

Extends a 3-digit color code to a 6-digit color code.

```c#
namespace JonasSchubert.Snippets.Utility
{
    public static partial class Utility
    {
        public static string ExtendHex(this string hex) =>
            $"{string.Join("", (hex.StartsWith('#') ? hex : $"#{hex}").Select(x => x == '#' ? $"{x}" : $"{x}{x}"))}";
    }
}
```

<details>
<summary>Examples</summary>

```c#
"#03f".ExtendHex(); # "#0033ff"
"05a".ExtendHex(); # "#0055aa"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### hexToRgb
![advanced](/advanced.svg)

Converts a color code to a `rgb()` or `rgba()` string if alpha value is provided.

```c#
namespace JonasSchubert.Snippets.Utility
{
    public static partial class Utility
    {
        public static string HexToRgb(string value)
        {
            value = value.Replace("#", "");
            var hasAlpha = value.Length == 8;
            value = value.Length == 3 ? string.Join("", value.Select(x => $"{x}{x}")) : value;
            var valueAsInt = int.Parse(value, NumberStyles.HexNumber);

            var red = valueAsInt >> (hasAlpha ? 24 : 16);
            var green = (valueAsInt & (hasAlpha ? 0x00ff0000 : 0x00ff00)) >> (hasAlpha ? 16 : 8);
            var blue = (valueAsInt & (hasAlpha ? 0x0000ff00 : 0x0000ff)) >> (hasAlpha ? 8 : 0);
            var alpha = hasAlpha ? $"{ valueAsInt & 0x000000ff}" : null;

            return $"rgb{(hasAlpha ? "a" : "")}({red}, {green}, {blue}{(hasAlpha ? $", {alpha}" : "")})";
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Utility.HexToRgb("#fff"); # "rgb(255, 255, 255)"
Utility.HexToRgb("#27ae60"); # "rgb(39, 174, 96)"
Utility.HexToRgb("#27ae60ff"); # "rgba(39, 174, 96, 255)"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### prettyBytes
![advanced](/advanced.svg)

Converts a number in bytes to a human-readable string.

```c#
namespace JonasSchubert.Snippets.Utility
{
    public static partial class Utility
    {
        public static string PrettyBytes(ulong bytes)
        {
            var units = new string[] { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

            var stringArray = units
                .Select((unit, index) =>
                    Math.Floor(bytes / Math.Pow(1e3, index) % 1e3) > 0
                    ? $"{Math.Floor(bytes / Math.Pow(1e3, index) % 1e3)} {unit}{(Math.Floor(bytes / Math.Pow(1e3, index) % 1e3) > 1 ? "s" : string.Empty)}"
                    : string.Empty)
                .Where(x => !string.IsNullOrEmpty(x))
                .Reverse()
                .ToArray();

            return stringArray.Length > 0
                ? string.Join(", ", stringArray)
                : "0 B";
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
 Utility.PrettyBytes(0ul); # "0 B"
 Utility.PrettyBytes(1001ul); # "1 KB, 1 B"
 Utility.PrettyBytes(20000000000000000ul); # "20 PBs"
 Utility.PrettyBytes(1001001001ul); # "1 GB, 1 MB, 1 KB, 1 B"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomHexColor

Generates a random hexadecimal color.

```c#
namespace JonasSchubert.Snippets.Utility
{
    public static partial class Utility
    {
        public static string RandomHexColor() =>
            $"#{(new Random().Next() * 0xFFFFFF * 1000000).ToString("X").PadLeft(6, '0').Substring(0, 6)}";
    }
}
```

<details>
<summary>Examples</summary>

```c#
Utility.RandomHexColor(); # "#01A5FF" (e.g.)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### rgbToHex

Converts the values of RGB components to a color code.

```c#
namespace JonasSchubert.Snippets.Utility
{
    public static partial class Utility
    {
        public static string RgbToHex(int red, int green, int blue) =>
            $"#{((red << 16) + (green << 8) + blue).ToString("X").PadLeft(6, '0')}";
    }
}
```

<details>
<summary>Examples</summary>

```c#
Utility.RgbToHex(0, 0, 0); # "#000000"
Utility.RgbToHex(1, 165, 255); # "#01A5FF"
Utility.RgbToHex(255, 255, 255); # "#FFFFFF"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### timeTaken

Measures the time taken by a function to execute.

Stopwatch documentation [here](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch).

```c#
namespace JonasSchubert.Snippets.Utility
{
    public static partial class Utility
    {
        public static (long, T1) TimeTaken<T1>(Func<T1> func)
        {
            var watch = Stopwatch.StartNew();
            T1 result = func.Invoke();
            watch.Stop();
            return (watch.ElapsedMilliseconds, result);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Utility.TimeTaken(() => true) # 13.37ms, true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### yesNo

Returns `true` if the string is `y`/`yes` or `false` if the string is `n`/`no`.

```c#
namespace JonasSchubert.Snippets.Utility
{
    public static partial class Utility
    {
        public static bool YesNo(this string test, bool defaultVal = false) =>
            new Regex(@"^(y|yes)$", RegexOptions.IgnoreCase).IsMatch(test)
                ? true
                : new Regex(@"^(n|no)$", RegexOptions.IgnoreCase).IsMatch(test)
                    ? false
                    : defaultVal;
    }
}
```

<details>
<summary>Examples</summary>

```c#
var empty = "".YesNo(); # false
var yes = "yes".YesNo(); # true
var y = "y".YesNo(); # true
var NO = "NO".YesNo(); # false
var nO = "nO".YesNo(); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

## Contribute

You're always welcome to contribute to this project. Please read the [contribution guide](CONTRIBUTING.md).

## Contributors

| [<img alt="JonasSchubert" src="https://avatars0.githubusercontent.com/u/21952813?v=4&s=117" width="117"/>](https://github.com/JonasSchubert) | [<img alt="DenisBiondic" src="https://avatars1.githubusercontent.com/u/3341262?v=4&s=117" width="117"/>](https://github.com/DenisBiondic) 
| :---------------------------------------------------------------------------------------------------------------------------------------: | :---------------------------------------------------------------------------------------------------------------------------------------: |
| [Jonas Schubert](https://github.com/JonasSchubert) | [Denis Biondic](https://github.com/DenisBiondic) |

## License

30 Seconds of C# is distributed under the MIT license. [See LICENSE](LICENSE.md) for details.

```
MIT License

Copyright (c) 2018-2019 JonasSchubert

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
