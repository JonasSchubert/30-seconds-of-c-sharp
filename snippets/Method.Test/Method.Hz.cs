using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace Conplement.Snippets.Method.Test
{
    public class MethodHzUnitTest
    {
        [Fact]
        public void MethodHz_ShouldCallMethod_ExpectedTimes()
        {
            // Arrange
            void helloWorldAction() => Console.WriteLine("Hello world action example");
            int randomInt() => new Random().Next(0, 1000000);
            char[] charArrayFunc(string test) => test.ToCharArray().Select(x => (char)(x * 2)).Where(x => x > 0).ToArray();
            double doubleFunc(double a, double b) => a == 0 ? (((a * b) - (a + ++b)) * --a) / 1 : (((a * b) - (a + ++b)) * --a) / a;

            // Act
            var helloWorldActionResult = Method.Hz(helloWorldAction);
            var randomIntResult = Method.Hz(randomInt);
            var charArrayFuncResult = Method.Hz(charArrayFunc, "Hello world char array example");
            var doubleFuncResult = Method.Hz(doubleFunc, 1234567.0, 321.0, 1000000);

            // Assert
            helloWorldActionResult.Should().BePositive();
            randomIntResult.Should().BePositive();
            charArrayFuncResult.Should().BePositive();
            doubleFuncResult.Should().BePositive();
        }
    }
}
