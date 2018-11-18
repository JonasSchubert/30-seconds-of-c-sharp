using FluentAssertions;
using snippets.Date;
using System;
using Xunit;

namespace snippets.test.Date
{
    /// <summary>
    /// Unit tests for Date.DayOfYear-Snippet
    /// </summary>
    public class DateDayOfYearUnitTest
    {
        /// <summary>
        /// Date.DayOfYear Unit test
        /// </summary>
        [Theory]
        [InlineData(2018, 12, 31, 365)]
        [InlineData(2020, 12, 31, 366)]
        public void DayOfYear_ShouldReturnExpectedResult_ForGivenDateTimes(int year, int month, int dayOfMonth, int expectedDayOfYear)
        {
            // Arrange
            var dateTime = new DateTime(year, month, dayOfMonth);

            // Act
            var dateTimeResult = SnippetsDate.DayOfYear(dateTime);

            // Assert
            dateTimeResult.Should().Be(expectedDayOfYear);
        }
    }
}
