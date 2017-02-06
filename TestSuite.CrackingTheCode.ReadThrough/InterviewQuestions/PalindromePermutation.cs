using System;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions
{
    /// <summary>
    /// Given a string, write a function to check if it is a permutation of a palindrome.
    /// A palindrome is a word or phrase that is the same forwards and backwards.A permutation
    /// is a rearrangement of letters.The palindrome does not need to be limited to just dictionary words.
    /// EXAMPLE
    /// Input: Tact Coa
    /// Output: True (permutations: "taco cat". "atco cta". etc.)
    /// </summary>
    public class PalindromePermutation
    {
        public bool Optimized(string s)
        {
            s = s.ToLower();
            var dictionary = new int[127];

            foreach(var c in s)
                dictionary[c]++;

            var hasOdd = false;
            for(int i = 0; i < dictionary.Length; i++)
            {
                if (i != ' ')
                {
                    if (dictionary[i] % 2 == 1)
                    {
                        if (hasOdd)
                            return false;
                        else
                            hasOdd = true;
                    }
                }
            }

            return true;
        }

        public bool OptimizedNoToLower(string s)
        {
            var alphabet = new int['z' - 'a' + 1];
            var oddCount = 0;
            foreach (var c in s)
            {
                var index = GetCharIndex(c);
                if (index < 0 || index >= alphabet.Length)
                    continue;

                alphabet[index]++;
                if (alphabet[index] % 2 == 1)
                    oddCount++;
                else
                    oddCount--;
            }

            return oddCount <= 1;
        }

        public bool OptimizedBitVector(string s)
        {
            var alphabet = 0;
            foreach(var c in s)
            {
                var index = GetCharIndex(c);
                if (index < 0)
                    continue;

                var val = 1 << index;
                alphabet ^= val;
            }

            return (alphabet & (alphabet - 1)) == 0;
        }

        private int GetCharIndex(char c)
        {
            if (c >= 'A' && c <= 'Z')
                return c - 'A';
            else if (c >= 'a' && c <= 'z')
                return c - 'a';
            else
                return -1;
        }
    }
}
