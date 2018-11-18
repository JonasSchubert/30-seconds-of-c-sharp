using FluentAssertions;
using snippets.Array;
using Xunit;

namespace snippets.test.Array
{
    /// <summary>
    /// Unit tests for Array.All-Snippet
    /// </summary>
    public class ArrayAllUnitTest
    {
        /// <summary>
        /// Array.All Unit test for boolean, checking if all elements are false
        /// </summary>
        [Fact]
        public void ArrayAll_ForBoolean_ShouldReturnExpectedResult_ForGivenArrays()
        {
            // Arrange
            bool[] falseArray = { false, false, false };
            bool[] trueArray = { true, true, true, true, true };
            bool[] mixedArray = { true, false, true };

            bool Func(bool element) => !element;

            // Act
            var falseArrayResult = SnippetsArray.All(Func, falseArray);
            var trueArrayResult = SnippetsArray.All(Func, trueArray);
            var mixedArrayResult = SnippetsArray.All(Func, mixedArray);

            // Assert
            falseArrayResult.Should().BeTrue();
            trueArrayResult.Should().BeFalse();
            mixedArrayResult.Should().BeFalse();
        }

        /// <summary>
        /// Array.All Unit test for integer, checking if all elements are bigger 0
        /// </summary>
        [Fact]
        public void ArrayAll_ForInteger_ShouldReturnExpectedResult_ForGivenArrays()
        {
            // Arrange
            int[] positiveArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] minusArray = { -5, -4, -3 };
            int[] mixedArray = { -9, -4, -1, 0, 2, 4, 5, 7 };

            bool Func(int element) => element > 0;

            // Act
            var positiveArrayResult = SnippetsArray.All(Func, positiveArray);
            var negativeArrayResult = SnippetsArray.All(Func, minusArray);
            var mixedArrayResult = SnippetsArray.All(Func, mixedArray);

            // Assert
            positiveArrayResult.Should().BeTrue();
            negativeArrayResult.Should().BeFalse();
            mixedArrayResult.Should().BeFalse();
        }

        /// <summary>
        /// Array.All Unit test for string, checking if all elements contains 'Hello'
        /// </summary>
        [Fact]
        public void ArrayAll_ForString_ShouldReturnExpectedResult_ForGivenArrays()
        {
            // Arrange
            string[] helloArray = { "Hello World", "Hello moon", "I say 'Hello'" };
            string[] byeArray = { "Goodbye" };
            string[] mixedArray = { "Hello again", "But i say bye" };

            bool Func(string element) => element.Contains("Hello");

            // Act
            var helloArrayResult = SnippetsArray.All(Func, helloArray);
            var byeArrayResult = SnippetsArray.All(Func, byeArray);
            var mixedArrayResult = SnippetsArray.All(Func, mixedArray);

            // Assert
            helloArrayResult.Should().BeTrue();
            byeArrayResult.Should().BeFalse();
            mixedArrayResult.Should().BeFalse();
        }

        /// <summary>
        /// Array.All Unit test for class, checking if  multiplication of all elements properties are exactly dividable by 5
        /// </summary>
        [Fact]
        public void ArrayAll_ForClass_ShouldReturnExpectedResult_ForGivenArrays()
        {
            // Arrange
            TestClass[] dividableBy5Array = { new TestClass { A = 7.5, B = 2.0 }, new TestClass { A = 2.5, B = 20 }, new TestClass { A = -10.0, B = -30 } };
            TestClass[] dividableBy3Array = { new TestClass { A = 4.5, B = 2.0 }, new TestClass { A = 2.5, B = 12.0 } };
            TestClass[] mixedArray = { new TestClass { A = 4.5, B = 2.0 }, new TestClass { A = 2.5, B = 12.0 }, new TestClass { A = 2.5, B = 20 }, new TestClass { A = -10.0, B = -30 } };

            bool Func(TestClass element) => System.Math.Abs((element.A * element.B) % 5) <= 0;

            // Act
            var dividableBy5ArrayResult = SnippetsArray.All(Func, dividableBy5Array);
            var dividableBy3ArrayResult = SnippetsArray.All(Func, dividableBy3Array);
            var mixedArrayResult = SnippetsArray.All(Func, mixedArray);

            // Assert
            dividableBy5ArrayResult.Should().BeTrue();
            dividableBy3ArrayResult.Should().BeFalse();
            mixedArrayResult.Should().BeFalse();
        }

        /// <summary>
        /// TestClass for unit test ArrayAll_ForClass_ShouldReturnExpectedResult_ForGivenArrays
        /// </summary>
        private class TestClass
        {
            /// <summary>
            /// double value a
            /// </summary>
            public double A { get; set; }

            /// <summary>
            /// double value b
            /// </summary>
            public double B { get; set; }
        }
    }
}
