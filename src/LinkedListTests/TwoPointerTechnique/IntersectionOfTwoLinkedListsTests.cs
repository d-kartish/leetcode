using LinkedList;
using LinkedList.TwoPointerTechnique;
using Xunit;

namespace LinkedListTests.TwoPointerTechnique
{
    public class IntersectionOfTwoLinkedListsTests
    {
        private IntersectionOfTwoLinkedLists.Solution _solution;

        public IntersectionOfTwoLinkedListsTests()
        {
            _solution = new IntersectionOfTwoLinkedLists.Solution();
        }

        [Theory]
        [InlineData(new[] {4, 1}, new[] {5, 6, 1,}, new[] {8, 4, 5})]
        [InlineData(new[] {4, 1, 7}, new[] {5, 6,}, new[] {8, 4, 2})]
        [InlineData(new[] {4, 1, 7}, new[] {5, 6, 1}, new[] {8, 4, 2})]
        [InlineData(new[] {1, 9, 1}, new[] {3}, new[] {2, 4})]
        [InlineData(new[] {1}, new[] {2}, new[] {3})]
        public void GetIntersectionNode_return_node(int[] valuesA, int[] valuesB, int[] valuesTail)
        {
            (ListNode headA, ListNode headB, ListNode intersection) =
                Helper.CreateIntersection(valuesA, valuesB, valuesTail);

            ListNode actual = _solution.GetIntersectionNode(headA, headB);

            Assert.Equal(intersection, actual);
        }

        [Theory]
        [InlineData(new[] {4, 1}, new[] {5, 6, 1,})]
        [InlineData(new[] {4, 1, 7}, new[] {5, 6,})]
        [InlineData(new[] {4, 1, 7}, new[] {5, 6, 1})]
        [InlineData(new[] {1, 9, 1}, new[] {3})]
        [InlineData(new[] {2, 6, 4}, new[] {1, 5})]
        public void GetIntersectionNode_return_null(int[] valuesA, int[] valuesB)
        {
            (ListNode headA, _) = Helper.CreateList(valuesA);
            (ListNode headB, _) = Helper.CreateList(valuesB);

            ListNode actual = _solution.GetIntersectionNode(headA, headB);

            Assert.Null(actual);
        }
    }
}