using Base75.BinarySearch;
using FluentAssertions;

namespace RandomTasksTests;

public class FindMinimumInRotatedTests
{
    private FindMinimumInRotated _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [TestCase(new []{ 3, 4, 5, 6, 0, 1, 2 }, 0)]
    [TestCase(new []{ 6, 7, 9, 10, 11, 1, 2, 3, 4, 5 }, 1)]
    [TestCase(new []{ 11, 13, 15, 17 }, 11)]
    [TestCase(new []{ 1 }, 1)]
    [TestCase(new []{ 1, 2 }, 1)]
    [TestCase(new []{ 2, 1 }, 1)]
    public void FindMin_Test(int[] str, int expected)
    {
        _task.FindMin(str).Should().Be(expected);
    }
}