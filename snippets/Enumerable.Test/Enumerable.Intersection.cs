using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableIntersectionUnitTest
    {
        [Fact]
        public void ReturnIntersection_ForListsOfInt()
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
            var actual = list1.Intersection(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(3);
            actual.ElementAt(0).Should().Be(1);
            actual.ElementAt(1).Should().Be(3);
            actual.ElementAt(2).Should().Be(4);
        }

        [Fact]
        public void ReturnIntersection_ForArraysOfString()
        {
            // Arrange
            var array1 = new string[]
            {
                "Hello", "world", "organisation", "seconds", "of", "Hello"
            };
            var array2 = new string[]
            {
                "of", "organisation", "GuepardoApps", "Hello", "of"
            };

            // Act
            var actual = array1.Intersection(array2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(3);
            actual.ElementAt(0).Should().Be("Hello");
            actual.ElementAt(1).Should().Be("organisation");
            actual.ElementAt(2).Should().Be("of");
        }

        [Fact]
        public void ReturnIntersection_ForListOfBoolean()
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
            var actual = list1.Intersection(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(1);
            actual.ElementAt(0).Should().BeFalse();
        }

        [Fact]
        public void ReturnIntersection_ForArrayOfComplex_DoesWorkIfExactlyTheSame()
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
            var actual = list1.Intersection(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(4);
            actual.ElementAt(0).Should().Be(person1);
            actual.ElementAt(1).Should().Be(person2);
            actual.ElementAt(2).Should().Be(person3);
            actual.ElementAt(3).Should().Be(person4);
        }

        [Fact]
        public void ReturnIntersection_ForArrayOfComplex_DoesNotWorkWithoutSelector()
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
            var actual = list1.Intersection(list2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(1);
            actual.ElementAt(0).Should().Be(person1);
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
            Action action = () => array1.Intersection(array2);

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
            Action action = () => list1.Intersection(null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
