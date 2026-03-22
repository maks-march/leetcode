using ConsoleTasks;
using ConsoleTasks.SlidingWindow;
using FluentAssertions;

namespace ConsoleTests;

public class LongestSubstringNoRepeatTest
{
    private LongestSubstringNoRepeat _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [TestCase("abcabcbb", 3)]
    [TestCase("dvdf", 3)]
    public void LengthOfLongestSubstring_Test(string str, int expected)
    {
        _task.LengthOfLongestSubstring(str).Should().Be(expected);
    }
    
    [Test]
    public void LengthOfLongestSubstring_AllRepeats_Test()
    {
        var str = "bbbbbbbbbbbbb";
        _task.LengthOfLongestSubstring(str).Should().Be(1);
    }
    
    [Test]
    public void LengthOfLongestSubstring_Empty_Test()
    {
        var str = "";
        _task.LengthOfLongestSubstring(str).Should().Be(0);
    }
}