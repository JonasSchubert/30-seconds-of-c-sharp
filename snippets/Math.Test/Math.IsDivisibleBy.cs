using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Math.Test
{
    public class MathIsDivisibleByUnitTest
    {
        [Theory]
        [InlineData(0, 1, true)]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, false)]
        [InlineData(-2, 2, true)]
        public void MathIsDivisibleBy_ShouldReturnExpectedResult_ForDecimal(decimal number, decimal divider, bool expected)
        {
            // Arrange & Act
            var actual = number.IsDivisibleBy(divider);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.0, 1.0, true)]
        [InlineData(1.0, 1.0, true)]
        [InlineData(1.0, 1.1, false)]
        [InlineData(1.0, 2.0, false)]
        [InlineData(-2.0, 2.0, true)]
        public void MathIsDivisibleBy_ShouldReturnExpectedResult_ForDouble(double number, double divider, bool expected)
        {
            // Arrange & Act
            var actual = number.IsDivisibleBy(divider);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.0f, 1.0f, true)]
        [InlineData(1.0f, 1.0f, true)]
        [InlineData(1.0f, 1.1f, false)]
        [InlineData(1.0f, 2.0f, false)]
        [InlineData(-2.0f, 2.0f, true)]
        public void MathIsDivisibleBy_ShouldReturnExpectedResult_ForFloat(float number, float divider, bool expected)
        {
            // Arrange & Act
            var actual = number.IsDivisibleBy(divider);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, 1, true)]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, false)]
        [InlineData(-2, 2, true)]
        public void MathIsDivisibleBy_ShouldReturnExpectedResult_ForInt(int number, int divider, bool expected)
        {
            // Arrange & Act
            var actual = number.IsDivisibleBy(divider);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0u, 1u, true)]
        [InlineData(1u, 1u, true)]
        [InlineData(1u, 2u, false)]
        [InlineData(2u, 2u, true)]
        public void MathIsDivisibleBy_ShouldReturnExpectedResult_ForUInt(uint number, uint divider, bool expected)
        {
            // Arrange & Act
            var actual = number.IsDivisibleBy(divider);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
