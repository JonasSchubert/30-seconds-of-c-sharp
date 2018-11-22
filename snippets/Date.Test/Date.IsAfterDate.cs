using FluentAssertions;
using System;
using Xunit;

namespace conplement.snippets.Date.Test
{
    public class DateIsAfterDateUnitTest
    {
        [Fact]
        public void IsAfterDate_ShouldReturnTrue_IfDateTime1_IsAfterDateTime2()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 22);
            var dateTime2 = new DateTime(2018, 11, 21);

            // Act
            var actual = dateTime1.IsAfterDate(dateTime2);

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void IsAfterDate_ShouldReturnFalse_IfDateTime1_IsEqualDateTime2()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 22);
            var dateTime2 = new DateTime(2018, 11, 22);

            // Act
            var actual = dateTime1.IsAfterDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsAfterDate_ShouldReturnFalse_IfDateTime1_IsBeforeDateTime2()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 21);
            var dateTime2 = new DateTime(2018, 11, 22);

            // Act
            var actual = dateTime1.IsAfterDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }
    }
}
