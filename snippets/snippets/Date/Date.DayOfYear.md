### Date.DayOfYear

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

``` c#
SnippetsDate.DayOfYear(new DateTime(2016, 12, 31)) # 12/31/2016: day 366 of 2016 (Leap Year)
```