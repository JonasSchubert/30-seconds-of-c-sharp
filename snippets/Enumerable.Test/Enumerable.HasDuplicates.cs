using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableHasDuplicatesUnitTest
    {
        private static readonly Person person1 = new Person { Name = "Name1" };
        private static readonly Person person2 = new Person { Name = "Name1" };

        public static readonly IEnumerable<object[]> TestMemberData = new[] {
                new object[] { new List<object> { 1u, 2u, 3u, 4u, 0u, 1u }, true },
                new object[] { new List<object> { 1, 2, 3, 4, 0 }, false },
                new object[] { new object[] { "Hello", "world", "organisation", "seconds", "of" }, false },
                new object[] { new object[] { "Hello", "world", "organisation", "seconds", "of", "organisation" }, true },
                new object[] { new object[] { false, true }, false },
                new object[] { new List<object> { false, false }, true },
                new object[] { new object[] { person1, person1 }, true },
                new object[] { new object[] { person1, person2 }, false },
            };

        [Theory]
        [MemberData(nameof(TestMemberData))]
        public void ReturnTrue_ForListsOfInt_IfHasDuplicates(IEnumerable<object> enumerable, bool expected)
        {
            // Arrange & Act
            var actual = enumerable.HasDuplicates();

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array = null;

            // Act
            Action action = () => array.HasDuplicates();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
