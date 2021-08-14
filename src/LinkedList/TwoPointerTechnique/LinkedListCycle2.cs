namespace LinkedList.TwoPointerTechnique
{
    public static class LinkedListCycle2
    {
        public class Solution
        {
            public ListNode DetectCycle(ListNode head)
            {
                ListNode main = head;
                ListNode second = head;

                bool hasLoop = false;

                while (second != null && second.next != null)
                {
                    main = main.next;
                    second = second.next.next;

                    if (main == second)
                    {
                        hasLoop = true;
                        break;
                    }
                }

                if (!hasLoop)
                    return null;

                ListNode cycle = head;

                while (cycle != main)
                {
                    cycle = cycle.next;
                    main = main.next;
                }

                return cycle;
            }
        }
    }
}