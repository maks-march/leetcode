using ConsoleTasks;
using FluentAssertions;

namespace ConsoleTests;

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