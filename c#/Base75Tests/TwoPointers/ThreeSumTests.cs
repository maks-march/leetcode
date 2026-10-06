using Base75;
using FluentAssertions;

namespace RandomTasksTests;

public class ThreeSumTests
{
    private ThreeSumTask _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [Test]
    public void ThreeSum_Test()
    {
        var nums = new[] { -1,0,1,2,-1,-4 };
        int[][] result = [[-1, -1, 2], [1, 0, -1]];
        _task.ThreeSum(nums).Should().BeEquivalentTo(result);
    }
    
    [Test]
    public void ThreeSum_MinimumElements_Test()
    {
        var nums = new[] { 0, 1, 1 };
        int[][] result = [];
        _task.ThreeSum(nums).Should().BeEquivalentTo(result);
    }
    
    [Test]
    public void ThreeSum_Zeros_Test()
    {
        var nums = new[] { 1,2,0,1,0,0,0,0 };
        int[][] result = [[0,0,0]];
        _task.ThreeSum(nums).Should().BeEquivalentTo(result);
    }
}