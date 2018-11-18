### Math.Average

Returns the average of two or more numbers.

The method excepts numbers as params and returns the average as a result

Linq documentation
https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2

``` c#
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

``` c#
SnippetsMath.Average(-3, 4, 10, -3) # 2
```