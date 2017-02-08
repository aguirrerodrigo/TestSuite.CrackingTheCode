using System.Collections.Generic;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> First { get; set; }
        private SinglyLinkedListNode<T> Last { get; set; }

        public SinglyLinkedList(params T[] values)
        {
            foreach(var val in values)
            {
                this.Add(val);
            }
        }

        public void Add(T value)
        {
            if (this.Last == null)
            {
                this.Last = new SinglyLinkedListNode<T>(value);
                this.First = this.Last;
            }
            else
            {
                this.Last.Next = new SinglyLinkedListNode<T>(value);
                this.Last = this.Last.Next;
            }
        }

        public T[] ToArray()
        {
            var list = new List<T>();
            var node = this.First;
            while(node != null)
            {
                list.Add(node.Value);
                node = node.Next;
            }

            return list.ToArray();
        }
    }
}
