using System;

namespace LinkedList.TwoPointerTechnique
{
    public class LinkedListCycle2
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
            ListNode cycle = solution.DetectCycle(nodes[0]);

            if (cycle != nodes[1])
                throw new Exception("Expected 'nodes[1]'");
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
            ListNode cycle = solution.DetectCycle(nodes[0]);

            if (cycle != nodes[0])
                throw new Exception("Expected 'nodes[0]'");
        }

        public static void Test3()
        {
            ListNode[] nodes = new ListNode[]
            {
                new ListNode(1)
            };

            var solution = new Solution();
            ListNode cycle = solution.DetectCycle(nodes[0]);

            if (cycle != null)
                throw new Exception("Expected 'null'");
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
            ListNode cycle = solution.DetectCycle(nodes[0]);

            if (cycle != nodes[0])
                throw new Exception("Expected 'nodes[0]'");
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
            ListNode cycle = solution.DetectCycle(nodes[0]);

            if (cycle != nodes[4])
                throw new Exception("Expected 'nodes[4]'");
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
            ListNode cycle = solution.DetectCycle(nodes[0]);

            if (cycle != null)
                throw new Exception("Expected 'null'");
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
