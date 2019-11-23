using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Math.Test
{
    public class MathDegToRadUnitTest
    {
        [Theory]
        [InlineData(0, 0.0)]
        [InlineData(90, System.Math.PI / 2)]
        [InlineData(180, System.Math.PI)]
        [InlineData(270, System.Math.PI * 1.5)]
        [InlineData(-360, System.Math.PI * -2)]
        public void MathDegToRad_ShouldReturnExpectedResult_ForDecimal(decimal number, double result)
        {
            // Arrange & Act
            var actual = number.DegToRad();

            // Assert
            actual.Should().Be(result);
        }

        [Theory]
        [InlineData(0.0, 0.0)]
        [InlineData(90.0, System.Math.PI / 2)]
        [InlineData(180.0, System.Math.PI)]
        [InlineData(270.0, System.Math.PI * 1.5)]
        [InlineData(-360.0, System.Math.PI * -2)]
        public void MathDegToRad_ShouldReturnExpectedResult_ForDouble(double number, double result)
        {
            // Arrange & Act
            var actual = number.DegToRad();

            // Assert
            actual.Should().Be(result);
        }

        [Theory]
        [InlineData(0.0f, 0.0)]
        [InlineData(90.0f, System.Math.PI / 2)]
        [InlineData(180.0f, System.Math.PI)]
        [InlineData(270.0f, System.Math.PI * 1.5)]
        [InlineData(-360.0f, System.Math.PI * -2)]
        public void MathDegToRad_ShouldReturnExpectedResult_ForFloat(float number, double result)
        {
            // Arrange & Act
            var actual = number.DegToRad();

            // Assert
            actual.Should().Be(result);
        }

        [Theory]
        [InlineData(0, 0.0)]
        [InlineData(90, System.Math.PI / 2)]
        [InlineData(180, System.Math.PI)]
        [InlineData(270, System.Math.PI * 1.5)]
        [InlineData(-360, System.Math.PI * -2)]
        public void MathDegToRad_ShouldReturnExpectedResult_ForInt(int number, double result)
        {
            // Arrange & Act
            var actual = number.DegToRad();

            // Assert
            actual.Should().Be(result);
        }

        [Theory]
        [InlineData(0u, 0.0)]
        [InlineData(90u, System.Math.PI / 2)]
        [InlineData(180u, System.Math.PI)]
        [InlineData(270u, System.Math.PI * 1.5)]
        [InlineData(360u, System.Math.PI * 2)]
        public void MathDegToRad_ShouldReturnExpectedResult_ForUInt(uint number, double result)
        {
            // Arrange & Act
            var actual = number.DegToRad();

            // Assert
            actual.Should().Be(result);
        }
    }
}
