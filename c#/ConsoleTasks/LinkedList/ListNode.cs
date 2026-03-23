namespace ConsoleTasks.LinkedList;

public class ListNode
{
    public int val;
    public ListNode? next;
    
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
    
    public List<int> FromLinked()
    {
        var res = new List<int>();
        var head = this;
        while (head != null)
        {
            res.Add(head.val);
            head = head.next;
        }
        return res;
    }

    public static ListNode FromList(List<int> list)
    {
        var head = new ListNode(list[0]);
        var current = head;
        for (var index = 1; index < list.Count; index++)
        {
            var num = list[index];
            current.next = new ListNode(num);
            current = current.next;
        }

        return head;
    }
}