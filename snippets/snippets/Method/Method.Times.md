### Method.Times

Iterates over a callback `n` times

The method has a function as first parameter and an uint as second (indicates the number of calls for the function). It collects the result of the method in a list and returns the list.

``` c#
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

``` c#
SnippetsMethod.Times((() => true), 3) # list of size 3, all values true
SnippetsMethod.Times((() => new Random().Next(0, 100)), 6) # list of size 6 with 6 random integers
```