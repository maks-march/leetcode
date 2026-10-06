namespace RandomTasks;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Task3
{
    private int _overflow = 0;
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var idx1 = l1;
        var idx2 = l2;
        var result = new ListNode(CalcValue(idx1, idx2));   
        var resultStart = result;   
        idx1 = idx1.next;
        idx2 = idx2.next;
        while (idx1 != null && idx2 != null)
        {
            result.next = new ListNode(CalcValue(idx1, idx2));
            result = result.next;
            idx1 = idx1.next;
            idx2 = idx2.next;
        }

        result = FullfillNode(result, idx1);
        result = FullfillNode(result, idx2);
        if (_overflow > 0)
            FullfillNode(result, new ListNode(0));
        return resultStart;
    }

    private int CalcValue(ListNode idx1, ListNode idx2)
    {
        int sum = idx1.val + idx2.val + _overflow;
        _overflow = sum / 10;
        return sum % 10;
    }

    private ListNode FullfillNode(ListNode result, ListNode? node)
    {
        var empty = new ListNode(0);
        while (node != null)
        {
            result.next = new ListNode(CalcValue(node, empty));
            result = result.next;
            node = node.next;
        }

        return result;
    }
}