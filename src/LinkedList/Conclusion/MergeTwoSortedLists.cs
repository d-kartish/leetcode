namespace LinkedList.Conclusion
{
    public class MergeTwoSortedLists
    {
        public class Solution
        {
            private static ListNode empty = new ListNode();

            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                if (l1 == null || l2 == null)
                    return l1 ?? l2;

                ListNode currentA = l1;
                ListNode currentB = l2;

                ListNode head = empty;
                ListNode current = head;

                while (currentA != null || currentB != null)
                {
                    ListNode prev;

                    if (currentA == null)
                    {
                        Shift(ref currentB, out prev);
                    }
                    else if (currentB == null)
                    {
                        Shift(ref currentA, out prev);
                    }
                    else if (currentA.val > currentB.val)
                    {
                        Shift(ref currentB, out prev);
                    }
                    else
                    {
                        Shift(ref currentA, out prev);
                    }

                    current.next = prev;
                    current = current.next;
                }

                return head.next;
            }

            private void Shift(ref ListNode current, out ListNode prev)
            {
                prev = current;
                current = current.next;
            }
        }
    }
}
