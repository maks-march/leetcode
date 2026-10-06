using Base75.BinarySearch;
using FluentAssertions;

namespace RandomTasksTests;

public class SearchInRotatedTests
{
    private SearchInRotated _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [TestCase(new []{ 3, 4, 5, 6, 0, 1, 2 }, 5,2)]
    [TestCase(new []{ 4,5,6,7,0,1,2 }, 0,4)]
    [TestCase(new []{ 1 }, 1,0)]
    [TestCase(new []{ 1, 3 }, 0,-1)]
    [TestCase(new []{ 1, 3 }, 1,0)]
    [TestCase(new []{ 1, 3, 5 }, 3,1)]
    [TestCase(new []{ 5, 1, 3 }, 3,2)]
    [TestCase(new []{ 4, 5, 6, 7, 8, 1, 2, 3 }, 8,4)]
    [TestCase(new []{ 5,1,2,3,4 }, 1,1)]
    [TestCase(new []{ 8,9,2,3,4 }, 9,1)]
    public void Search_Test(int[] nums, int target, int expected)
    {
        _task.Search(nums, target).Should().Be(expected);
    }
}