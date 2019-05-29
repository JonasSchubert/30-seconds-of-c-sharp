using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableFilterNonUniqueWhereUnitTest
    {
        private static readonly Person person1 = new Person { Name = "Name1" };
        private static readonly Person person2 = new Person { Name = "Name1" };

        public static readonly IEnumerable<object[]> TestMemberData = new[] {
                new object[] { new List<object> { null, 1u, 2u, 3u, 4u, 0u, 1u }, new List<object> { 2u, 3u, 4u, 0u } },
                new object[] { new List<object> { 1, 2, 3, null, 4, 0 }, new List<object> { 1, 2, 3, 4, 0 } },
                new object[] { new object[] { "Hello", null, "world", "organisation", "seconds", "of", "organisation" }, new object[] { "Hello", "world", "seconds", "of" } },
                new object[] { new object[] { false, true, null, false }, new object[] { true } },
                new object[] { new object[] { person1, null, person1, person2, person2 }, new object[] { } },
            };

        [Theory]
        [MemberData(nameof(TestMemberData))]
        public void ReturnExpectedEnumerable(IEnumerable<object> enumerable, IEnumerable<object> expected)
        {
            // Arrange & Act
            var actual = enumerable.FilterNonUniqueWhere(x => x != null);

            // Assert
            actual.Count().Should().Be(expected.Count());
            for (var index = 0; index < actual.Count(); index++)
            {
                actual.ElementAt(index).Should().Be(expected.ElementAt(index));
            }
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array = null;

            // Act
            Action action = () => array.FilterNonUniqueWhere(x => x == 0).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullWhereFunction_IsGiven()
        {
            // Arrange
            var list = new List<uint> { 1, 2, 3, 4 };

            // Act
            Action action = () => list.FilterNonUniqueWhere(null).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
