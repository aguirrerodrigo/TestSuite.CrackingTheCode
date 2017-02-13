using System;
using System.Collections.Generic;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    /// <summary>
    /// Implement a function to check if a linked list is a palindrome.
    /// </summary>
    public class Palindrome
    {
        public bool BruteForce(LinkedList<int> linkedList)
        {
            var forward = linkedList.First;
            var backward = linkedList.Last;
            while(forward != null && backward != null)
            {
                if (forward.Value != backward.Value)
                    return false;

                if (forward.Next == backward || backward.Previous == forward || forward == backward)
                    break;

                forward = forward.Next;
                backward = backward.Previous;
            }

            return true;
        }

        private int length = 0;
        private Stack<int> valueStack;
        private int index = 0;
        public bool BruteForce(SinglyLinkedList<int> linkedList)
        {
            length = 0;
            var node = linkedList.First;
            while(node != null)
            {
                length++;
                node = node.Next;
            }

            index = -1;
            valueStack = new Stack<int>();
            return Evaluate(linkedList.First);
        }

        /// <returns>True if add, False if evaluate.</returns>
        public bool Evaluate(SinglyLinkedListNode<int> node)
        {
            index++;
            if (index < (length / 2))
            {
                valueStack.Push(node.Value);
                return Evaluate(node.Next);
            }
            else if (index == length / 2 && length % 2 == 1)
            {
                return Evaluate(node.Next);
            }
            else
            {
                return (node.Value == valueStack.Pop() && (node.Next == null || Evaluate(node.Next)));
            }
        }

        public bool Optimized(SinglyLinkedList<int> linkedList)
        {
            var valueStack = new Stack<int>();
            var current = linkedList.First;
            var seek = linkedList.First;
            while(seek != null && seek.Next != null)
            {
                valueStack.Push(current.Value);
                current = current.Next;
                seek = seek.Next.Next;
            }

            if (seek != null)
                current = current.Next;

            while(current != null)
            {
                if (current.Value != valueStack.Pop())
                    return false;
                current = current.Next;
            }

            return true;
        }

        public bool Recursive(SinglyLinkedList<int> linkedList)
        {
            var length = GetLength(linkedList);
            var lastNode = default(SinglyLinkedListNode<int>);
            var innerResult = Step(linkedList.First, length, out lastNode);

            return innerResult;
        }

        private int GetLength(SinglyLinkedList<int> linkedList)
        {
            var length = 0;
            var node = linkedList.First;
            while (node != null)
            {
                node = node.Next;
                length++;
            }
            return length;
        }

        private bool Step(SinglyLinkedListNode<int> leftNode, int index, out SinglyLinkedListNode<int> rightNode)
        {
            if(index == 2)
            {
                rightNode = leftNode.Next.Next;
                return leftNode.Value == leftNode.Next.Value;
            }
            else if(index == 1)
            {
                rightNode = leftNode.Next;
                return true;
            }
            else
            {
                var compare = default(SinglyLinkedListNode<int>);
                var innerResult = Step(leftNode.Next, index - 2, out compare);
                rightNode = compare.Next;
                return innerResult && leftNode.Value == compare.Value;
            }
        }

        public bool RecursiveSeek(SinglyLinkedList<int> linkedList)
        {
            var rightNode = default(SinglyLinkedListNode<int>);
            var result = Step(linkedList.First, linkedList.First, out rightNode);

            return result;
        }

        private bool Step(SinglyLinkedListNode<int> node, SinglyLinkedListNode<int> seek, out SinglyLinkedListNode<int> rightNode)
        {
            // only one node
            if(node.Next == null)
            {
                rightNode = null;
                return true;
            }

            if (seek.Next != null)
                seek = seek.Next.Next;

            if(seek == null)
            {
                rightNode = node.Next.Next;
                return node.Value == node.Next.Value;
            }
            else if (seek.Next == null)
            {
                rightNode = node.Next.Next.Next;
                return node.Value == node.Next.Next.Value;
            }
            else
            {
                var compare = default(SinglyLinkedListNode<int>);
                var innerResult = Step(node.Next, seek, out compare);

                rightNode = compare.Next;
                return innerResult && node.Value == compare.Value;
            }
        }
    }
}