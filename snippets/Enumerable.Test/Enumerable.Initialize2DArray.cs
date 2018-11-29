using System;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableInitialize2DArrayUnitTest
    {
        [Fact]
        public void ShouldReturnTheExpectedArray()
        {
            // Arrange
            var expected = new int[2, 2] { { 0, 0 }, { 0, 0 } };

            // Act
            var actual = Enumerable.Initialize2DArray(2, 2, 0);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ShouldThrowArgumentException_IfWidthIs0()
        {
            // Act
            Action action = () => Enumerable.Initialize2DArray<string>(0, 1);

            // Assert
            action.Should().Throw<ArgumentException>("Minimum width has to be 1", "width");
        }

        [Fact]
        public void ShouldThrowArgumentException_IfHeightIs0()
        {
            // Act
            Action action = () => Enumerable.Initialize2DArray<double>(1, 0);

            // Assert
            action.Should().Throw<ArgumentException>("Minimum height has to be 1", "height");
        }

        [Fact]
        public void ShouldWorkForComplexTypes_IfProvided()
        {
            // Arrange
            var person = new Person
            {
                Name = "Herbert",
                Address = new Address
                {
                    Street = "Herbertstraﬂe 5a"
                }
            };
            var expected = new[,] { { person, person }, { person, person } };

            // Act
            var actual = Enumerable.Initialize2DArray(2, 2, person);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ShouldWorkForComplexTypes_IfNotProvided()
        {
            // Arrange
            var expected = new[,] { { default(Person), default(Person) }, { default(Person), default(Person) } };

            // Act
            var actual = Enumerable.Initialize2DArray<Person>(2, 2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        private class Person
        {
            public Address Address { get; set; }

            public string Name { get; set; }
        }

        private class Address
        {
            public string Street { get; set; }
        }
    }
}
