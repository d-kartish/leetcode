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
        [InlineData(new int[] { 4, 1 }, new int[] { 5, 6, 1, }, new int[] { 8, 4, 5 })]
        [InlineData(new int[] { 4, 1, 7 }, new int[] { 5, 6, }, new int[] { 8, 4, 2 })]
        [InlineData(new int[] { 4, 1, 7 }, new int[] { 5, 6, 1 }, new int[] { 8, 4, 2 })]
        [InlineData(new int[] { 1, 9, 1 }, new int[] { 3 }, new int[] { 2, 4 })]
        [InlineData(new int[] { 1 }, new int[] { 2 }, new int[] { 3 })]
        public void GetIntersectionNode_return_node(int[] valuesA, int[] valuesB, int[] valuesTail)
        {
            (ListNode headA, ListNode headB, ListNode intersection) = Helper.CreateIntersection(valuesA, valuesB, valuesTail);

            ListNode actual = _solution.GetIntersectionNode(headA, headB);

            Assert.Equal(intersection, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 1 }, new int[] { 5, 6, 1, })]
        [InlineData(new int[] { 4, 1, 7 }, new int[] { 5, 6, })]
        [InlineData(new int[] { 4, 1, 7 }, new int[] { 5, 6, 1 })]
        [InlineData(new int[] { 1, 9, 1 }, new int[] { 3 })]
        [InlineData(new int[] { 2, 6, 4 }, new int[] { 1, 5 })]
        public void GetIntersectionNode_return_null(int[] valuesA, int[] valuesB)
        {
            (ListNode headA, _) = Helper.CreateList(valuesA);
            (ListNode headB, _) = Helper.CreateList(valuesB);
            
            ListNode actual = _solution.GetIntersectionNode(headA, headB);

            Assert.Null(actual);
        }
    }
}
