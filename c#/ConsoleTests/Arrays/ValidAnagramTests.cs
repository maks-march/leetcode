using ConsoleTasks;
using FluentAssertions;

namespace ConsoleTests;

public class ValidAnagramTests
{
    private ValidAnagram _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ValidAnagram();
    }

    [Test]
    public void ValidAnagram_Test()
    {
        var s = "rat";
        var t = "car";
        _task.IsAnagram(s, t).Should().Be(false);
    }
}