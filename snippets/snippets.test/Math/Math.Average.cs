using FluentAssertions;
using snippets.Math;
using Xunit;

namespace snippets.test.Math
{
    /// <summary>
    /// Unit tests for Math.Average-Snippet
    /// </summary>
    public class MathAverageUnitTest
    {
        /// <summary>
        /// Math.Average Unit test
        /// </summary>
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
            var decimalArrayResult = SnippetsMath.Average(decimalArray);
            var doubleArrayResult = SnippetsMath.Average(doubleArray);
            var floatArrayResult = SnippetsMath.Average(floatArray);
            var intArrayResult = SnippetsMath.Average(intArray);
            var uintArrayResult = SnippetsMath.Average(uintArray);

            // Assert
            decimalArrayResult.Should().Be(2);
            doubleArrayResult.Should().Be(1.9);
            floatArrayResult.Should().Be(0);
            intArrayResult.Should().Be(2.2);
            uintArrayResult.Should().Be(3.8);
        }
    }
}
