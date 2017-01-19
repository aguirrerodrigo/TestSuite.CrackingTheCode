using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.BigO
{
    public class ReverseArray
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        /// <summary>
        /// TimeComplexity: O(n).
        /// SpaceComplexity: O(n).
        /// </summary>
        public int[] BruteForce(int[] n)
        {
            var result = new int[n.Length];
            for(var i = 0; i < n.Length; i++)
            {
                Counter.Increment();

                result[n.Length - 1 - i] = n[i];
            }

            return result;
        }

        /// <summary>
        /// TimeComplexity: O(n).
        /// SpaceComplexity: O(1).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] Optimized(int[] n)
        {
            for(var i = 0; i < n.Length / 2; i++)
            {
                Counter.Increment();

                var left = i;
                var right = n.Length - 1 - i;
                var temp = n[left];
                n[left] = n[right];
                n[right] = temp;
            }

            return n;
        }
    }
}
