### Type.GetType

Returns the native type of a value.

Already integrated into C#
https://docs.microsoft.com/de-de/dotnet/api/system.object.gettype?view=netframework-4.7.2

``` c#
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

``` c#
SnippetsType.GetType(new DateTime()) # DateTime
SnippetsType.GetType("Hello world") # String
```