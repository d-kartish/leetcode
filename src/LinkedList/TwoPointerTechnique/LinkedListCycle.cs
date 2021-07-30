using System;

namespace LinkedList.TwoPointerTechnique
{
    public class LinkedListCycle
    {
        public class Solution
        {
            public bool HasCycle(ListNode head)
            {
                ListNode main = head;
                ListNode fast = head;

                while (fast != null && fast.next != null)
                {
                    main = main.next;
                    fast = fast.next.next;

                    if (main == fast)
                        return true;                    
                }

                return false;
            }
        }
    }
}
