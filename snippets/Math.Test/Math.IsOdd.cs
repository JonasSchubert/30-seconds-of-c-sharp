using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Math.Test
{
    public class MathIsOddUnitTest
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(-2, false)]
        public void MathIsOdd_ShouldReturnExpectedResult_ForDecimal(decimal number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsOdd();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.0, false)]
        [InlineData(1.0, true)]
        [InlineData(-2.0, false)]
        public void MathIsOdd_ShouldReturnExpectedResult_ForDouble(double number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsOdd();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.0f, false)]
        [InlineData(1.0f, true)]
        [InlineData(-2.0f, false)]
        public void MathIsOdd_ShouldReturnExpectedResult_ForFloat(float number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsOdd();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(-2, false)]
        public void MathIsOdd_ShouldReturnExpectedResult_ForInt(int number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsOdd();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0u, false)]
        [InlineData(1u, true)]
        [InlineData(2u, false)]
        public void MathIsOdd_ShouldReturnExpectedResult_ForUInt(uint number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsOdd();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
