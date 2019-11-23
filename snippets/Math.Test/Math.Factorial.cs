using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Math.Test
{
    public class MathFactorialUnitTest
    {
        [Fact]
        public void MathFactorial_ShouldReturnExpectedResult_ForGivenNumber()
        {
            // Arrange & Act
            var factorial0 = Math.Factorial(0);
            var factorial1 = Math.Factorial(1);
            var factorial2 = Math.Factorial(2);
            var factorial3 = Math.Factorial(3);
            var factorial4 = Math.Factorial(4);
            var factorial5 = Math.Factorial(5);
            var factorial6 = Math.Factorial(6);

            // Assert
            factorial0.Should().Be(1);
            factorial1.Should().Be(1);
            factorial2.Should().Be(2);
            factorial3.Should().Be(6);
            factorial4.Should().Be(24);
            factorial5.Should().Be(120);
            factorial6.Should().Be(720);
        }
    }
}
