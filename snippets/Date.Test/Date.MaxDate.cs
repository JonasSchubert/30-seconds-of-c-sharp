using FluentAssertions;
using System;
using Xunit;

namespace JonasSchubert.Snippets.Date.Test
{
    public class DateMaxDateUnitTest
    {
        [Fact]
        public void MaxDate_ShouldReturnExpectedResult()
        {
            // Arrange
            DateTime dateTime1 = new DateTime(2018, 11, 27, 22, 2, 15);
            DateTime dateTime2 = new DateTime(2018, 11, 27, 22, 2, 15);
            DateTime dateTime3 = new DateTime(2018, 11, 27);
            DateTime dateTime4 = new DateTime(2018, 11, 25);
            DateTime dateTime5 = new DateTime(2018, 1, 1, 0, 0, 0);
            DateTime dateTime6 = new DateTime(2018);

            DateTime[] list = { dateTime1, dateTime2, dateTime3, dateTime4, dateTime5, dateTime6 };

            // Act
            var actual = Date.MaxDate(list);

            // Assert
            actual.Should().Be(new DateTime(2018, 11, 27, 22, 2, 15));
        }

        [Fact]
        public void MaxDate_ShouldThrowException_WhenNullList_IsGiven()
        {
            // Arrange
            DateTime[] list = null;

            // Act
            Action action = () => Date.MaxDate(list);

            // Assert
            action.Should().Throw<ArgumentException>("The dateTimeList may not be empty!", "dateTimeList");
        }

        [Fact]
        public void MaxDate_ShouldThrowException_WhenEmptyList_IsGiven()
        {
            // Arrange
            DateTime[] list = { };

            // Act
            Action action = () => Date.MaxDate(list);

            // Assert
            action.Should().Throw<ArgumentException>("The dateTimeList may not be empty!", "dateTimeList");
        }

        [Fact]
        public void MaxDate_ShouldThrowException_IfDifferentTimezonesAreUsed()
        {
            // Arrange
            DateTime dateTime1 = new DateTime(2018, 11, 27, 22, 2, 15);
            dateTime1 = DateTime.SpecifyKind(dateTime1, DateTimeKind.Local);
            DateTime dateTime2 = new DateTime(2018, 11, 27, 22, 2, 15);
            dateTime2 = DateTime.SpecifyKind(dateTime2, DateTimeKind.Local);
            DateTime dateTime3 = new DateTime(2018, 11, 27);
            dateTime3 = DateTime.SpecifyKind(dateTime3, DateTimeKind.Unspecified);
            DateTime dateTime4 = new DateTime(2018, 11, 25);
            dateTime4 = DateTime.SpecifyKind(dateTime4, DateTimeKind.Local);
            DateTime dateTime5 = new DateTime(2018);
            dateTime5 = DateTime.SpecifyKind(dateTime5, DateTimeKind.Utc);

            DateTime[] list = { dateTime1, dateTime2, dateTime3, dateTime4, dateTime5 };

            // Act
            Action action = () => Date.MaxDate(list);

            // Assert
            action.Should().Throw<ArgumentException>("All params have to have the same timezone!", "dateTimeList");
        }
    }
}
