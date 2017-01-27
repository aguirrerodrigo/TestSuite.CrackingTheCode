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
    }
}
