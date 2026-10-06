namespace Base75.LinkedList;

public class RemoveNode
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var result = new ListNode(0, head);
        var first = result;
        var second = result;
        for (int i = 0; i <= n; i++)
        {
            first = first.next;
        }
        while (first != null)
        {
            first = first.next;
            second = second.next;
        }

        second.next = second?.next?.next;
        return result.next;
    }
}