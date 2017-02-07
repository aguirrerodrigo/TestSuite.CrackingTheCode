using System;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    /// <summary>
    /// Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list.
    /// </summary>
    public class KthToTheLast
    {
        public int BruteForce(MyLinkedList<int> linkedList, int k)
        {
            if (k <= 0)
                throw new ArgumentException("k should be greater than 0.");
            if (linkedList == null || linkedList.First == null)
                throw new ArgumentException("Linked list is empty.");

            var current = linkedList.First;
            while(current != null)
            {
                var next = GetNextNthNode(current, k - 1);
                if (next.Next == null)
                    return current.Value;
                current = current.Next;
            }

            throw new IndexOutOfRangeException("Linkedlist too short to find kth to last.");
        }

        private MyNode<int> GetNextNthNode(MyNode<int> node, int n)
        {
            var current = node;
            for(int i = 0; i < n; i++)
            {
                current = current.Next;
            }
            return current;
        }

        private int?[] set;
        public int Optimized(MyLinkedList<int> linkedList, int k)
        {
            set = new int?[k];
            var current = linkedList.First;
            while(current != null)
            {
                this.Push(current.Value);
                current = current.Next;
            }

            if (set[0] == null)
                throw new IndexOutOfRangeException("Linkedlist too short to find kth to last.");
            else
                return set[0].Value;
        }

        private void Push(int value)
        {
            for(int i = 1; i < set.Length; i++)
            {
                set[i - 1] = set[i];
            }
            set[set.Length - 1] = value;
        }

        public int UseCount(MyLinkedList<int> linkedList, int k)
        {
            if (k <= 0)
                throw new ArgumentException("k should be greater than 0.");

            var length = 0;

            var current = linkedList.First;
            while (current != null)
            {
                length++;
                current = current.Next;
            }

            if (length < k)
                throw new Exception("Linkedlist too short to find kth to last.");

            current = linkedList.First;
            for(int i = 0; i < length - k; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public void Print(MyLinkedList<int> linkedList, int k)
        {
            PrintInternal(linkedList.First, k);
        }
        
        private int PrintInternal(MyNode<int> node, int k)
        {
            if (node == null)
                return 0;

            var index = PrintInternal(node.Next, k) + 1;
            if (index == k)
                Console.WriteLine(k + "th to the last node is " + node.Value);
            return index;
        }

        private MyNode<int> kthNode;
        public int Recursive(MyLinkedList<int> linkedList, int k)
        {
            RecursiveInternal(linkedList.First, k);
            if (kthNode == null)
                throw new Exception("Linkedlist too short to find kth to last.");
            else
                return kthNode.Value;
        }

        private int RecursiveInternal(MyNode<int> node, int k)
        {
            if (node == null)
                return 0;

            var index = RecursiveInternal(node.Next, k) + 1;
            if (index == k)
                kthNode = node;

            return index;
        }

        public int Seek(MyLinkedList<int> linkedList, int k)
        {
            if (k <= 0)
                throw new ArgumentException("k should be greater than 0.");
            if (linkedList == null || linkedList.First == null)
                throw new ArgumentException("Linked list is empty.");

            var current = linkedList.First;
            var seek = current;

            for(int i = 0; i < k - 1; i++)
            {
                if(seek == null)
                    throw new Exception("Linkedlist too short to find kth to last.");
                seek = seek.Next;
            }
            
            while(seek.Next != null)
            {
                current = current.Next;
                seek = seek.Next;
            }

            return current.Value;
        }
    }
}
