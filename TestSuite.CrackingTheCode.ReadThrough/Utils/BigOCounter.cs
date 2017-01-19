using System;

namespace TestSuite.CrackingTheCode.ReadThrough.Utils
{
    public class BigOCounter
    {
        public int Steps { get; set; }

        public void Increment()
        {
            this.Steps++;
        }

        public void Print(int worstCase)
        {
            Console.WriteLine($"O(worstCase): {worstCase}.\r\nO(n): {this.Steps}.");
        }
    }
}
