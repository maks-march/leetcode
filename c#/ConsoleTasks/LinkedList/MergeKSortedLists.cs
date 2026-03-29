namespace ConsoleTasks.LinkedList;

public class MergeKSortedLists
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var pq = new PriorityQueue<ListNode, int>();
        foreach (var node in lists)
        {
            if (node != null)
                pq.Enqueue(node, node.val);
        }

        var result = new ListNode();
        var current = result;
        while (pq.TryDequeue(out ListNode next, out _))
        {
            current.next = next;
            current = current.next;
            if (next.next != null)
                pq.Enqueue(next.next, next.next.val);
        }
        return result.next;
    }
}