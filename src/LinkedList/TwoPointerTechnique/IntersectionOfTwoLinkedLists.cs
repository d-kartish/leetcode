namespace LinkedList.TwoPointerTechnique
{
    public class IntersectionOfTwoLinkedLists
    {
        public class Solution
        {
            public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
            {
                ListNode currentA = headA;
                ListNode currentB = headB;

                int countA = 0;
                int countB = 0;

                while (currentA != null || currentB != null)
                {
                    if (currentA == currentB)
                        return currentA;

                    if (currentA != null)
                    {
                        countA++;
                        currentA = currentA.next;
                    }

                    if (currentB != null)
                    {
                        countB++;
                        currentB = currentB.next;
                    }
                }

                if (countA == countB)
                    return null;

                currentA = Shift(headA, countA - countB);
                currentB = Shift(headB, countB - countA);

                ListNode intersection = null;

                while (intersection == null && currentA != null && currentB != null)
                {
                    if (currentA == currentB)
                    {
                        intersection = currentA;
                    }

                    currentA = currentA.next;
                    currentB = currentB.next;
                }

                return intersection;
            }

            private ListNode Shift(ListNode head, int count)
            {
                if (count <= 0)
                    return head;

                while (count > 0)
                {
                    head = head.next;
                    count--;
                }

                return head;
            }
        }
    }
}
