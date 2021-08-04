using LinkedList;
using LinkedList.Conclusion;
using Xunit;

namespace LinkedListTests.Conclusion
{
    public class AddTwoNumbersTests
    {
        private AddTwoNumbers.Solution _solution;

        public AddTwoNumbersTests()
        {
            _solution = new AddTwoNumbers.Solution();
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4, 9, 7 }, new int[] { 7, 0, 8, 9, 7 })]
        [InlineData(new int[] { 2, 4, 3, 9, 7 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8, 9, 7 })]
        [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void AddTwoNumbers(int[] valuesA, int[] valuesB, int[] expected)
        {
            (ListNode headA, _) = Helper.CreateList(valuesA);
            (ListNode headB, _) = Helper.CreateList(valuesB);

            ListNode actual = _solution.AddTwoNumbers(headA, headB);

            ListNode current = actual;

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], current.val);

                current = current.next;
            }

            Assert.Null(current);
        }
    }
}
