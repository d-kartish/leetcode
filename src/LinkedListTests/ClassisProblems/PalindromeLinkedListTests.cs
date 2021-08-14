using LinkedList;
using LinkedList.ClassicProblems;
using Xunit;

namespace LinkedListTests.ClassisProblems
{
    public class PalindromeLinkedListTests
    {
        private PalindromeLinkedList.Solution _solution;

        public PalindromeLinkedListTests()
        {
            _solution = new PalindromeLinkedList.Solution();
        }

        [Theory]
        [InlineData(new[] {1, 2, 2, 1})]
        [InlineData(new[] {1, 2, 3, 2, 1})]
        [InlineData(new[] {1, 2, 3, 3, 2, 1})]
        [InlineData(new[] {1, 2, 3, 3, 3, 2, 1})]
        public void IsPalindrome_return_true(int[] values)
        {
            (ListNode head, _) = Helper.CreateList(values);

            bool actual = _solution.IsPalindrome(head);

            Assert.True(actual);
        }

        [Theory]
        [InlineData(new[] {1, 2,})]
        [InlineData(new[] {1, 2, 3})]
        [InlineData(new[] {1, 2, 3, 2})]
        [InlineData(new[] {4, 2, 3, 1})]
        public void IsPalindrome_return_false(int[] values)
        {
            (ListNode head, _) = Helper.CreateList(values);

            bool actual = _solution.IsPalindrome(head);

            Assert.False(actual);
        }
    }
}