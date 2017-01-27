using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions
{
    /// <summary>
    /// There are three types of edits that can be performed on strings: insert a character,
    /// remove a character, or replace a character. Given two strings, write a function to check if they are
    /// one edit (or zero edits) away.
    /// EXAMPLE
    /// pale, ple -> true
    /// pales, pale -> true
    /// pale, bale -> true
    /// pale, bake -> false
    /// </summary>
    public class OneOrZeroEdits
    {
        public bool Optimized(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            var shorter = s1;
            var longer = s2;
            if(s1.Length > s2.Length)
            {
                shorter = s2;
                longer = s1;
            }

            if (longer.Length - shorter.Length >= 2)
                return false;

            var discrepancyCount = 0;
            var j = 0;
            for(int i = 0; i < longer.Length; i++)
            {
                if (j >= shorter.Length || longer[i] != shorter[j])
                {
                    discrepancyCount++;
                    if (discrepancyCount > 1)
                        return false;

                    if (longer.Length == shorter.Length)
                        j++;
                }
                else
                    j++;
            }

            return true;
        }
    }
}
