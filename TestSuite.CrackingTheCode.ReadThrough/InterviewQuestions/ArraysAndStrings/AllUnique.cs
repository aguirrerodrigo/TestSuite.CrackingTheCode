using System;
using System.Collections.Generic;
using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters. What if you
    /// cannot use additional data structures?
    /// </summary>
    public class AllUnique
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        public bool BruteForce(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                var c1 = s[i];
                for(int j = 0; j < s.Length; j++)
                {
                    this.Counter.Increment();

                    if (i == j)
                        continue;

                    var c2 = s[j];
                    if (c1 == c2)
                        return false;
                }
            }

            return true;
        }

        public bool HashSet(string s)
        {
            var set = new HashSet<char>();
            foreach(var c in s)
            {
                this.Counter.Increment();

                if (set.Add(c) == false)
                    return false;
            }
            return true;
        }

        public bool Optimized(string s)
        {
            if (s.Length > 128)
                return false;

            var chars = new bool[127];
            foreach(var c in s)
            {
                this.Counter.Increment();
                if (chars[c])
                    return false;

                chars[c] = true;
            }
            return true;
        }

        public bool NoDataStructure(string s)
        {
            var array = s.ToCharArray();
            Array.Sort(array); // O(n): n log n

            for(int i = 0; i < array.Length - 1; i++)
            {
                this.Counter.Increment();

                var c1 = array[i];
                var c2 = array[i + 1];

                if (c1 == c2)
                    return false;
            }

            return true;
        }

        public bool BitShift(string s)
        {
            int collection = 0;
            foreach(var c in s)
            {
                this.Counter.Increment();

                var val = c - 'a';
                var charPlace = 1 << val;
                if ((collection & charPlace) > 0)
                    return false;
                collection |= charPlace;
            }
            return true;
        }

        public bool BitShiftLong(string s)
        {
            long collection = 0;
            foreach (var c in s)
            {
                this.Counter.Increment();

                var val = c - 'a';
                var charPlace = (long)1 << val;
                if ((collection & charPlace) > 0)
                    return false;
                collection |= charPlace;
            }
            return true;
        }
    }
}
