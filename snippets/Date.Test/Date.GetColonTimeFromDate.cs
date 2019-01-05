using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Conplement.Snippets.Date.Test
{
    public class DateGetColonTimeFromDateUnitTest
    {
        public static IEnumerable<object[]> GetColonTimeFromDateTimeData()
        {
            yield return new object[] { new DateTime(2018, 11, 22, 17, 53, 23), "17:53:23" };
            yield return new object[] { new DateTime(1990, 1, 2, 3, 41, 5), "03:41:05" };
            yield return new object[] { new DateTime(1991, 2, 23, 1, 33, 7), "01:33:07" };
        }

        [Theory]
        [MemberData(nameof(GetColonTimeFromDateTimeData))]
        public void GetColonTimeFromDate_ShouldFormatDateTime_AsExpected(DateTime dateTime, string expectedString)
        {
            // Arrange + Act
            var actual = dateTime.GetColonTimeFromDate();

            // Assert
            actual.Should().Be(expectedString);
        }

        public static IEnumerable<object[]> GetColonTimeFromTimeSpanData()
        {
            yield return new object[] { new TimeSpan(17, 53, 23), "17:53:23" };
            yield return new object[] { new TimeSpan(3, 41, 5), "03:41:05" };
            yield return new object[] { new TimeSpan(1, 33, 7), "01:33:07" };
        }

        [Theory]
        [MemberData(nameof(GetColonTimeFromTimeSpanData))]
        public void GetColonTimeFromDate_ShouldFormatTimeSpan_AsExpected(TimeSpan timeSpan, string expectedString)
        {
            // Arrange + Act
            var actual = timeSpan.GetColonTimeFromDate();

            // Assert
            actual.Should().Be(expectedString);
        }
    }
}
