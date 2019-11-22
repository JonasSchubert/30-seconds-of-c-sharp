using FluentAssertions;
using System;
using Xunit;

namespace JonasSchubert.Snippets.Date.Test
{
    public class DateIsBeforeDateUnitTest
    {
        [Fact]
        public void IsBeforeDate_ShouldReturnTrue_IfDateTime1_IsAfterDateTime2()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 21);
            var dateTime2 = new DateTime(2018, 11, 22);
            // Act
            var actual = dateTime1.IsBeforeDate(dateTime2);
            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void IsBeforeDate_ShouldReturnFalse_IfDateTime1_IsEqualDateTime2()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 22);
            var dateTime2 = new DateTime(2018, 11, 22);
            // Act
            var actual = dateTime1.IsBeforeDate(dateTime2);
            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsBeforeDate_ShouldReturnFalse_IfDateTime1_IsBeforeDateTime2()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 22);
            var dateTime2 = new DateTime(2018, 11, 21);
            // Act
            var actual = dateTime1.IsBeforeDate(dateTime2);
            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsBeforeDate_ShouldThrowArgumentException_IfTimezonesDiffer_LocalUtc()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 21);
            dateTime1 = DateTime.SpecifyKind(dateTime1, DateTimeKind.Local);
            var dateTime2 = new DateTime(2018, 11, 22);
            dateTime2 = DateTime.SpecifyKind(dateTime2, DateTimeKind.Utc);
            // Act
            Action action = () => dateTime1.IsBeforeDate(dateTime2);
            // Assert
            action.Should().Throw<ArgumentException>("The DateTime values have to be in the same timezone! dateTime1 uses Local, while dateTime2 uses Utc!");
        }

        [Fact]
        public void IsBeforeDate_ShouldThrowArgumentException_IfTimezonesDiffer_UtcUnspecified()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 21);
            dateTime1 = DateTime.SpecifyKind(dateTime1, DateTimeKind.Utc);
            var dateTime2 = new DateTime(2018, 11, 22);
            dateTime2 = DateTime.SpecifyKind(dateTime2, DateTimeKind.Unspecified);
            // Act
            Action action = () => dateTime1.IsBeforeDate(dateTime2);
            // Assert
            action.Should().Throw<ArgumentException>("The DateTime values have to be in the same timezone! dateTime1 uses Utc, while dateTime2 uses Unspecified!");
        }
    }
}