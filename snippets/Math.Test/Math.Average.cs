using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Math.Test
{
    public class MathAverageUnitTest
    {
        [Fact]
        public void MathAverage_ShouldReturnExpectedResult_ForGivenArrays()
        {
            // Arrange
            decimal[] decimalArray = { -3, 4, 10, -3 };
            double[] doubleArray = { 2.5, -1.5, 3, 0.5, 5 };
            float[] floatArray = { 1f, 3.5f, -4.5f };
            int[] intArray = { -4, 5, 9, 1, 0 };
            uint[] uintArray = { 4, 5, 9, 1, 0 };

            // Act
            var decimalArrayResult = decimalArray.Average();
            var doubleArrayResult = doubleArray.Average();
            var floatArrayResult = floatArray.Average();
            var intArrayResult = intArray.Average();
            var uintArrayResult = uintArray.Average();

            // Assert
            decimalArrayResult.Should().Be(2);
            doubleArrayResult.Should().Be(1.9);
            floatArrayResult.Should().Be(0);
            intArrayResult.Should().Be(2.2);
            uintArrayResult.Should().Be(3.8);
        }
    }
}
