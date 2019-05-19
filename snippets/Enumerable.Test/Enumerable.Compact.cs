using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableCompactUnitTest
    {
        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfString()
        {
            // Arrange
            var enumerable = new string[] { "Hello", "This", "Is", "Conplement", string.Empty, "Awesome", "", null };
            var expected = new string[] { "Hello", "This", "Is", "Conplement", "Awesome" };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Length > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfBool()
        {
            // Arrange
            var enumerable = new bool[] { false, false, true, true };
            var expected = new bool[] { true, true };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Length > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfByte()
        {
            // Arrange
            var enumerable = new List<byte> { 0, 1, 1, 2, 0, 7 };
            var expected = new List<byte> { 1, 1, 2, 7 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfSByte()
        {
            // Arrange
            var enumerable = new List<sbyte> { 0, 1, 1, 2, 0, 7 };
            var expected = new List<sbyte> { 1, 1, 2, 7 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfShort()
        {
            // Arrange
            var enumerable = new List<short> { -1, 0, 1, -2, -0, 7 };
            var expected = new List<short> { -1, 1, -2, 7 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfUShort()
        {
            // Arrange
            var enumerable = new List<ushort> { 1, 0, 1, 2, -0, 7 };
            var expected = new List<ushort> { 1, 1, 2, 7 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfInt()
        {
            // Arrange
            var enumerable = new List<int> { 0, 4, -5, 0, -0 };
            var expected = new List<int> { 4, -5 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfUInt()
        {
            // Arrange
            var enumerable = new List<uint> { 0, 4, 5, 0, 0 };
            var expected = new List<uint> { 4, 5 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfLong()
        {
            // Arrange
            var enumerable = new List<long> { 0, 4, -5, 0, -0 };
            var expected = new List<long> { 4, -5 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfULong()
        {
            // Arrange
            var enumerable = new List<ulong> { 0, 4, 5, 0, -0 };
            var expected = new List<ulong> { 4, 5 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfFloat()
        {
            // Arrange
            var enumerable = new List<float> { 0, 4, -5.125f, 0.000000001f, -0.0000000000f };
            var expected = new List<float> { 4, -5.125f, 0.000000001f };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfDouble()
        {
            // Arrange
            var enumerable = new List<double> { 0, 4, -5.125, 0.000000001, -0.0000000000 };
            var expected = new List<double> { 4, -5.125, 0.000000001 };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfDecimal()
        {
            // Arrange
            var enumerable = new List<decimal> { 0, 4, -5.125m, 0.000000001m, -0.0000000000m };
            var expected = new List<decimal> { 4, -5.125m, 0.000000001m };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfObject()
        {
            // Arrange
            var enumerable = new List<object> { new object(), null, new object(), new object(), null };
            var expected = new List<object> { new object(), new object(), new object() };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfMixes()
        {
            // Arrange
            var enumerable = new List<object> { new object(), null, new object(), new object(), null, false, true, 1, 0, "Hello", "", "World" };
            var expected = new List<object> { new object(), new object(), new object(), true, 1, "Hello", "World" };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForEmptyEnumerable()
        {
            // Arrange
            var enumerable = new List<object> { };
            var expected = new List<object> { };

            // Act
            var actual = enumerable.Compact();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
        }

        [Fact]
        public void ShouldThrowArgumentNullException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> list = null;

            // Act
            Action action = () => list.Compact().ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
