namespace Tests;

using FluentAssertions;
using PointWithATriangle;

public class PointWithATriangleTests
{
    [Theory]
    [InlineData(new int[] { 1, 4, 5, 6, 6, 1, 4, 5 }, true)]
    [InlineData(new int[] { 1, 4, 5, 6, 6, 1, 3, 2 }, false)]
    [InlineData(new int[] { -6, 2, -2, -2, 8, 4, 4, 2 }, true)]
    public void Test1(int[] points, bool expected)
    {
        var result = Program.WithinTriangle(points);
        result.Should().Be(expected);
    }
}