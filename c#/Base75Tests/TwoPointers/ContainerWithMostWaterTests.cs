using Base75;
using FluentAssertions;

namespace RandomTasksTests;

public class ContainerWithMostWaterTests
{
    private ContainerWithMostWater _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [Test]
    public void MaxArea_Test()
    {
        var nums = new[] { 1,8,6,2,5,4,8,3,7 };
        _task.MaxArea(nums).Should().Be(49);
    }
    
    [Test]
    public void ThreeSum_MinimumElements_Test()
    {
        var nums = new[] { 1, 1 };
        _task.MaxArea(nums).Should().Be(1);
    }
}