using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Utility.Test
{
    public class UtilityPrettyBytesUnitTest
    {
        [Theory]
        [InlineData(0ul, "0 B")]
        [InlineData(1001ul, "1 KB, 1 B")]
        [InlineData(1001001ul, "1 MB, 1 KB, 1 B")]
        [InlineData(1001001001ul, "1 GB, 1 MB, 1 KB, 1 B")]
        [InlineData(1001001001001ul, "1 TB, 1 GB, 1 MB, 1 KB, 1 B")]
        [InlineData(1001001001001001ul, "1 PB, 1 TB, 1 GB, 1 MB, 1 KB, 1 B")]
        [InlineData(20ul, "20 Bs")]
        [InlineData(20000ul, "20 KBs")]
        [InlineData(20000000ul, "20 MBs")]
        [InlineData(20000000000ul, "20 GBs")]
        [InlineData(20000000000000ul, "20 TBs")]
        [InlineData(20000000000000000ul, "20 PBs")]
        public void PrettyBytes_ShouldReturnExpectedResults(ulong bytes, string expected)
        {
            // Arrange + Act
            var actual = Utility.PrettyBytes(bytes);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
