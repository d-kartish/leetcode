namespace LinkedList.SinglyLinkedList.DesignLinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            public Node Next { get; set; }
            public int Val { get; }

            public Node(int val)
            {
                Val = val;
            }
        }

        private Node _head;
        private int _count;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (TryGetAt(index, out Node node))
            {
                return node.Val;
            }
            else
            {
                return -1;
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(_count, val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                var node = new Node(val)
                {
                    Next = _head
                };

                _head = node;
                _count++;
            }
            else if (TryGetAt(index - 1, out Node prev))
            {
                Node node = new Node(val)
                {
                    Next = prev.Next
                };

                prev.Next = node;
                _count++;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (_count == 0 || index >= _count)
                return;

            if (index == 0)
            {
                _head = _head.Next;
                _count--;
            }
            else if (TryGetAt(index - 1, out Node prev))
            {
                Node current = prev.Next;
                prev.Next = current.Next;
                _count--;
            }
        }

        private bool TryGetAt(int index, out Node node)
        {
            node = null;

            if (index < 0 || index >= _count)
            {
                return false;
            }

            int i = 0;
            Node current = _head;

            while (current != null)
            {
                if (i == index)
                {
                    node = current;
                    return true;
                }

                current = current.Next;
                i++;
            }

            return false;
        }
    }
}
