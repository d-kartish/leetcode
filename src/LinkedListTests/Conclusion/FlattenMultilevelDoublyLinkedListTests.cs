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

        [Fact]
        public void Flatten_ThreeLevelsList_ReturnNewValidList()
        {
            var head1 = CreateList(new[] {1, 2, 3, 4, 5, 6});
            var head2 = CreateList(new[] {7, 8, 9, 10});
            var head3 = CreateList(new[] {11, 12});

            SetChild(head1, 2, head2);
            SetChild(head2, 1, head3);

            //
            var actual = _solution.Flatten(head1);

            //
            AssertListValues(actual, new[] {1, 2, 3, 7, 8, 11, 12, 9, 10, 4, 5, 6});
        }

        [Fact]
        public void Flatten_TwoLevelsList_ReturnNewValidList()
        {
            var head1 = CreateList(new[] {1, 2, 4});
            var head2 = CreateList(new[] {3});

            SetChild(head1, 1, head2);

            //
            var actual = _solution.Flatten(head1);

            //
            AssertListValues(actual, new[] {1, 2, 3, 4});
        }

        [Fact]
        public void Flatten_OneoLevelList_ReturnSameValidList()
        {
            var head1 = CreateList(new[] {1, 2, 3});

            //
            var actual = _solution.Flatten(head1);

            //
            AssertListValues(actual, new[] {1, 2, 3});
        }

        [Fact]
        public void Flatten_FirstNodeHasChild_ReturnNewValidList()
        {
            var head1 = CreateList(new[] {1, 2, 3, 4, 5});
            var head2 = CreateList(new[] {7, 8, 9});
            var head3 = CreateList(new[] {10, 11});

            SetChild(head1, 0, head2);
            SetChild(head2, 0, head3);

            //
            var actual = _solution.Flatten(head1);

            //
            AssertListValues(actual, new[] {1, 7, 10, 11, 8, 9, 2, 3, 4, 5});
        }

        [Fact]
        public void Flatten_LastNodeHasChild_ReturnNewValidList()
        {
            var head1 = CreateList(new[] {1, 2, 3, 4, 5});
            var head2 = CreateList(new[] {7, 8, 9});
            var head3 = CreateList(new[] {10, 11});

            SetChild(head1, 4, head2);
            SetChild(head2, 2, head3);

            //
            var actual = _solution.Flatten(head1);

            //
            AssertListValues(actual, new[] {1, 2, 3, 4, 5, 7, 8, 9, 10, 11});
        }

        private FlattenMultilevelDoublyLinkedList.Node CreateList(int[] values)
        {
            var head = new FlattenMultilevelDoublyLinkedList.Node
            {
                val = values[0]
            };

            var current = head;

            for (int i = 1; i < values.Length; i++)
            {
                var node = new FlattenMultilevelDoublyLinkedList.Node
                {
                    val = values[i],
                    prev = current
                };

                current.next = node;
                current = node;
            }

            return head;
        }

        private void SetChild(FlattenMultilevelDoublyLinkedList.Node head, int skip,
            FlattenMultilevelDoublyLinkedList.Node child)
        {
            var current = head;

            for (int i = 1; i <= skip; i++)
            {
                current = current.next;
            }

            current.child = child;
            child.prev = current;
        }

        private void AssertListValues(FlattenMultilevelDoublyLinkedList.Node head, int[] expected)
        {
            var current = head;

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], current.val);

                current = current.next;
            }
        }
    }
}