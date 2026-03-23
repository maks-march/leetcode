namespace ConsoleTasks.LinkedList;

public class MergeSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var current1 = list1;
        var current2 = list2;
        ListNode temp;
        if (current1?.val < current2?.val || current2 == null)
        {
            temp = current1;
            current1 = current1?.next;
        }
        else
        {
            temp = current2;
            current2 = current2?.next;
        }

        var result = temp;
        while (current1 != null || current2 != null)
        {
            if (current1?.val < current2?.val || current2 == null)
            {
                temp.next = current1;
                temp = temp.next;
                current1 = current1?.next;
            }
            else
            {
                
                temp.next = current2;
                temp = temp.next;
                current2 = current2?.next;
            }
        }

        return result;
    }
}