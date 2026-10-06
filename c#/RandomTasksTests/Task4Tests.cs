using RandomTasks;
using FluentAssertions;

namespace RandomTasksTests;

[TestFixture]
public class Task4Tests
{
    private Task4 _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new Task4();
    }
    private static object[] TestCases = new object[]
    {
        new object[] { new [] { "10", "11" }, new []{ "00", "01" } },
        new object[] { new [] { "00", "01" }, new []{ "10", "11" } },
        new object[] { new [] { "110", "101", "100" }, new []{ "000", "001", "010", "011", "111"}  }
    };
    
    [TestCaseSource(nameof(TestCases))]
    public void FindDifferentBinaryString_DoSimple(string[] nums, string[] expected)
    {
        var result = _task.FindDifferentBinaryString(nums);
        result.Should().BeOneOf(expected);
    }
}