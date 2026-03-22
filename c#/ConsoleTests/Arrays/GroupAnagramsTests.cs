using ConsoleTasks;
using FluentAssertions;

namespace ConsoleTests;

public class GroupAnagramsTests
{
    private GroupAnagramsTask _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new GroupAnagramsTask();
    }

    [Test]
    public void GroupAnagrams_Test()
    {
        var strs = new[] { "eat","tea","tan","ate","nat","bat" };
        _task.GroupAnagrams(strs);
    }
}