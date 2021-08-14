namespace LinkedList.ClassicProblems
{
    public static class RemoveLinkedListElements
    {
        public class Solution
        {
            public ListNode RemoveElements(ListNode head, int val)
            {
                ListNode current = head;
                ListNode prev = null;

                while (current != null)
                {
                    if (current.val == val)
                    {
                        if (prev != null)
                        {
                            prev.next = current.next;
                        }
                        else
                        {
                            head = current.next;
                        }
                    }
                    else
                    {
                        prev = current;
                    }

                    current = current.next;
                }

                return head;
            }
        }
    }
}