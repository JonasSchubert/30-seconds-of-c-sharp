using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Date.Test
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

        [Fact]
        public void GetDaysDiffBetweenDates_ShouldThrowArgumentException_IfTimezonesDiffer_LocalUtc()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 21);
            dateTime1 = DateTime.SpecifyKind(dateTime1, DateTimeKind.Local);
            var dateTime2 = new DateTime(2018, 11, 22);
            dateTime2 = DateTime.SpecifyKind(dateTime2, DateTimeKind.Utc);

            // Act
            Action action = () => Date.GetDaysDiffBetweenDates(dateTime1, dateTime2);

            // Assert
            action.Should().Throw<ArgumentException>("The DateTime values have to be in the same timezone! dateTime1 uses Local, while dateTime2 uses Utc!");
        }

        [Fact]
        public void GetDaysDiffBetweenDates_ShouldThrowArgumentException_IfTimezonesDiffer_UtcUnspecified()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 21);
            dateTime1 = DateTime.SpecifyKind(dateTime1, DateTimeKind.Utc);
            var dateTime2 = new DateTime(2018, 11, 22);
            dateTime2 = DateTime.SpecifyKind(dateTime2, DateTimeKind.Unspecified);

            // Act
            Action action = () => Date.GetDaysDiffBetweenDates(dateTime1, dateTime2);

            // Assert
            action.Should().Throw<ArgumentException>("The DateTime values have to be in the same timezone! dateTime1 uses Utc, while dateTime2 uses Unspecified!");
        }
    }
}
