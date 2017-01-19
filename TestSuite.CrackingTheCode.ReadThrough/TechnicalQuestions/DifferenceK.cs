using System;
using System.Collections.Generic;
using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions
{
    /// <summary>
    /// Given an array of distinct integer values, count the number of pairs of integers that
    /// have difference k. For example, given array {1, 7, 5, 9, 2, 12, 3} and the difference
    /// k = 2, there are four pairs with the difference 2: {1, 3}, {3, 5}, {5, 7}, {7, 9}.
    /// </summary>
    public class DifferenceK
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        public int[][] BruteForce(int k, params int[] n)
        {
            var result = new List<int[]>();

            for (var i = 0; i < n.Length; i++)
            {
                for (var j = 0; j < n.Length; j++)
                {
                    this.Counter.Increment();

                    if (i == j)
                        continue;

                    var a = n[i];
                    var b = n[j];
                    if (b - a == k)
                        result.Add(new int[] { a, b });
                }
            }

            return result.ToArray();
        }

        public int[][] SortFirst(int k, int[] n)
        {
            var result = new List<int[]>();

            Array.Sort(n);
            for(int i = 0; i < n.Length - 1; i++)
            {
                for(int j = i + 1; j < n.Length; j++)
                {
                    this.Counter.Increment();

                    var a = n[i];
                    var b = n[j];
                    if (b - a == k)
                        result.Add(new int[] { a, b });

                    if (b - a > k)
                        break;
                }
            }

            return result.ToArray();
        }

        public int[][] HashSet(int k, int[] n)
        {
            var result = new List<int[]>();

            var set = new HashSet<int>(n);
            foreach(var a in set)
            {
                this.Counter.Increment();

                var b = a + k;
                if (set.Contains(b))
                    result.Add(new int[] { a, b });
            }

            return result.ToArray();
        }

        public int[][] SortedSet(int k, int[] n)
        {
            var result = new List<int[]>();

            var set = new SortedSet<int>(n);
            foreach (var a in set)
            {
                this.Counter.Increment();

                var b = a + k;
                if (set.Contains(b))
                    result.Add(new int[] { a, b });
            }

            return result.ToArray();
        }
    }
}
