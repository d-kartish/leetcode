using LinkedList.Conclusion;
using Xunit;

namespace LinkedListTests.Conclusion
{
    public class FlattenMultilevelDoublyLinkedListTests
    {
        private FlattenMultilevelDoublyLinkedList.Solution _solution;

        public FlattenMultilevelDoublyLinkedListTests()
        {
            _solution = new FlattenMultilevelDoublyLinkedList.Solution();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 0, 0, 0, 7, 8, 9, 10, 0, 0, 11, 12 }, new int[] { 1, 2, 3, 7, 8, 11, 12, 9, 10, 4, 5, 6 })]
        [InlineData(new int[] { 1, 2, 0, 3 }, new int[] { 1, 3, 2 })]
        [InlineData(new int[] { }, new int[] { })]
        public void Flatten(int[] values, int[] expected)
        {
            var head = Parse(values);

            var actual = _solution.Flatten(head);

            if (expected.Length == 0)
            {
                Assert.Null(actual);
            }
            else
            {
                var current = actual;

                for (int i = 0; i < expected.Length; i++)
                {
                    Assert.Equal(expected[i], current.val);

                    current = current.next;
                }
            }
        }

        private FlattenMultilevelDoublyLinkedList.Node Parse(int[] values)
        {
            if (values == null || values.Length == 0)
                return null;

            var head = new FlattenMultilevelDoublyLinkedList.Node();
            var current = head;

            int i = 0;

            while (i < values.Length)
            {
                int value = values[i];

                if (value > 0)
                {
                    current.next = new FlattenMultilevelDoublyLinkedList.Node
                    {
                        prev = current,
                        val = value
                    };

                    current = current.next;
                }
                else
                {
                    while(value <= 0)
                    {
                        current = current.prev;
                        value = values[++i];
                    }

                    current.child = new FlattenMultilevelDoublyLinkedList.Node
                    {
                        prev = current,
                        val = value
                    };

                    current = current.child;
                }

                i++;
            }

            head.next.prev = null;

            return head.next;
        }
    }
}
