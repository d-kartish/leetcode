using LinkedList;
using System;

namespace LinkedListTests
{
    internal static class Helper
    {
        public static (ListNode head, ListNode tail) CreateList(int[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentNullException(nameof(values), "values is null or empty");

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);

                if (current.next != null)
                {
                    current = current.next;
                }
            }

            return (head, current);
        }

        public static (ListNode head, ListNode loop) CreateLoop(int[] values, int loopNodeIndex)
        {
            (ListNode head, ListNode tail) = CreateList(values);
            ListNode current = head;
            ListNode loop = null;

            for (int i = 0; i < values.Length; i++)
            {
                if (i == loopNodeIndex)
                {
                    loop = current;
                    break;
                }

                if (current.next != null)
                {
                    current = current.next;
                }
            }

            tail.next = loop;

            return (head, loop);
        }

        public static (ListNode headA, ListNode headB, ListNode intersection) CreateIntersection(int[] valuesA, int[] valuesB, int[] valuesTail)
        {
            (ListNode headA, ListNode tailA) = CreateList(valuesA);
            (ListNode headB, ListNode tailB) = CreateList(valuesB);
            (ListNode tail, _) = CreateList(valuesTail);

            tailA.next = tail;
            tailB.next = tail;

            return (headA, headB, tail);
        }
    }
}
