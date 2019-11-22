using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableDifferenceUnitTest
    {
        [Fact]
        public void ReturnDifference_ForListsOfInt()
        {
            // Arrange
            var list1 = new List<int>
            {
                1, 2, 3, 4, 0
            };
            var list2 = new List<int>
            {
                1, 5, 3, 4, 1
            };

            // Act
            var actual = list1.Difference(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(3);
            actual.ElementAt(0).Should().Be(2);
            actual.ElementAt(1).Should().Be(0);
            actual.ElementAt(2).Should().Be(5);
        }

        [Fact]
        public void ReturnDifference_ForArraysOfString()
        {
            // Arrange
            var array1 = new string[]
            {
                "Hello","world","organisation","seconds","of"
            };
            var array2 = new string[]
            {
                "of","organisation","GuepardoApps","Hello","of"
            };

            // Act
            var actual = array1.Difference(array2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(3);
            actual.ElementAt(0).Should().Be("world");
            actual.ElementAt(1).Should().Be("seconds");
            actual.ElementAt(2).Should().Be("GuepardoApps");
        }

        [Fact]
        public void ReturnDifference_ForListOfBoolean()
        {
            // Arrange
            var list1 = new List<bool>
            {
                false, false, false, false, false, false, false, false, false
            };
            var list2 = new List<bool>
            {
                false, false, false, true, false, false, true, false, true
            };

            // Act
            var actual = list1.Difference(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(3);
            actual.ElementAt(0).Should().Be(true);
            actual.ElementAt(1).Should().Be(true);
            actual.ElementAt(2).Should().Be(true);
        }

        [Fact]
        public void ReturnDifference_ForArrayOfComplex_DoesWorkIfExactlyTheSame()
        {
            // Arrange
            var person1 = new Person { Name = "Tina" };
            var person2 = new Person { Name = "Thomas" };
            var person3 = new Person { Name = "Annabelle" };
            var person4 = new Person { Name = "Tina" };

            var list1 = new List<Person>
            {
                person1, person2, person3, person4
            };
            var list2 = new List<Person>
            {
                person1, person2, person3, person4
            };

            // Act
            var actual = list1.Difference(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(0);
        }

        [Fact]
        public void ReturnDifference_ForArrayOfComplex_DoesNotWorkWithoutSelector()
        {
            // Arrange
            var person1 = new Person { Name = "Tina" };
            var list1 = new List<Person>
            {
                person1,
                new Person { Name = "Tina" },
                new Person { Name = "Thomas" },
                new Person { Name = "Annabelle" },
                new Person { Name = "John" },
                new Person { Name = "Richard" }
            };
            var list2 = new List<Person>
            {
                person1,
                new Person { Name = "Thomas" },
                new Person { Name = "Annabelle" },
                new Person { Name = "John" },
                new Person { Name = "Richard" }
            };

            // Act
            var actual = list1.Difference(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(9);
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array1 = null;
            var array2 = new double[]
            {
                1, 2, 3, 4, 1
            };

            // Act
            Action action = () => array1.Difference(array2);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullComparator_IsGiven()
        {
            // Arrange
            var list1 = new List<int>
            {
                1, 2, 3, 4, 1
            };

            // Act
            Action action = () => list1.Difference(null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
