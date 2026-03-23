namespace ConsoleTasks.LinkedList;

public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        var hs = new HashSet<ListNode>();
        var current = head;
        while (current != null)
        {
            if (hs.Contains(current))
            {
                return true;
            }
            else
            {
                hs.Add(current);
            }
            current = current.next;
        }
        return false;
    }
}