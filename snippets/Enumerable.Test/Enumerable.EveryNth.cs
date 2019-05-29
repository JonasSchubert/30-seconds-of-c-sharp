using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableEveryNthUnitTest
    {
        private static readonly Person person1 = new Person { Name = "Name1" };
        private static readonly Person person2 = new Person { Name = "Name1" };

        public static readonly IEnumerable<object[]> TestMemberData = new[] {
                new object[] { new List<object> { 1u, 2u, 3u, 4u, 0u, 1u }, 4, new List<object> { 4u } },
                new object[] { new List<object> { 1, 2, 3, 4, 0 }, 1, new List<object> { 1, 2, 3, 4, 0 } },
                new object[] { new object[] { "Hello", "world", "organisation", "seconds", "of" }, 2, new object[] { "world", "seconds" } },
                new object[] { new object[] { false, true }, 3, new object[] { } },
                new object[] { new object[] { person1, person2, person1, person2, person1, person2, person1, person2 }, 5, new object[] { person1 } },
            };

        [Theory]
        [MemberData(nameof(TestMemberData))]
        public void ReturnTrue_ForListsOfInt_IfHasDuplicates(IEnumerable<object> enumerable, uint nth, IEnumerable<object> expected)
        {
            // Arrange & Act
            var actual = enumerable.EveryNth(nth);

            // Assert
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
            Action action = () => array.EveryNth(1).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullNth_IsGiven()
        {
            // Arrange
            double[] array = { 1, 2, 3, 4, 5, 6 };

            // Act
            Action action = () => array.EveryNth(0u).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
