using FluentAssertions;
using System;
using Xunit;

namespace JonasSchubert.Snippets.Date.Test
{
    public class DateIsSameDateUnitTest
    {
        [Fact]
        public void IsSameDate_ShouldReturnTrue_IfDatesAreTheSame()
        {
            // Arrange
            var dateTime = DateTime.Now;

            // Act
            var actual = dateTime.IsSameDate(dateTime);

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void IsSameDate_ShouldReturnTrue_IfDatesAreTheSame_ButDifferentCreation()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 26, 0, 0, 0);
            var dateTime2 = new DateTime(2018, 11, 26);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfYearsAreDifferent_AndRestIsEqual()
        {
            // Arrange
            var dateTime1 = new DateTime(2019);
            var dateTime2 = new DateTime(2018);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfMonthAreDifferent_AndRestIsEqual()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 1);
            var dateTime2 = new DateTime(2018, 10, 1);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfDaysAreDifferent_AndRestIsEqual()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 26);
            var dateTime2 = new DateTime(2018, 11, 25);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfHoursAreDifferent_AndRestIsEqual()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 26, 1, 0, 0);
            var dateTime2 = new DateTime(2018, 11, 26, 2, 0, 0);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfMinutesAreDifferent_AndRestIsEqual()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 26, 2, 0, 0);
            var dateTime2 = new DateTime(2018, 11, 26, 2, 10, 0);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfSecondsAreDifferent_AndRestIsEqual()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 26, 2, 0, 3);
            var dateTime2 = new DateTime(2018, 11, 26, 2, 0, 0);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfMilliSecondsAreDifferent_AndRestIsEqual()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 26, 2, 0, 0, 300);
            var dateTime2 = new DateTime(2018, 11, 26, 2, 0, 0, 299);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfTicksAreDifferent()
        {
            // Arrange
            var dateTime1 = new DateTime(203940201L);
            var dateTime2 = new DateTime(203940202L);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void IsSameDate_ShouldReturnFalse_IfDateTimeIsEqual_ButTimeZoneIsDifferent()
        {
            // Arrange
            var dateTime1 = new DateTime(2018, 11, 26, 21, 30, 30);
            dateTime1 = DateTime.SpecifyKind(dateTime1, DateTimeKind.Local);
            var dateTime2 = new DateTime(2018, 11, 26, 21, 30, 30);
            dateTime2 = DateTime.SpecifyKind(dateTime2, DateTimeKind.Utc);

            // Act
            var actual = dateTime1.IsSameDate(dateTime2);

            // Assert
            actual.Should().BeFalse();
        }
    }
}
