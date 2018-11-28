using FluentAssertions;
using System;
using Xunit;

namespace Conplement.Snippets.Date.Test
{
    public class DateTomorrowUnitTest
    {
        [Theory]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        [InlineData(null)]
        public void Tomorrow_ShouldReturnUtcDateTimeOfTomorrow_ForUnspecifiedOrNotProvidedDateTimeKind(DateTimeKind dateTimeKind)
        {
            // Arrange
            var expected = DateTime.UtcNow + TimeSpan.FromDays(1);

            // Act
            var actual = Date.Tomorrow(dateTimeKind);

            // Assert
            // It is hard to test for equal DateTime values as we create a new instance every few milliseconds, so we just test for kind and day
            actual.Kind.Should().Be(expected.Kind);
            actual.DayOfYear.Should().Be(expected.DayOfYear);
        }

        [Fact]
        public void Tomorrow_ShouldReturnLocalDateTimeOfTomorrow_ForLocalDateTimeKind()
        {
            // Arrange
            var expected = DateTime.Now + TimeSpan.FromDays(1);

            // Act
            var actual = Date.Tomorrow(DateTimeKind.Local);

            // Assert
            // It is hard to test for equal DateTime values as we create a new instance every few milliseconds, so we just test for kind and day
            actual.Kind.Should().Be(expected.Kind);
            actual.DayOfYear.Should().Be(expected.DayOfYear);
        }
    }
}
