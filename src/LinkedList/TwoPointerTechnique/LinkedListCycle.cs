using System;

namespace LinkedList.TwoPointerTechnique
{
    public class LinkedListCycle
    {
        public static void Test1()
        {
            ListNode[] nodes = new ListNode[]
            {
                new ListNode(3),
                new ListNode(2),
                new ListNode(0),
                new ListNode(-4)
            };

            nodes[0].next = nodes[1];
            nodes[1].next = nodes[2];
            nodes[2].next = nodes[3];
            nodes[3].next = nodes[1];

            var solution = new Solution();
            bool result = solution.HasCycle(nodes[0]);

            if (!result)
                throw new Exception("Expected 'true'");
        }

        public static void Test2()
        {
            ListNode[] nodes = new ListNode[]
            {
                new ListNode(1),
                new ListNode(2)
            };

            nodes[0].next = nodes[1];
            nodes[1].next = nodes[0];

            var solution = new Solution();
            bool result = solution.HasCycle(nodes[0]);

            if (!result)
                throw new Exception("Expected 'true'");
        }

        public static void Test3()
        {
            ListNode[] nodes = new ListNode[]
            {
                new ListNode(1)
            };

            var solution = new Solution();
            bool result = solution.HasCycle(nodes[0]);

            if (result)
                throw new Exception("Expected 'false'");
        }

        public static void Test4()
        {
            ListNode[] nodes = new ListNode[]
            {
                new ListNode(3),
                new ListNode(2),
                new ListNode(0),
                new ListNode(-4),
                new ListNode(5)
            };

            nodes[0].next = nodes[1];
            nodes[1].next = nodes[2];
            nodes[2].next = nodes[3];
            nodes[3].next = nodes[4];
            nodes[4].next = nodes[0];

            var solution = new Solution();
            bool result = solution.HasCycle(nodes[0]);

            if (!result)
                throw new Exception("Expected 'true'");
        }

        public static void Test5()
        {
            ListNode[] nodes = new ListNode[]
            {
                new ListNode(3),
                new ListNode(2),
                new ListNode(0),
                new ListNode(-4),
                new ListNode(5)
            };

            nodes[0].next = nodes[1];
            nodes[1].next = nodes[2];
            nodes[2].next = nodes[3];
            nodes[3].next = nodes[4];
            nodes[4].next = nodes[4];

            var solution = new Solution();
            bool result = solution.HasCycle(nodes[0]);

            if (!result)
                throw new Exception("Expected 'true'");
        }

        public static void Test6()
        {
            ListNode[] nodes = new ListNode[]
            {
                new ListNode(1),
                new ListNode(1),
                new ListNode(1),
                new ListNode(1)
            };

            nodes[0].next = nodes[1];
            nodes[1].next = nodes[2];
            nodes[2].next = nodes[3];

            var solution = new Solution();
            bool result = solution.HasCycle(nodes[0]);

            if (result)
                throw new Exception("Expected 'false'");
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public class Solution
        {
            public bool HasCycle(ListNode head)
            {
                ListNode main = head;
                ListNode fast = head;

                while (fast != null && fast.next != null)
                {
                    fast = fast.next.next;

                    if (main == fast)
                        return true;

                    main = main.next;
                }

                return false;
            }
        }
    }
}
