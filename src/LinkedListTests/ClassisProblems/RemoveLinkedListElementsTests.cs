using LinkedList;
using LinkedList.ClassisProblems;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTests.ClassisProblems
{
    public class RemoveLinkedListElementsTests
    {
        private RemoveLinkedListElements.Solution _solution;

        public RemoveLinkedListElementsTests()
        {
            _solution = new RemoveLinkedListElements.Solution();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 6)]
        [InlineData(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 1)]
        [InlineData(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 3)]
        [InlineData(new int[] { 7, 7, 7, 7 }, 7)]
        [InlineData(new int[] { }, 7)]
        public void RemoveElements(int[] values, int value)
        {
            (ListNode head, _) = Helper.CreateList(values);

            List<ListNode> expected = new List<ListNode>(values.Length);
            
            ListNode current = head;

            for (int i = 0; i < values.Length; i++)
            {
                if (current.val != value)
                {
                    expected.Add(current);
                }

                current = current.next;
            }

            ListNode actual = _solution.RemoveElements(head, value);

            if (expected.Count == 0)
            {
                Assert.Null(actual);
            }
            else
            {
                current = actual;

                foreach(ListNode node in expected)
                {
                    Assert.Equal(node, current);

                    current = current?.next;
                }
            }
        }
    }
}
