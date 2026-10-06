namespace Base75.LinkedList;

public class ReorderLinkedList
{
    public void ReorderList(ListNode head)
    {
        var inputHead = head;
        var list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        
        inputHead.val = list[0];
        inputHead.next = null;
        var current = inputHead;
        var left = 1;
        var right = list.Count - 1;
        var isFromStart = false;
        while (left <= right)
        {
            if (isFromStart)
            {
                current.next = new ListNode(list[left]);
                current = current.next;
                left++;
                isFromStart = false;
            }
            else
            {
                current.next = new ListNode(list[right]);
                current = current.next;
                right--;
                isFromStart = true;
            }
        }
    }
}