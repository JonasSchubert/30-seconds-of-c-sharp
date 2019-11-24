using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Math.Test
{
    public class MathIsEvenUnitTest
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(-2, true)]
        public void MathIsEven_ShouldReturnExpectedResult_ForDecimal(decimal number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsEven();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.0, true)]
        [InlineData(1.0, false)]
        [InlineData(-2.0, true)]
        public void MathIsEven_ShouldReturnExpectedResult_ForDouble(double number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsEven();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.0f, true)]
        [InlineData(1.0f, false)]
        [InlineData(-2.0f, true)]
        public void MathIsEven_ShouldReturnExpectedResult_ForFloat(float number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsEven();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(-2, true)]
        public void MathIsEven_ShouldReturnExpectedResult_ForInt(int number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsEven();

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0u, true)]
        [InlineData(1u, false)]
        [InlineData(2u, true)]
        public void MathIsEven_ShouldReturnExpectedResult_ForUInt(uint number, bool expected)
        {
            // Arrange & Act
            var actual = number.IsEven();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
