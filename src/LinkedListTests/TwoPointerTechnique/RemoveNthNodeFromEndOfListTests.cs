using LinkedList;
using LinkedList.TwoPointerTechnique;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTests.TwoPointerTechnique
{
    public class RemoveNthNodeFromEndOfListTests
    {
        public RemoveNthNodeFromEndOfList.Solution _solution;

        public RemoveNthNodeFromEndOfListTests()
        {
            _solution = new RemoveNthNodeFromEndOfList.Solution();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1 }, 1)]
        public void RemoveNthFromEnd_return_node(int[] values, int n)
        {
            (ListNode head, _) = Helper.CreateList(values);

            int skip = values.Length - n;
            List<ListNode> expected = new List<ListNode>(values.Length - 1);
            
            ListNode current = head;

            for (int i = 0; i < values.Length; i++)
            {
                if (i != skip)
                {
                    expected.Add(current);
                }

                current = current.next;
            }

            ListNode actual = _solution.RemoveNthFromEnd(head, n);

            if (expected.Count == 0)
            {
                Assert.Null(actual);
            }
            else
            {
                current = actual;

                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.Equal(expected[i], current);

                    current = current?.next;
                }
            }            
        }
    }
}
