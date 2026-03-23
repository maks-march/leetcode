using System.Collections;
using ConsoleTasks.LinkedList;
using FluentAssertions;

namespace ConsoleTests.LinkedListTests;

public class ReverseLinkedListTests
{
    private ReverseLinkedList _task;
    private ListNode _head;
    private List<int> _expected;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
        _expected = new List<int>(Enumerable.Range(1, 10).Reverse());
        _head = new(10);
        for (int i = 9; i > 0; i--)
        {
            _head = new(i, _head);
        }
    }

    [Test]
    public void ReverseList_Test()
    {
        var res = _task.ReverseList(_head);
        res.FromLinked().Should().BeEquivalentTo(_expected);
    }

    
}