using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Math.Test
{
    public class MathRadToDegUnitTest
    {
        [Theory]
        [InlineData(0, 0.0)]
        [InlineData(System.Math.PI / 2, 90)]
        [InlineData(System.Math.PI, 180)]
        [InlineData(System.Math.PI * 1.5, 270)]
        [InlineData(System.Math.PI * -2, -360)]
        public void MathRadToDeg_ShouldReturnExpectedResult_ForDecimal(decimal number, double result)
        {
            // Arrange & Act
            var actual = number.RadToDeg();

            // Assert
            actual.Should().BeApproximately(result, 0.1);
        }

        [Theory]
        [InlineData(0.0, 0.0)]
        [InlineData(System.Math.PI / 2, 90)]
        [InlineData(System.Math.PI, 180)]
        [InlineData(System.Math.PI * 1.5, 270)]
        [InlineData(System.Math.PI * -2, -360)]
        public void MathRadToDeg_ShouldReturnExpectedResult_ForDouble(double number, double result)
        {
            // Arrange & Act
            var actual = number.RadToDeg();

            // Assert
            actual.Should().BeApproximately(result, 0.1);
        }

        [Theory]
        [InlineData(0.0f, 0.0)]
        [InlineData(System.Math.PI / 2, 90)]
        [InlineData(System.Math.PI, 180)]
        [InlineData(System.Math.PI * 1.5, 270)]
        [InlineData(System.Math.PI * -2, -360)]
        public void MathRadToDeg_ShouldReturnExpectedResult_ForFloat(float number, double result)
        {
            // Arrange & Act
            var actual = number.RadToDeg();

            // Assert
            actual.Should().BeApproximately(result, 0.1);
        }

        [Theory]
        [InlineData(0, 0.0)]
        [InlineData(System.Math.PI / 2, 114.59)]
        [InlineData(System.Math.PI, 171.88)]
        [InlineData(System.Math.PI * 1.5, 286.48)]
        [InlineData(System.Math.PI * -2, -343.77)]
        public void MathRadToDeg_ShouldReturnExpectedResult_ForInt(int number, double result)
        {
            // Arrange & Act
            var actual = number.RadToDeg();

            // Assert
            actual.Should().BeApproximately(result, 0.1);
        }

        [Theory]
        [InlineData(0u, 0.0)]
        [InlineData(System.Math.PI / 2, 114.59)]
        [InlineData(System.Math.PI, 171.88)]
        [InlineData(System.Math.PI * 1.5, 286.48)]
        [InlineData(System.Math.PI * 2, 343.77)]
        public void MathRadToDeg_ShouldReturnExpectedResult_ForUInt(uint number, double result)
        {
            // Arrange & Act
            var actual = number.RadToDeg();

            // Assert
            actual.Should().BeApproximately(result, 0.1);
        }
    }
}
