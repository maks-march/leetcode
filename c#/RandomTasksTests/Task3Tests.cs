using RandomTasks;
using FluentAssertions;

namespace RandomTasksTests;

[TestFixture]
public class Task3Tests
{
    private Task3 _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new Task3();
    }
    
    [TestCase(1, 1)]
    [TestCase(123, 321)]
    [TestCase(421654321, 432426342)]
    public void AddTwoNumbers_DoSimple(int a, int b)
    {
        var aNode = ConvertToNode(a);
        var bNode = ConvertToNode(b);
        var result = _task.AddTwoNumbers(aNode, bNode);
        Console.WriteLine(ConvertToInt(result));
        result.Should().BeEquivalentTo(ConvertToNode(a+b));
    }
    
    [TestCase(123, 1)]
    [TestCase(123456, 321)]
    [TestCase(199, 1)]
    [TestCase(999, 9)]
    [TestCase(0, 432426342)]
    public void AddTwoNumbers_DifferentLength(int a, int b)
    {
        AddTwoNumbers_DoSimple(a, b);
    }
    
    [Test]
    public void ConvertToNode_DoSimple()
    {
        int num = 1234;
        ListNode result = new ListNode(4);
        result.next = new ListNode(3);
        var current = result.next;
        current.next = new ListNode(2);
        current = current.next;
        current.next = new ListNode(1);
        ConvertToNode(num).Should().BeEquivalentTo(result);
    }

    private ListNode ConvertToNode(int num)
    {
        var start = new ListNode(num % 10);
        num /= 10;
        var current = start;
        while (num > 0)
        {
            current.next = new ListNode();
            current = current.next;
            current.val = num % 10;
            num /= 10;
        }
        return start;
    }
    
    private int ConvertToInt(ListNode num)
    {
        var result = 0;
        var koef = 1;
        while (num.next != null)
        {
            result += num.val * koef;
            koef *= 10;
            num = num.next;
        }
        return result;
    }
}