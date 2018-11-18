### String.EndsWith

Check if a string is ends with a given substring using a regex, a value, stringcomparison or cultureinfo

The method excepts the string to test, either a regex, another only string or a string with stringComparison setting

Already integrated into C#
https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netframework-4.7.2

``` c#
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

``` c#
SnippetsString.EndsWith("Hello World", new Regex(@"[dolrwDOLRW]{5}$")) # true
```