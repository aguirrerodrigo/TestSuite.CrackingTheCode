using System;
using System.Collections.Generic;
using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions
{
    /// <summary>
    /// Given two sorted arrays, find the number of elements in common. The arrays are the same length
    /// and each has all distinct elements.
    /// A: 13 27 35 40 49 55 59
    /// B: 17 35 39 40 55 58 60
    /// </summary>
    public class TwoSortedArrays
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        public int[] BruteForce(int[] a, int[] b)
        {
            var result = new List<int>();

            foreach(var n1 in a)
            {
                foreach(var n2 in b)
                {
                    this.Counter.Increment();

                    if(n1 == n2)
                    {
                        result.Add(n1);
                        break;
                    }
                }
            }

            return result.ToArray();
        }

        public int[] HashSet(int[] a, int[] b)
        {
            var result = new List<int>();

            var set = new HashSet<int>(a);
            foreach(var n in b)
            {
                this.Counter.Increment();

                if (set.Contains(n))
                    result.Add(n);
            }

            return result.ToArray();
        }

        public int[] Optimized(int[] a, int[] b)
        {
            var result = new List<int>();

            int j = 0;
            foreach(var n1 in a)
            {
                this.Counter.Increment();

                var n2 = b[j];
                while(n2 < n1)
                {
                    this.Counter.Increment();

                    j++;
                    n2 = b[j];
                }

                if (n1 == n2)
                    result.Add(n1);
            }

            return result.ToArray();
        }
    }
}
