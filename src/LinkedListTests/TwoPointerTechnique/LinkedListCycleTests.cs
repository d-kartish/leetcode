using LinkedList;
using LinkedList.TwoPointerTechnique;
using Xunit;

namespace LinkedListTests.TwoPointerTechnique
{
    public class LinkedListCycleTests
    {
        private LinkedListCycle.Solution _solution;

        public LinkedListCycleTests()
        {
            _solution = new LinkedListCycle.Solution();
        }

        [Theory]
        [InlineData(new[] {3, 2, 0, -4}, 1)]
        [InlineData(new[] {1, 2}, 0)]
        [InlineData(new[] {3, 2, 0, -4, 5}, 0)]
        [InlineData(new[] {3, 2, 0, -4, 5}, 4)]
        public void HasCycle_return_true(int[] values, int loopNodeIndex)
        {
            (ListNode head, _) = Helper.CreateLoop(values, loopNodeIndex);

            bool actual = _solution.HasCycle(head);

            Assert.True(actual);
        }

        [Theory]
        [InlineData(new[] {3, 2, 0, -4})]
        [InlineData(new[] {1, 2})]
        [InlineData(new[] {1})]
        [InlineData(new[] {1, 1, 1, 1})]
        public void HasCycle_return_false(int[] values)
        {
            (ListNode head, _) = Helper.CreateList(values);

            bool actual = _solution.HasCycle(head);

            Assert.False(actual);
        }
    }
}