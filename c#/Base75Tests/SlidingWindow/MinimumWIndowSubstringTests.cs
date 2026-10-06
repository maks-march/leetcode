using Base75;
using Base75.SlidingWindow;
using FluentAssertions;

namespace RandomTasksTests;

public class MinimumWindowSubstringTests
{
    private MinimumWindowSubstring _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [TestCase("ADOBECODEBANC", "ABC", "BANC")]
    [TestCase("a", "a", "a")]
    [TestCase("a", "aa", "")]
    [TestCase("ab", "a", "a")]
    [TestCase("ab", "b", "b")]
    [TestCase("aa", "aa", "aa")]
    [TestCase("abc", "b", "b")]
    public void LengthOfLongestSubstring_Test(string s, string t, string expected)
    {
        _task.MinWindow(s, t).Should().Be(expected);
    }
}