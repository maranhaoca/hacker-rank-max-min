using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int k = 2;
        var arr = new List<int>() { 1, 4, 7, 2 };

        var expected = 1;
        var actual = Result.maxMin(k, arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        int k = 4;
        var arr = new List<int>() { 1, 2, 3, 4, 10, 20, 30, 40, 100, 200 };

        var expected = 3;
        var actual = Result.maxMin(k, arr);

        Assert.Equal(expected, actual);
    }
}