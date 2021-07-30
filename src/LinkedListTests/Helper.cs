using LinkedList;
using System;

namespace LinkedListTests
{
    internal static class Helper
    {
        public static ListNode CreateList(params int[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentNullException(nameof(values), "values is null or empty");

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        public static (ListNode head, ListNode loop) CreateLoop(int loopNodeIndex, params int[] values)
        {
            ListNode head = CreateList(values);
            ListNode current = head;
            ListNode loop = null;

            for (int i = 0; i < values.Length; i++)
            {
                if (i == loopNodeIndex)
                {
                    loop = current;
                }

                if (current.next != null)
                {
                    current = current.next;
                }
            }

            current.next = loop;

            return (head, loop);
        }
    }
}
