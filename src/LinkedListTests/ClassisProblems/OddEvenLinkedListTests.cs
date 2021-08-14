using LinkedList;
using LinkedList.ClassicProblems;
using Xunit;

namespace LinkedListTests.ClassisProblems
{
    public class OddEvenLinkedListTests
    {
        private OddEvenLinkedList.Solution _solution;

        public OddEvenLinkedListTests()
        {
            _solution = new OddEvenLinkedList.Solution();
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5}, new[] {1, 3, 5, 2, 4})]
        [InlineData(new[] {2, 1, 3, 5, 6, 4, 7}, new[] {2, 3, 6, 7, 1, 5, 4})]
        [InlineData(new[] {1}, new[] {1})]
        [InlineData(new[] {1, 2}, new[] {1, 2})]
        [InlineData(new int[] { }, new int[] { })]
        public void OddEvenList(int[] values, int[] expected)
        {
            (ListNode head, _) = Helper.CreateList(values);

            ListNode actual = _solution.OddEvenList(head);

            ListNode current = actual;

            foreach (int value in expected)
            {
                Assert.Equal(value, current.val);
                current = current.next;
            }
        }
    }
}