using FluentAssertions;
using System;
using Xunit;

namespace Conplement.Snippets.Utility.Test
{
    public class UtilityTimeTakenUnitTest
    {
        [Fact]
        public void TimeTaken_ShouldReturnExpectedResult_ForGivenFunctions()
        {
            // Arrange
            bool BoolFunc() => true;
            int RandomFunc(int start, int end) => new Random().Next(start, end);

            // Act
            var boolFuncResult = Utility.TimeTaken(BoolFunc);
            var randomFuncResult = Utility.TimeTaken(RandomFunc, 0, 1000);

            // Assert
            boolFuncResult.Item1.Should().BeGreaterOrEqualTo(0);
            boolFuncResult.Item2.Should().BeTrue();
            randomFuncResult.Item1.Should().BeGreaterOrEqualTo(0);
            randomFuncResult.Item2.Should().BeInRange(0, 1000);
        }
    }
}
