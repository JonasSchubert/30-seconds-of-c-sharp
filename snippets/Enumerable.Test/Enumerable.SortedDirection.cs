using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableSortedDirectionUnitTest
    {
        public struct TestStruct : IComparable
        {
            public sbyte Byte { get; set; }

            public int CompareTo(object obj)
            {
                return (obj is TestStruct)
                    ? Byte > (obj as TestStruct?)?.Byte
                        ? 1
                        : Byte < (obj as TestStruct?)?.Byte
                            ? -1
                            : 0
                    : throw new ArgumentException(obj.ToString());
            }

            public override string ToString() => $"Byte: {Byte}";
        }

        [Fact]
        public void ShouldReturnAscending_ForAscendingIntegerList()
        {
            // Arrange
            var list = new List<uint> { 1, 2, 3, 4, 5 };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.Ascending);
        }

        [Fact]
        public void ShouldReturnDescending_ForDescendingFloatList()
        {
            // Arrange
            var list = new List<float> { 5.0f, 4.99f, 3.1f, 1.4f, 0.5f };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.Descending);
        }

        [Fact]
        public void ShouldReturnNotSorted_ForNotSortedDecimalArray()
        {
            // Arrange
            var list = new decimal[] { 10, 20, 14 };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.NotSorted);
        }

        [Fact]
        public void ShouldReturnAscending_ForAscendingStringArray()
        {
            // Arrange
            var list = new string[] { "A", "B", "C" };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.Ascending);
        }

        [Fact]
        public void ShouldReturnDescending_ForDescendingBoolList()
        {
            // Arrange
            var list = new List<bool> { true, false };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.Descending);
        }

        [Fact]
        public void ShouldReturnNotSorted_ForListWithNoEntry()
        {
            // Arrange
            var list = new List<bool> { };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.NotSorted);
        }

        [Fact]
        public void ShouldReturnNotSorted_ForArrayWithOneEntry()
        {
            // Arrange
            var list = new object[] { new object() };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.NotSorted);
        }

        [Fact]
        public void ShouldWork_ForTestStructList()
        {
            // Arrange
            var list = new List<TestStruct>() { new TestStruct { Byte = 1 }, new TestStruct { Byte = 1 }, new TestStruct { Byte = 0 } };

            // Act
            var actual = list.SortedDirection();

            // Assert
            actual.Should().Be(Direction.Descending);
        }
    }
}
