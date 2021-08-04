using LinkedList;
using LinkedList.Conclusion;
using Xunit;

namespace LinkedListTests.Conclusion
{
    public class MergeTwoSortedListsTests
    {
        private MergeTwoSortedLists.Solution _solution;

        public MergeTwoSortedListsTests()
        {
            _solution = new MergeTwoSortedLists.Solution();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 })]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { }, new int[] { 1, 3, 4 }, new int[] { 1, 3, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        public void MergeTwoLists(int[] valuesA, int[] valuesB, int[] expected)
        {
            (ListNode headA, _) = Helper.CreateList(valuesA);
            (ListNode headB, _) = Helper.CreateList(valuesB);

            ListNode actual = _solution.MergeTwoLists(headA, headB);

            if (expected.Length == 0)
            {
                Assert.Null(actual);
            }
            else
            {
                ListNode current = actual;

                for (int i = 0; i < expected.Length; i++)
                {
                    Assert.Equal(expected[i], current.val);

                    current = current.next;
                }
            }
        }
    }
}
