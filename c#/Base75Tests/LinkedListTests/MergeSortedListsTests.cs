using System.Collections;
using Base75.LinkedList;
using FluentAssertions;

namespace RandomTasksTests.LinkedListTests;

public class MergeSortedListsTests
{
    private MergeSortedLists _task;
    private ListNode _head;
    private ListNode _secondHead;
    private List<int> _expected;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
        _expected = new List<int>(Enumerable.Range(1, 8));
        _head = ListNode.FromList(new() {1, 3 ,5, 8});
        _secondHead = ListNode.FromList(new() {2, 4, 6, 7});
    }

    [Test]
    public void MergeList_Test()
    {
        var res = _task.MergeTwoLists(_head, _secondHead);
        res.FromLinked().Should().BeEquivalentTo(_expected);
    }
}