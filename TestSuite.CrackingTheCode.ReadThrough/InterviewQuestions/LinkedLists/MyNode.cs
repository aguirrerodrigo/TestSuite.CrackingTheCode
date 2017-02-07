namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists
{
    public class MyNode<T>
    {
        public T Value { get; set; }
        public MyNode<T> Next { get; set; }

        public MyNode(T value)
        {
            this.Value = value;
        }
    }
}