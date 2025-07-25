namespace Tests;

using FluentAssertions;
using MaxieAndMinnie;

public class MaxieAndMinnieTests
{
    [Theory]
    [InlineData(12340, new long[] { 42310, 10342 })]
    [InlineData(98761, new long[] { 98761, 18769 })]
    [InlineData(9000, new long[] { 9000, 9000 })]
    [InlineData(11321, new long[] { 31121, 11123 })]
    public void TestMaxieAndMinnie(long num, long[] expected)
    {
        var result = Program.MaxieAndMinnie(num);
        result.Should().BeEquivalentTo(expected);
    }
}
