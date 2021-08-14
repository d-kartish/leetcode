namespace LinkedList.ClassicProblems
{
    public static class ReverseLinkedList
    {
        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                if (head?.next == null)
                    return head;

                ListNode point = head;

                while (point.next != null)
                {
                    ListNode tmp = point.next;

                    point.next = tmp.next;
                    tmp.next = head;
                    head = tmp;
                }

                return head;
            }
        }
    }
}