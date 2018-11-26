using FluentAssertions;
using System;
using Xunit;

namespace Conplement.Snippets.Method.Test
{
    public class MethodTimesUnitTest
    {
        [Fact]
        public void MethodTimes_ShouldCallMethod_ExpectedTimes()
        {
            // Arrange
            bool BoolFunc() => true;
            int IntFunc(int start, int end) => new Random().Next(start, end);

            // Act
            var boolFuncResult = Method.Times(BoolFunc, 5);
            var intFuncResult = Method.Times(IntFunc, 3, 0, 100);

            // Assert
            boolFuncResult.Count.Should().Be(5);
            intFuncResult.Count.Should().Be(3);
        }
    }
}
