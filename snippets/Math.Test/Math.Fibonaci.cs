using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace JonasSchubert.Snippets.Math.Test
{
    public class MathFibonaciUnitTest
    {
        [Fact]
        public void MathFibonaci_ShouldReturnExpectedResult_ForGivenLength()
        {
            // Arrange & Act
            var fibonaci0 = Math.Fibonaci(0);
            var fibonaci1 = Math.Fibonaci(1);
            var fibonaci2 = Math.Fibonaci(2);
            var fibonaci3 = Math.Fibonaci(3);
            var fibonaci4 = Math.Fibonaci(4);
            var fibonaci5 = Math.Fibonaci(5);
            var fibonaci6 = Math.Fibonaci(6);
            var fibonaci7 = Math.Fibonaci(7);

            // Assert
            fibonaci0.Should().HaveCount(0);
            fibonaci0.Should().BeEquivalentTo(new List<int>());
            fibonaci1.Should().HaveCount(1);
            fibonaci1.Should().BeEquivalentTo(new List<int>() { 0 });
            fibonaci2.Should().HaveCount(2);
            fibonaci2.Should().BeEquivalentTo(new List<int>() { 0, 1 });
            fibonaci3.Should().HaveCount(3);
            fibonaci3.Should().BeEquivalentTo(new List<int>() { 0, 1, 1 });
            fibonaci4.Should().HaveCount(4);
            fibonaci4.Should().BeEquivalentTo(new List<int>() { 0, 1, 1, 2 });
            fibonaci5.Should().HaveCount(5);
            fibonaci5.Should().BeEquivalentTo(new List<int>() { 0, 1, 1, 2, 3 });
            fibonaci6.Should().HaveCount(6);
            fibonaci6.Should().BeEquivalentTo(new List<int>() { 0, 1, 1, 2, 3, 5 });
            fibonaci7.Should().HaveCount(7);
            fibonaci7.Should().BeEquivalentTo(new List<int>() { 0, 1, 1, 2, 3, 5, 8 });
        }
    }
}
