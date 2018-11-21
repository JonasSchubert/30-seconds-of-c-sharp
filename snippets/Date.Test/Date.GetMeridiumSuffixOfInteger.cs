using FluentAssertions;
using System;
using Xunit;

namespace conplement.snippets.Date.Test
{
    public class DateGetMeridiumSuffixOfIntegerUnitTest
    {
        [Theory]
        [InlineData(0, "12am")]
        [InlineData(11, "11am")]
        [InlineData(13, "1pm")]
        [InlineData(18, "6pm")]
        [InlineData(24, "12am")]
        public void GetMeridiumSuffixOfInteger_ShouldReturnExpectedResult(int value, string expected)
        {
            // Arrange + Act
            var actual = value.GetMeridiumSuffixOfInteger();

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void ShouldThrowArgumentException_IfValueIsLessThen0()
        {
            // Act
            Action action = () => (-1).GetMeridiumSuffixOfInteger();

            // Assert
            action.Should().Throw<ArgumentException>("Invalid value -1 in method GetMeridiumSuffixOfInteger", "value");
        }

        [Fact]
        public void ShouldThrowArgumentException_IfValueIsHigherThen24()
        {
            // Act
            Action action = () => (25).GetMeridiumSuffixOfInteger();

            // Assert
            action.Should().Throw<ArgumentException>("Invalid value 25 in method GetMeridiumSuffixOfInteger", "value");
        }
    }
}
