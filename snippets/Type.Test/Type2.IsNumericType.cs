using System;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Type2.Test
{
    public class TypeIsNumericTypeUnitTest
    {
        [Theory]
        [InlineData(typeof(byte), true)]
        [InlineData(typeof(sbyte), true)]
        [InlineData(typeof(int), true)]
        [InlineData(typeof(uint), true)]
        [InlineData(typeof(short), true)]
        [InlineData(typeof(ushort), true)]
        [InlineData(typeof(decimal), true)]
        [InlineData(typeof(double), true)]
        [InlineData(typeof(float), true)]
        [InlineData(typeof(bool), false)]
        [InlineData(typeof(string), false)]
        [InlineData(typeof(int[]), false)]
        [InlineData(typeof(double[]), false)]
        public void ShouldReturnExpected(Type type, bool expected)
        {
            // Arrange & Act
            var actual = type.IsNumericType();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
