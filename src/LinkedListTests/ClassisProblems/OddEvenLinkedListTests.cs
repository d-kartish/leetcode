using LinkedList;
using LinkedList.ClassisProblems;
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
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 3, 5, 2, 4 })]
        [InlineData(new int[] { 2, 1, 3, 5, 6, 4, 7 }, new int[] { 2, 3, 6, 7, 1, 5, 4 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]
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
