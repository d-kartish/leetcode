namespace LinkedList.Conclusion
{
    public class FlattenMultilevelDoublyLinkedList
    {
        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }

        public class Solution
        {
            public Node Flatten(Node head)
            {
                FlattenChilds(head);

                return head;
            }

            private Node FlattenChilds(Node head)
            {
                if (head == null)
                    return head;

                Node current = head;

                while (true)
                {
                    if (current.child != null)
                    {
                        Node childTail = FlattenChilds(current.child);

                        if (current.next != null)
                        {
                            childTail.next = current.next;
                            current.next.prev = childTail;
                        }

                        current.next = current.child;
                        current.child.prev = current;

                        current.child = null;

                        current = childTail;
                    }
                    else if (current.next != null)
                    {
                        current = current.next;
                    }
                    else
                    {
                        break;
                    }
                }

                return current;
            }
        }
    }
}
