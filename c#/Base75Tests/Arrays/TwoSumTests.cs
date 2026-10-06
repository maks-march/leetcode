using Base75;
using FluentAssertions;

namespace RandomTasksTests;

public class TwoSumTests
{
    private TwoSumTask _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new TwoSumTask();
    }

    [Test]
    public void TwoSum_Test()
    {
        var nums = new[] { -3,4,3,90 };
        _task.TwoSum(nums, 0);
    }
}