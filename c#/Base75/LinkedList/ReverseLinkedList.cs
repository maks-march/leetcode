namespace Base75.LinkedList;

public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        var result = head;
        var current = head;
        ListNode? prev = null;
        while (current != null)
        {
            result = current;
            current = current.next;
            result.next = prev;
            prev = result;
        }

        return result;
    }
}