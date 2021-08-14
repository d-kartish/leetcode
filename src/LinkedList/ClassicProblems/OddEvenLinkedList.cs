namespace LinkedList.ClassicProblems
{
    public static class OddEvenLinkedList
    {
        public class Solution
        {
            public ListNode OddEvenList(ListNode head)
            {
                if (head == null || head.next == null)
                    return head;

                ListNode odd = head;
                ListNode even = head.next;
                ListNode evenHead = even;

                while (odd.next != null && even.next != null)
                {
                    if (odd.next.next != null)
                    {
                        odd.next = odd.next.next;
                        odd = odd.next;
                    }

                    if (even.next.next != null)
                    {
                        even.next = even.next.next;
                        even = even.next;
                    }
                }

                odd.next = evenHead;
                even.next = null;

                return head;
            }
        }
    }
}