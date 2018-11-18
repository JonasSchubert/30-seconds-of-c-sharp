![Logo](/logo.png)

# 30 seconds of C#
> A curated collection of useful C# snippets that you can understand in 30 seconds or less.

Note: This project is inspired by [30 Seconds of Code](https://github.com/Chalarangelo/30-seconds-of-code), but there is no affiliation with that project.

## Table of Contents

### 📚 Array

<details>
<summary>View contents</summary>

* [`all`](#all)
* [`allEqual`](#allEqual)
* [`any`](#any)
* [`arrayToCsv`](#arrayToCsv)
* [`bifurcate`](#bifurcate)
* [`bifurcateBy`](#bifurcateBy)
* [`bubbleSort`](#bubbleSort)
* [`chunk`](#chunk)
* [`compact`](#compact)
* [`countBy`](#countBy)
* [`countOccurences`](#countOccurences)
* [`deepFlatten`](#deepflatten)
* [`difference`](#difference)
* [`differenceBy`](#differenceBy)
* [`differenceWith`](#differenceWith)
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
* [`groupBy`](#groupBy)
* [`hasDuplicates`](#hasDuplicates)
* [`head`](#head)
* [`indexOfAll`](#indexOfAll)
* [`initial`](#initial)
* [`initialize2DArray`](#initialize2DArray)
* [`initializeArrayWithRange`](#initializeArrayWithRange)
* [`initializeArrayWithRangeRight`](#initializeArrayWithRangeRight)
* [`initializeArrayWithValues`](#initializeArrayWithValues)
* [`initializeNDArray`](#initializeNDArray)
* [`intersection`](#intersection)
* [`intersectionBy`](#intersectionBy)
* [`intersectionWith`](#intersectionWith)
* [`isSorted`](#isSorted)
* [`join`](#join)
* [`jsonToCsv`](#jsonToCsv)
* [`last`](#last)
* [`longestItem`](#longestItem)
* [`mapObject`](#mapObject)
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

### ➗ Math

<details>
<summary>View contents</summary>

* [`approximatelyEqual`](#approximatelyEqual)
* [`average`](#average)
* [`averageBy`](#averageBy)
* [`binomialCoefficient`](#binomialCoefficient)
* [`degreesToRads`](#degreesToRads)
* [`digitize`](#digitize)
* [`distance`](#distance)
* [`factorial`](#factorial)
* [`fibonacci`](#fibonacci)
* [`gcd`](#gcd)
* [`geometricProgression`](#geometricProgression)
* [`inRange`](#inRange)
* [`isDivisible`](#isDivisible)
* [`isEven`](#isEven)
* [`isPrime`](#isPrime)
* [`isOdd`](#isOdd)
* [`lcm`](#lcm)
* [`luhnCheck`](#luhnCheck)
* [`max`](#max)
* [`median`](#median)
* [`min`](#min)
* [`primes`](#primes)
* [`radsToDegrees`](#radsToDegrees)
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
* [`endsWith`](#endsWith)
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
* [`startsWith`](#startsWith)
* [`stringPermutations`](#stringPermutations)
* [`stripHtmlTags`](#stripHtmlTags)
* [`toCamelCase`](#toCamelCase)
* [`toKebabCase`](#toKebabCase)
* [`toSnakeCase`](#toSnakeCase)
* [`toTitleCase`](#toTitleCase)
* [`truncateString`](#truncateString)
* [`unescapeHTML`](#unescapeHTML)
* [`urlJoin`](#urlJoin)
* [`words`](#words)

</details>

### 📃️ Type

<details>
<summary>View contents</summary>

* [`getType`](#getType)
* [`is`](#is)
* [`isValidJson`](#isValidJson)

</details>

### 🔧 Utility

<details>
<summary>View contents</summary>

* [`coalesce`](#coalesce)
* [`extendHex`](#extendHex)
* [`getUrlParameters`](#getUrlParameters)
* [`hexToRgb`](#hexToRgb)
* [`mostPerformant`](#mostPerformant)
* [`prettyBytes`](#prettyBytes)
* [`randomHexColorCode`](#randomHexColorCode)
* [`rgbToHex`](#rgbToHex)
* [`timeTaken`](#timeTaken)
* [`toOrdinalSuffix`](#toOrdinalSuffix)
* [`yesNo`](#yesNo)

</details>

---
 ## 📚 Array

### all

Returns `true` if the provided function returns `true` for all elements of an array, `false` otherwise.

The method has a function as first parameter and params as second. It iterates over the params and checks if the provided function always returns true.

Already integrated into C#
https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=netframework-4.7.2

```c#
namespace snippets.Array
{
    public static partial class SnippetsArray
    {
        public static bool All<T>(Func<T, bool> func, params T[] elements)
        {
            foreach (var element in elements)
            {
                if (!func(element)) return false;
            }

            return true;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
SnippetsArray.All(((bool element) => !element), false, false, false) # true
SnippetsArray.All(((int element) => element > 0), -1, 4, 5) # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### allEqual

Check if all elements in an array are equal.

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

### any

Returns `true` if the provided predicate function returns `true` for at least one element in a collection, `false` otherwise.

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

### arrayToCsv

Converts a 2D array to a comma-separated values (CSV) string.

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

### bifurcate

Splits values into two groups. If an element in `filter` is truthy, the corresponding element in the collection belongs to the first group; otherwise, it belongs to the second group.

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

### bifurcateBy

Splits values into two groups according to a predicate function, which specifies which group an element in the input collection belongs to. If the predicate function returns a truthy value, the collection element belongs to the first group; otherwise, it belongs to the second group.

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

Chunks an array into smaller arrays of a specified size.

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

### compact

Removes invalid values from an array.

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

### countBy

Groups the elements of an array based on the given function and returns the count of elements in each group.

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

### countOccurrences

Counts the occurrences of a value in an array.

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

Returns the difference between two arrays.

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

### differenceBy

Returns the difference between two arrays, after applying the provided function to each array element of both.

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

### differenceWith

Filters out all values from an array for which the comparator function does not return `true`.

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

### drop

Returns a new array with `n` elements removed from the left.

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

### dropRight

Returns a new array with `n` elements removed from the right.

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

### dropRightWhile

Removes elements from the end of an array until the passed function returns `true`. Returns the remaining elements in the array.

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

### dropWhile

Removes elements in an array until the passed function returns `true`. Returns the remaining elements in the array.

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

### everyNth

Returns every nth element in an array.

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

### filterNonUnique

Filters out the non-unique values in an array.

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

### filterNonUniqueBy

Filters out the non-unique values in an array, based on a provided comparator function.

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

### findLast

Returns the last element for which the provided function returns a truthy value.

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

### findLastIndex

Returns the index of the last element for which the provided function returns a truthy value.

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

Executes a provided function once for each array element, starting from the array's last element.

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

### groupBy

Groups the elements of an array based on the given function.

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

### hasDuplicates

Checks an array for duplicate values. Returns true if duplicate values exist and false if values are all unique.

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

### head

Returns the head of a list.

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

### indexOfAll

Returns all indices of a `value` in an array.
If the `value` never occurs, returns `[]`.

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
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
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

Returns a list of elements that exist in both arrays.

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

### intersectionBy

Returns a list of elements that exist in both arrays, after applying the provided function to each array element of both.

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

### intersectionWith

Returns a list of elements that exist in both arrays, using a provided comparator function.

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

### isSorted

Returns `1` if the array is sorted in ascending order, `-1` if it is sorted in descending order or `0` if it is not sorted.

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

### join

Joins all elements of an array into a string and returns this string.
Uses a separator and an end separator.

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

### jsonToCsv ![advanced](/advanced.svg)

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

### last

Returns the last element in an array.

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

### mapObject ![advanced](/advanced.svg)

Maps the values of an array to an object using a function, where the key-value pairs consist of the original value as the key and the mapped value.

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
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
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

### permutations ![advanced](/advanced.svg)

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

### pullAtIndex ![advanced](/advanced.svg)

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

### pullAtValue ![advanced](/advanced.svg)

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

### pullBy ![advanced](/advanced.svg)

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

### stableSort ![advanced](/advanced.svg)

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
 ## ⏱️ Date

### dayOfYear

Returns the day of the current year

Already integrated into C#
https://docs.microsoft.com/de-de/dotnet/api/system.datetime.dayofyear?view=netframework-4.7.2

``` c#
using System;

namespace snippets.Date
{
    public static partial class SnippetsDate
    {
        public static int DayOfYear(DateTime dateTime)
        {
            return dateTime.DayOfYear;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
SnippetsDate.DayOfYear(new DateTime(2016, 12, 31)) # 12/31/2016: day 366 of 2016 (Leap Year)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### formatDuration

Returns the human readable format of the given number of milliseconds.

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

### getColonTimeFromDate

Returns a string of the form `HH:MM:SS` from a `DateTime` or `TimeSpan` object.

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

### getDaysDiffBetweenDates

Returns the difference (in days) between two dates.

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

### getMeridiumSuffixOfInteger

Converts an integer to a suffixed string, adding `am` or `pm` based on its value.

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

### isAfterDate

Check if a date is after another date.

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

### isBeforeDate

Check if a date is before another date.

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

### isSameDate

Check if a date is the same as another date.

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

### maxDate

Returns the maximum of the given dates.

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

### minDate

Returns the minimum of the given dates.

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

### tomorrow

Returns tomorrow's date.

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

The method excepts numbers as params and returns the average as a result

Linq documentation
https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2

```c#
namespace snippets.Math
{
    public static partial class SnippetsMath
    {
        public static decimal Average(params decimal[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Sum() / elements.Length;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
SnippetsMath.Average(-3, 4, 10, -3) # 2
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

### degreesToRads

Converts an angle from degrees to radians.

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
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### fibonacci

Generates an array, containing the Fibonacci sequence, up until the nth term.

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

### isDivisible

Checks if the first numeric argument is divisible by the second one.

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

### isEven

Returns `true` if the given number is even, `false` otherwise.

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
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
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

### luhnCheck ![advanced](/advanced.svg)

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

### radsToDegrees

Converts an angle from radians to degrees.

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
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### times

Iterates over a callback `n` times

```c#
namespace snippets.Method
{
    public static partial class SnippetsMethod
    {
        public static IList<T> Times<T>(Func<T> func, uint times)
        {
            var list = new List<T>();

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
SnippetsMethod.Times((() => true), 3) # list of size 3, all values true
SnippetsMethod.Times((() => new Random().Next(0, 100)), 6) # list of size 6 with 6 random integers
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

### csvToJson ![advanced](/advanced.svg)

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

### endsWith

Check if a string is ends with a given substring using a regex, a value, stringcomparison or cultureinfo

The method excepts the string to test, either a regex, another only string or a string with stringComparison setting

Already integrated into C#
https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netframework-4.7.2

```c#
namespace snippets.String
{
    public static partial class SnippetsString
    {
        public static bool EndsWith(string input, Regex regex)
        {
            return regex.IsMatch(input);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
SnippetsString.EndsWith("Hello World", new Regex(@"[dolrwDOLRW]{5}$")) # true
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

### startsWith

Check if a string starts with a given substring.

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

### stringPermutations ![advanced](/advanced.svg)

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
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
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

### truncateString

Truncates a string up to a specified length.

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

### unescapeHTML

Unescapes escaped HTML characters.

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

### urlJoin ![advanced](/advanced.svg)

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

Converts a given string into an array of words.

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
 ## 📃️ Type

### getType

Returns the native type of a value.

Already integrated into C#
https://docs.microsoft.com/de-de/dotnet/api/system.object.gettype?view=netframework-4.7.2

```c#
namespace snippets.Type
{
    public static partial class SnippetsType
    {
        public static System.Type GetType(object obj)
        {
            return obj.GetType();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
SnippetsType.GetType(new DateTime()) # DateTime
SnippetsType.GetType("Hello world") # String
```

</details>

<br>[↑ Back to top](#table-of-contents)

### is

Checks if the provided value is of the specified type.

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

### isValidJson

Checks if the provided argument is a valid JSON.

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
 ## 🔧 Utility

### coalesce

Returns the first non-null argument.

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

### extendHex

Extends a 3-digit color code to a 6-digit color code.

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

### getUrlParameters

Returns an object containing the parameters of the current URL.

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

### hexToRgb ![advanced](/advanced.svg)

Converts a color code to a `rgb()` or `rgba()` string if alpha value is provided.

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

### mostPerformant

Returns the index of the function in an array of functions which executed the fastest.

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

### prettyBytes ![advanced](/advanced.svg)

Converts a number in bytes to a human-readable string.

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

### randomHexColorCode

Generates a random hexadecimal color code.

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

### rgbToHex

Converts the values of RGB components to a color code.

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

### timeTaken

Measures the time taken by a function to execute.

Stopwatch documentation
https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?redirectedfrom=MSDN&view=netframework-4.7.2

```c#
namespace snippets.Utility
{
    public static partial class SnippetsUtility
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
SnippetsUtility.TimeTaken(() => true) # 13.37ms, true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toOrdinalSuffix

Adds an ordinal suffix to a number.

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

### yesNo

Returns `true` if the string is `y`/`yes` or `false` if the string is `n`/`no`.

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



## Contribute
You're always welcome to contribute to this project. Please read the [contribution guide](CONTRIBUTING.md).

## License

This project is licensed under the MIT License - see the [License File](LICENSE.md) for details