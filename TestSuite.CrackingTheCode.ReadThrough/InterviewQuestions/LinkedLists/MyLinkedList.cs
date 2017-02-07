using System.Collections.Generic;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    public class MyLinkedList<T>
    {
        public MyNode<T> First { get; set; }
        private MyNode<T> Last { get; set; }

        public MyLinkedList(params T[] values)
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
                this.Last = new MyNode<T>(value);
                this.First = this.Last;
            }
            else
            {
                this.Last.Next = new MyNode<T>(value);
                this.Last = this.Last.Next;
            }
        }

        public void RemoveNext(MyNode<T> node)
        {
            node.Next = node.Next.Next;
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
