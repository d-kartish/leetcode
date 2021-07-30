namespace LinkedList.TwoPointerTechnique
{
    public class RemoveNthNodeFromEndOfList
    {
        public class Solution
        {
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                ListNode current = head;
                ListNode prev = head;

                int step = 0;

                while (current.next != null)
                {
                    if (step == n)
                    {
                        prev = prev.next;
                    }
                    else
                    {
                        step++;
                    }

                    current = current.next;
                }

                if (prev == current)
                {
                    return null;
                }
                else if (step != n)
                {
                    return head.next;
                }
                else if (prev != null)
                {
                    prev.next = prev.next?.next;
                }

                return head;
            }
        }
    }
}
