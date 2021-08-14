namespace LinkedList.ClassicProblems
{
    public static class PalindromeLinkedList
    {
        public class Solution
        {
            public bool IsPalindrome(ListNode head)
            {
                if (head == null)
                    return false;

                ListNode middle = GetMiddle(head);
                ListNode reversed = Reverse(middle);

                ListNode currentA = head;
                ListNode currentB = reversed;

                while (currentB != null)
                {
                    if (currentA.val != currentB.val)
                        return false;

                    currentA = currentA.next;
                    currentB = currentB.next;
                }

                return true;
            }

            private ListNode GetMiddle(ListNode head)
            {
                ListNode slow = head;
                ListNode fast = head;

                while (fast?.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }

                if (fast != null)
                    slow = slow.next;

                return slow;
            }

            private ListNode Reverse(ListNode head)
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