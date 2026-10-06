using System.Collections;
using Base75.LinkedList;
using FluentAssertions;

namespace RandomTasksTests.LinkedListTests;

public class ReorderLinkedListTests
{
    private ReorderLinkedList _task;
    private ListNode _head;
    private List<int> _expected;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
        _expected = new() {0, 3, 1, 2};
        _head = ListNode.FromList(new(){0,1,2,3});
    }

    [Test]
    public void ReorderList_Test()
    {
        _task.ReorderList(_head);
        _head.FromLinked().Should().BeEquivalentTo(_expected);
    }

    
}