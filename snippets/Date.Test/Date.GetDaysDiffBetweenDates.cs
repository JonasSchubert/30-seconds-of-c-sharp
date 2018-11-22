using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace conplement.snippets.Date.Test
{
    public class DateGetDaysDiffBetweenDatesUnitTest
    {
        public static IEnumerable<object[]> GetDaysDiffBetweenDatesData()
        {
            yield return new object[] { new DateTime(2018, 11, 22), new DateTime(2018, 11, 14), 8.0 };
            yield return new object[] { new DateTime(2018, 11, 22), new DateTime(2019, 11, 22), -365.0 };
            yield return new object[] { new DateTime(2018, 11, 22, 18, 0, 0), new DateTime(2018, 11, 22, 6, 0, 0), 0.5 };
        }

        [Theory]
        [MemberData(nameof(GetDaysDiffBetweenDatesData))]
        public void ReturnExpectedDays(DateTime dateTime1, DateTime dateTime2, double expectedDays)
        {
            // Arrange + Act
            var actual = Date.GetDaysDiffBetweenDates(dateTime1, dateTime2);

            // Assert
            actual.Should().Be(expectedDays);
        }
    }
}
