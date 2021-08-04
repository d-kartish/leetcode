namespace LinkedList.Conclusion
{
    public class AddTwoNumbers
    {
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode currentA = l1;
                ListNode currentB = l2;

                ListNode head = new ListNode();
                ListNode current = head;

                while (currentA != null || currentB != null)
                {
                    AddValueAndShift(ref currentA, ref current.val);
                    AddValueAndShift(ref currentB, ref current.val);

                    int value = current.val / 10;

                    if (value > 0 || currentA != null || currentB != null)
                    {
                        current.next = new ListNode(value);
                    }

                    current.val %= 10;
                    current = current.next;
                }

                return head;
            }

            private void AddValueAndShift(ref ListNode current, ref int sum)
            {
                if (current == null)
                    return;

                sum += current.val;
                current = current.next;
            }
        }
    }
}
