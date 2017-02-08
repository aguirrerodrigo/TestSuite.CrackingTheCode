using System;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    /// <summary>
    /// Delete Middle Node: Implement an algorithm to delete a node in the middle (i.e., any node but
    /// the first and last node, not necessarily the exact middle) of a singly linked list, given only access to
    /// that node.
    /// EXAMPLE
    /// Input: the node c from the linked list a -> b -> c -> d -> e -> f
    /// Result: nothing is returned, but the new linked list looks like a -> b -> d -> e -> f
    /// </summary>
    public class DeleteMiddle
    {
        public void BruteForce(SinglyLinkedList<int> linkedList)
        {
            if(linkedList == null || linkedList.First == null)
                throw new ArgumentException("Linked list is empty.");

            var count = 0;
            var node = linkedList.First;
            while(node != null)
            {
                count++;
                node = node.Next;
            }

            node = linkedList.First;
            for(int i = 0; i < (count / 2) - 1; i++)
            {
                node = node.Next;
            }
            RemoveMiddle(node);
        }

        private void RemoveMiddle(SinglyLinkedListNode<int> node)
        {
            if (node.Next == null)
                throw new Exception("Could not delete end of linkedList.");

            node.Value = node.Next.Value;
            node.Next = node.Next.Next;
        }

        public void Optimized(SinglyLinkedList<int> linkedList)
        {
            if (linkedList == null || linkedList.First == null)
                throw new ArgumentException("Linked list is empty.");

            var current = linkedList.First;
            var seek = linkedList.First;
            while(seek.Next != null && seek.Next.Next != null)
            {
                current = current.Next;
                seek = seek.Next.Next;
            }

            RemoveMiddle(current);
        }

        public void BruteForceCorrect(SinglyLinkedList<int> linkedList, int value)
        {
            if (linkedList == null || linkedList.First == null)
                throw new ArgumentException("Linked list is empty.");

            if (linkedList.First.Value == value)
                throw new Exception("Could not delete start of linkedList.");

            var current = linkedList.First;
            while(current != null)
            {
                if (current.Value == value)
                {
                    RemoveMiddle(current);
                    return;
                }

                current = current.Next;
            }
        }
    }
}
