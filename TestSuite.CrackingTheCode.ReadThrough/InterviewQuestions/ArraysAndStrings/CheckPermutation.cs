using System;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings
{
    /// <summary>
    /// Check Permutation: Given two strings, write a method to decide if one is a permutation of the
    /// other.
    /// </summary>
    public class CheckPermutation
    {
        public bool NLogN(string shorter, string longer)
        {
            if (shorter.Length == 0)
                return false;

            if (shorter.Length > longer.Length)
                return false;

            var shorterArray = shorter.ToCharArray();
            var longerArray = longer.ToCharArray();

            Array.Sort(shorterArray);
            Array.Sort(longerArray);

            var isPermutation = true;
            var i = 0;
            for(int j = 0; j < longerArray.Length; j++)
            {
                var s = shorterArray[i];
                var l = longerArray[j];
                if (s == l)
                {
                    i++;
                }
                else if (j == 0 || l != shorterArray[j - 1])
                {
                    isPermutation = false;
                    break;
                }

                if (i >= shorterArray.Length)
                    break;
            }

            return isPermutation;
        }

        public bool NLogNCorrect(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var c1 = s1.ToCharArray();
            var c2 = s2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            return new string(c1) == new string(c2);
        }

        public bool NCorrect(string s1, string s2)
        {
            var chars = new int[127];
            foreach (var c in s1)
                chars[c]++;

            foreach (var c in s2)
            {
                chars[c]--;
                if (chars[c] < 0)
                    return false;
            }
            return true;
        }

        public bool N(string shorter, string longer)
        {
            if (shorter.Length == 0)
                return false;

            if (shorter.Length > longer.Length)
                return false;

            var longerChars = new int[127];
            foreach(var c in longer)
            {
                longerChars[c]++;
            }

            var shorterChars = new int[127];
            foreach(var c in shorter)
            {
                shorterChars[c]++;
                if (shorterChars[c] > longerChars[c])
                    return false;
            }

            return true;
        }
    }
}