using System.Collections.Generic;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    /// <summary>
    /// Sum Lists: You have two numbers represented by a linked list, where each node contains a single
    /// digit.The digits are stored in reverse order, such that the 1 's digit is at the head of the list. Write a
    /// function that adds the two numbers and returns the sum as a linked list.
    /// EXAMPLE
    /// Input: (7 -> 1 -> 6) + (5 -> 9 -> 2) .That is, 617 + 295.
    /// Output: 2 -> 1 -> 9. That is, 912.
    /// FOLLOW UP
    /// Suppose the digits are stored in forward order. Repeat the above problem.
    /// Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).That is, 617 + 295.
    /// Output: 9 -> 1 -> 2. That is, 912.
    /// </summary>
    public class SumLists
    {
        public LinkedList<int> BruteForce(LinkedList<int> linkedList1, LinkedList<int> linkedList2)
        {
            var result = new LinkedList<int>();
            var carry = 0;
            var current1 = linkedList1.First;
            var current2 = linkedList2.First;
            while(current1 != null || current2 != null)
            {
                var value = (current1?.Value ?? 0) + (current2?.Value ?? 0) + carry;
                if (value >= 10)
                {
                    carry = value / 10;
                    value = value % 10;
                }
                else
                    carry = 0;

                result.AddLast(value);

                current1 = current1?.Next;
                current2 = current2?.Next;
            }

            if (carry > 0)
                result.AddLast(carry);

            return result;
        }

        private LinkedList<int> bruteForceReverseResult;
        public LinkedList<int> BruteForceReverse(LinkedList<int> linkedList1, LinkedList<int> linkedList2)
        {
            bruteForceReverseResult = new LinkedList<int>();
            PadLists(linkedList1, linkedList2);

            var node1 = linkedList1.First;
            var node2 = linkedList2.First;
            var carry = AddNodeReturnCarry(node1, node2);
            if (carry > 0)
                bruteForceReverseResult.AddFirst(carry);

            return bruteForceReverseResult;
        }

        private void PadLists(LinkedList<int> linkedList1, LinkedList<int> linkedList2)
        {
            var node1 = linkedList1.First;
            var node2 = linkedList2.First;

            while(node1 != null || node2 != null)
            {
                if (node1 == null)
                    linkedList1.AddFirst(0);
                if (node2 == null)
                    linkedList2.AddFirst(0);

                node1 = node1?.Next;
                node2 = node2?.Next;
            }
        }

        private int AddNodeReturnCarry(LinkedListNode<int> node1, LinkedListNode<int> node2)
        {
            var carry = 0;
            var value = 0;
            if(node1?.Next == null && node2?.Next == null)
            {
                value = (node1?.Value ?? 0) + (node2?.Value ?? 0);
            }
            else
            {
                value = (node1?.Value ?? 0) + (node2?.Value ?? 0) + AddNodeReturnCarry(node1?.Next, node2?.Next);
            }

            if (value >= 10)
            {
                carry = value / 10;
                value = value % 10;
            }
            else
                carry = 0;

            bruteForceReverseResult.AddFirst(value);

            return carry;
        }
    }
}
