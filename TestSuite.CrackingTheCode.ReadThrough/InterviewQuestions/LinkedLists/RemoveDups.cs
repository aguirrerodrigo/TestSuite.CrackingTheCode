using System;
using System.Collections.Generic;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    /// <summary>
    /// Remove Dups: Write code to remove duplicates from an unsorted linked list.
    /// FOLLOW UP
    /// How would you solve this problem if a temporary buffer is not allowed?
    /// </summary>
    public class RemoveDups
    {
        public void BruteForce(LinkedList<int> linkedList)
        {
            if (linkedList == null || linkedList.First == null)
                return;

            var set = new HashSet<int>();

            var node = linkedList.First;
            set.Add(node.Value);
            while(node.Next != null)
            {
                if(set.Contains(node.Next.Value))
                    linkedList.Remove(node.Next);
                else
                    set.Add(node.Next.Value);

                node = node.Next;
            }
        }

        public void NoTempBuffer(LinkedList<int> linkedList)
        {
            if (linkedList == null || linkedList.First == null)
                return;

            var current = linkedList.First;
            while (current.Next != null)
            {
                var node = current;
                while(node.Next != null)
                {
                    if (current.Value == node.Next.Value)
                        linkedList.Remove(node.Next);
                    node = node.Next;
                }
                current = current.Next;
            }
        }
        
        public void MyBruteForce(MyLinkedList<int> linkedList)
        {
            if (linkedList == null || linkedList.First == null)
                return;

            var set = new HashSet<int>();

            var node = linkedList.First;
            set.Add(node.Value);
            while (node.Next != null)
            {
                if (set.Contains(node.Next.Value))
                    linkedList.RemoveNext(node);
                else
                    set.Add(node.Next.Value);

                node = node.Next;
            }
        }

        public void MyNoTempBuffer(MyLinkedList<int> linkedList)
        {
            if (linkedList == null || linkedList.First == null)
                return;

            var current = linkedList.First;
            while (current.Next != null)
            {
                var node = current;
                while (node.Next != null)
                {
                    if (current.Value == node.Next.Value)
                        linkedList.RemoveNext(node);
                    node = node.Next;
                }
                current = current.Next;
            }
        }
    }
}
