using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Date.Test
{
    public class DateFormatDurationUnitTest
    {
        [Theory]
        [InlineData(0ul, "0 millisecond")]
        [InlineData(1001ul, "1 second, 1 millisecond")]
        [InlineData(7200000ul, "2 hours")]
        [InlineData(34325055574ul, "56 weeks, 5 days, 6 hours, 44 minutes, 15 seconds, 574 milliseconds")]
        [InlineData(0x0001D8e864DD, "13 weeks, 19 hours, 54 minutes, 36 seconds, 125 milliseconds")]
        [InlineData(0b0001_1111_1001_1110_1000_0110_0100_1101_1101, "14 weeks, 5 hours, 42 minutes, 4 seconds, 253 milliseconds")]
        public void FormatDuration_ShouldReturnExpectedResults(ulong milliseconds, string expected)
        {
            // Arrange + Act
            var actual = Date.FormatDuration(milliseconds);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
