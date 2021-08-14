using LinkedList;
using LinkedList.ClassicProblems;
using Xunit;

namespace LinkedListTests.ClassisProblems
{
    public class ReverseLinkedListTests
    {
        private ReverseLinkedList.Solution _solution;

        public ReverseLinkedListTests()
        {
            _solution = new ReverseLinkedList.Solution();
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5})]
        [InlineData(new[] {1, 2})]
        [InlineData(new[] {1})]
        [InlineData(new int[] { })]
        public void ReverseList_return_node(int[] values)
        {
            (ListNode head, _) = Helper.CreateList(values);

            ListNode[] expected = new ListNode[values.Length];
            ListNode current = head;

            for (int i = values.Length - 1; i >= 0; i--)
            {
                expected[i] = current;
                current = current.next;
            }

            ListNode actual = _solution.ReverseList(head);

            if (expected.Length == 0)
            {
                Assert.Null(actual);
            }
            else
            {
                current = actual;

                for (int i = 0; i < expected.Length; i++)
                {
                    Assert.Equal(expected[i], current);

                    current = current?.next;
                }
            }
        }
    }
}