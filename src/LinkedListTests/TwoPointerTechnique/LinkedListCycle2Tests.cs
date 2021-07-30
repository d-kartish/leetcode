using LinkedList;
using LinkedList.TwoPointerTechnique;
using Xunit;

namespace LinkedListTests.TwoPointerTechnique
{
    public class LinkedListCycle2Tests
    {
        private LinkedListCycle2.Solution _solution;

        public LinkedListCycle2Tests()
        {
            _solution = new LinkedListCycle2.Solution();
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 0, -4 }, 1)]
        [InlineData(new int[] { 1, 2 }, 0)]
        [InlineData(new int[] { 3, 2, 0, -4, 5 }, 0)]
        [InlineData(new int[] { 3, 2, 0, -4, 5 }, 4)]
        public void DetectCycle_return_true(int[] values, int loopNodeIndex)
        {
            (ListNode head, ListNode loop) = Helper.CreateLoop(values, loopNodeIndex);

            ListNode actual = _solution.DetectCycle(head);

            Assert.Equal(loop, actual);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 0, -4 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 1, 1, 1 })]
        public void DetectCycle_return_false(int[] values)
        {
            (ListNode head, _) = Helper.CreateList(values);

            ListNode actual = _solution.DetectCycle(head);

            Assert.Null(actual);
        }
    }
}
