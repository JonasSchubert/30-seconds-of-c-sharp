### Array.All

Returns `true` if the provided function returns `true` for all elements of an array, `false` otherwise.

The method has a function as first parameter and params as second. It iterates over the params and checks if the provided function always returns true.

Already integrated into C#
https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=netframework-4.7.2

``` c#
namespace snippets.Array
{
    public static partial class SnippetsArray
    {
        public static bool All<T>(Func<T, bool> func, params T[] elements)
        {
            return elements.All(func);
        }
    }
}
```

``` c#
SnippetsArray.All(((bool element) => !element), false, false, false) # true
SnippetsArray.All(((int element) => element > 0), -1, 4, 5) # false
```