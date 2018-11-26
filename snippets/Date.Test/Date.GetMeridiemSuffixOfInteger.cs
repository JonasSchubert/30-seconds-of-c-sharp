using FluentAssertions;
using System;
using Xunit;

namespace Conplement.Snippets.Date.Test
{
    public class DateGetMeridiemSuffixOfIntegerUnitTest
    {
        [Theory]
        [InlineData(0, "12am")]
        [InlineData(11, "11am")]
        [InlineData(13, "1pm")]
        [InlineData(18, "6pm")]
        [InlineData(24, "12am")]
        public void GetMeridiemSuffixOfInteger_ShouldReturnExpectedResult(int value, string expected)
        {
            // Arrange + Act
            var actual = value.GetMeridiemSuffixOfInteger();

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void GetMeridiemSuffixOfInteger_ShouldThrowArgumentException_IfValueIsLessThen0()
        {
            // Act
            Action action = () => (-1).GetMeridiemSuffixOfInteger();

            // Assert
            action.Should().Throw<ArgumentException>("Invalid value -1 in method GetMeridiemSuffixOfInteger", "value");
        }

        [Fact]
        public void GetMeridiemSuffixOfInteger_ShouldThrowArgumentException_IfValueIsHigherThen24()
        {
            // Act
            Action action = () => (25).GetMeridiemSuffixOfInteger();

            // Assert
            action.Should().Throw<ArgumentException>("Invalid value 25 in method GetMeridiemSuffixOfInteger", "value");
        }
    }
}
