using System.Collections.Generic;
using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions
{
    /// <summary>
    /// Given a smaller string s and a bigger string b, design an algorithm to find all permutations
    /// of the shorter string within the longer one. Print the location of each permutation.
    /// </summary>
    public class StringInString
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        public int[] BruteForce(string s, string b)
        {
            if (s.Length > b.Length)
                return new int[0];
            else if (s == b)
            {
                return new int[] { 0 };
            }

            var result = new List<int>();

            var perms = GetPermutations(s);
            for(int i = 0; i <= b.Length - s.Length; i++)
            {
                this.Counter.Increment();

                var test = b.Substring(i, s.Length);
                if (perms.Contains(test))
                    result.Add(i);
            }

            return result.ToArray();
        }

        private HashSet<string> GetPermutations(string s)
        {
            var set = new HashSet<string>();

            if (s.Length == 0)
                return set;

            if (s.Length == 1)
            {
                set.Add(s);
                return set;
            }
                
            for (var i = 0; i < s.Length; i++)
            {
                var invariant = s[i];
                var rest = s.Substring(0, i) + s.Substring(i + 1);
                var newPerms = GetPermutations(rest);
                foreach (var perm in newPerms)
                {
                    this.Counter.Increment();

                    set.Add(invariant + perm);
                }
            }

            return set;
        }

        public int[] Optimized(string s, string b)
        {
            if (s.Length > b.Length)
                return new int[0];
            else if (s == b)
            {
                return new int[] { 0 };
            }

            var result = new List<int>();

            var charDictionary = CreateCharacterDictionary();
            foreach(var c in s)
            {
                charDictionary[c]++;
            }

            for(int i = 0; i <= b.Length - s.Length; i++)
            {
                var failed = false;
                var lookup = CreateLookupDictionary();
                for (int j = i; j < i + s.Length; j++)
                {
                    this.Counter.Increment();

                    var c = b[j];
                    if (lookup[c].Count == 0)
                        lookup[c].FirstOccurenceIndex = j;
                    lookup[c].Count++;

                    if (lookup[c].Count > charDictionary[c])
                    {
                        if (charDictionary[c] == 0)
                            i = j;
                        else
                            i = lookup[c].FirstOccurenceIndex;

                        failed = true;
                        break;
                    }
                }

                if (!failed)
                    result.Add(i);
            }

            return result.ToArray();
        }

        private Dictionary<char, int> CreateCharacterDictionary()
        {
            var dictionary = new Dictionary<char, int>();
            var chars = "abcdefghijklmnopqrstuvwxyz";
            foreach(var c in chars)
            {
                dictionary.Add(c, 0);
            }

            return dictionary;
        }

        private Dictionary<char, Lookup> CreateLookupDictionary()
        {
            var dictionary = new Dictionary<char, Lookup>();
            var chars = "abcdefghijklmnopqrstuvwxyz";
            foreach (var c in chars)
            {
                dictionary.Add(c, new Lookup());
            }

            return dictionary;
        }

        private class Lookup
        {
            public int FirstOccurenceIndex { get; set; } = -1;
            public int Count { get; set; }
        }
    }
}
