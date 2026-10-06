using Base75.Stack;
using FluentAssertions;

namespace RandomTasksTests.Stack;

public class ValidParenthesesTests
{
    private ValidParentheses _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [TestCase("([)]", false)]
    [TestCase("()[]{}", true)]
    [TestCase("([])", true)]
    [TestCase("](", false)]
    public void IsValid_Test(string s, bool expected)
    {
        _task.IsValid(s).Should().Be(expected);
    }
}