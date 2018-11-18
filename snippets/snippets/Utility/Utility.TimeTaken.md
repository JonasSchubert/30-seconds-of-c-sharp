### Utility.TimeTaken

Measures the time taken by a function to execute.

Stopwatch documentation
https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?redirectedfrom=MSDN&view=netframework-4.7.2

``` c#
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

``` c#
SnippetsUtility.TimeTaken(() => true) # 13.37ms, true
```