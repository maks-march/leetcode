using ConsoleTasks;
using FluentAssertions;

namespace ConsoleTests;

public class LongestConsecutiveSequenceTests
{
    private LongestConsecutiveSequence _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [Test]
    public void LongestConsecutive_Test()
    {
        var nums = new[] { 0,3,7,2,5,8,4,6,0,1 };
        _task.LongestConsecutive(nums).Should().Be(9);
    }
}