using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableToCsvUnitTest
    {
        public struct TestStruct
        {
            public sbyte Byte { get; set; }

            public override string ToString() => $"Byte: {Byte}";
        }

        [Fact]
        public void ShouldReturnExpected_ForListOfListsOfBoolean()
        {
            // Arrange
            var list = new List<List<bool>> { new List<bool> { true, true }, new List<bool> { true, false } };

            // Act
            var actual1 = list.ToCsv();
            var actual2 = list.ToCsv("-");

            // Assert
            actual1.Should().Be("True,True\nTrue,False");
            actual2.Should().Be("True-True\nTrue-False");
        }

        [Fact]
        public void ShouldReturnExpected_ForListOfListsOfInteger()
        {
            // Arrange
            var list = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 } };

            // Act
            var actual1 = list.ToCsv();
            var actual2 = list.ToCsv("-");

            // Assert
            actual1.Should().Be("1,2,3\n4,5,6");
            actual2.Should().Be("1-2-3\n4-5-6");
        }

        [Fact]
        public void ShouldReturnExpected_ForListOfListsOfDouble()
        {
            // Arrange
            var array = new double[][] { new double[] { 1.1, 2.2, 3.3 }, new double[] { 4.4, 5.5, 6.6 } };

            // Act
            var actual1 = array.ToCsv();
            var actual2 = array.ToCsv("-");

            // Assert
            actual1.Should().Be("1.1,2.2,3.3\n4.4,5.5,6.6");
            actual2.Should().Be("1.1-2.2-3.3\n4.4-5.5-6.6");
        }

        [Fact]
        public void ShouldReturnExpected_ForListOfListsOfFloat()
        {
            // Arrange
            var array = new float[][] { new float[] { 1.1f, 2.2f, 3.3f }, new float[] { 4.4f, 5.5f, 6.6f }, new float[] { 7.7f, 8.8f, 9.9f } };

            // Act
            var actual1 = array.ToCsv();
            var actual2 = array.ToCsv("-");

            // Assert
            actual1.Should().Be("1.1,2.2,3.3\n4.4,5.5,6.6\n7.7,8.8,9.9");
            actual2.Should().Be("1.1-2.2-3.3\n4.4-5.5-6.6\n7.7-8.8-9.9");
        }

        [Fact]
        public void ShouldReturnExpected_ForListOfListsOfString()
        {
            // Arrange
            var array = new string[][] { new string[] { "Hello", "World" }, new string[] { "Jonas", "Schubert" } };

            // Act
            var actual1 = array.ToCsv();
            var actual2 = array.ToCsv("-");

            // Assert
            actual1.Should().Be("Hello,World\nJonas,Schubert");
            actual2.Should().Be("Hello-World\nJonas-Schubert");
        }

        [Fact]
        public void ShouldReturnExpected_ForListOfListsOfTestStruct_WithToStringMethod()
        {
            // Arrange
            var array = new List<List<TestStruct>> { new List<TestStruct> { new TestStruct { Byte = 0 } }, new List<TestStruct> { new TestStruct { Byte = 1 }, new TestStruct { Byte = 2 } } };

            // Act
            var actual1 = array.ToCsv();
            var actual2 = array.ToCsv("-");

            // Assert
            actual1.Should().Be("Byte: 0\nByte: 1,Byte: 2");
            actual2.Should().Be("Byte: 0\nByte: 1-Byte: 2");
        }
    }
}
