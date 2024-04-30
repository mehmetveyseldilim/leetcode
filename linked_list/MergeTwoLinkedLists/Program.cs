public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Program
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();
        var tail = head;

        while (list1 is not null && list2 is not null)
        {
            if (list1.val >= list2.val)
            {
                tail.next = list2;
                list2 = list2.next!;
            }
            else
            {
                tail.next = list1;
                list1 = list1.next!;
            }

            tail = tail.next;
        }

        if (list1 is not null)
            tail.next = list1;
        else if (list2 is not null)
            tail.next = list2;

        return head.next!;
    }

    // Helper method to print the elements of the list
    public static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next!;
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        // Example 1: list1 = [1,2,4], list2 = [1,3,4]
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        ListNode list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);

        ListNode mergedList = MergeTwoLists(list1, list2);

        Console.WriteLine("Merged List:");
        PrintList(mergedList);
    }
}
