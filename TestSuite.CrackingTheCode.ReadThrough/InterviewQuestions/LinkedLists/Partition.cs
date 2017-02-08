using System.Collections.Generic;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    /// <summary>
    /// Partition: Write code to partition a linked list around a value x, such that all nodes less than x come
    /// before all nodes greater than or equal to x. lf x is contained within the list, the values of x only need
    /// to be after the elements less than x(see below). The partition element x can appear anywhere in the
    /// "right partition"; it does not need to appear between the left and right partitions.
    /// EXAMPLE
    /// Input: 3 -> 5 -> 8 -> 5 -> 10 -> 2 -> 1 [partition = 5)
    /// Output: 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8
    /// </summary>
    public class Partition
    {
        public void BruteForce(LinkedList<int> linkedList, int value)
        {
            var current = linkedList.First;
            var seek = current;
            while(seek != null)
            {
                if(seek.Value < value)
                {
                    Swap(current, seek);
                    current = current.Next;
                }
                seek = seek.Next;
            }
        }
        
        private void Swap(LinkedListNode<int> node1, LinkedListNode<int> node2)
        {
            var temp = node1.Value;
            node1.Value = node2.Value;
            node2.Value = temp;
        }
    }
}
