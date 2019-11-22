using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableCountByUnitTest
    {
        [Fact]
        public void ShouldReturnExpectedDictionary_ForListOfInt()
        {
            // Arrange
            var enumerable = new List<int> { 1, 2, 3, 2, 1 };
            var expected = new Dictionary<int, uint> { { 1, 2u }, { 2, 2u }, { 3, 1u } };

            // Act
            var actual = enumerable.CountBy();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Key.Should().Be(expected.First().Key);
                actual.First().Value.Should().Be(expected.First().Value);
                actual.Last().Key.Should().Be(expected.Last().Key);
                actual.Last().Value.Should().Be(expected.Last().Value);
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfBool()
        {
            // Arrange
            var enumerable = new bool[] { false, false, true, true };
            var expected = new Dictionary<bool, uint> { { false, 2u }, { true, 2u } };

            // Act
            var actual = enumerable.CountBy();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Key.Should().Be(expected.First().Key);
                actual.First().Value.Should().Be(expected.First().Value);
                actual.Last().Key.Should().Be(expected.Last().Key);
                actual.Last().Value.Should().Be(expected.Last().Value);
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfString()
        {
            // Arrange
            var enumerable = new string[] { "Hello", "Hello", "Hello", "World", "Hello", "", string.Empty };
            var expected = new Dictionary<string, uint> { { "Hello", 4u }, { "World", 1u }, { "", 2u } };

            // Act
            var actual = enumerable.CountBy();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Key.Should().Be(expected.First().Key);
                actual.First().Value.Should().Be(expected.First().Value);
                actual.Last().Key.Should().Be(expected.Last().Key);
                actual.Last().Value.Should().Be(expected.Last().Value);
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfObject()
        {
            // Arrange
            var object1 = new object();
            var object2 = new object();
            var object3 = new object();
            var enumerable = new List<object> { object1, object2, object3 };
            var expected = new Dictionary<object, uint> { { object1, 1u }, { object2, 1u }, { object3, 1u } };

            // Act
            var actual = enumerable.CountBy();

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Key.Should().Be(expected.First().Key);
                actual.First().Value.Should().Be(expected.First().Value);
                actual.Last().Key.Should().Be(expected.Last().Key);
                actual.Last().Value.Should().Be(expected.Last().Value);
            }
        }

        [Fact]
        public void ShouldThrowArgumentNullException_WhenOneValue_IsNull()
        {
            // Arrange
            var enumerable = new List<object> { new object(), new object(), null };

            // Act
            Action action = () => enumerable.CountBy();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowArgumentNullException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> enumerable = null;

            // Act
            Action action = () => enumerable.CountBy();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
