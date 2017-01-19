using System;
using System.Collections.Generic;
using System.Linq;
using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions
{
    /// <summary>
    /// Design an algorithm to print all permutations of a string. For simplicity, assume all characters
    /// are unique.
    /// </summary>
    public class StringPermutations
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        public string[] GetPermutations(string s)
        {
            if (s == null || s.Length == 0)
                return new string[0];

            if (s.Length == 1)
                return new string[] { s };

            var perms = new HashSet<string>();
            perms.Add(s.Substring(0, 1));

            var result = Perms(s.Substring(1), perms);
            return result.ToArray();
        }

        private HashSet<string> Perms(string s, HashSet<string> perms)
        {
            var result = new HashSet<string>();

            var prefix = s.Substring(0, 1);
            var remaining = s.Substring(1);
            if (remaining.Length > 0)
                perms = Perms(remaining, perms);

            foreach(var p in perms)
            {
                for(int i = 0; i <= p.Length; i++)
                {
                    this.Counter.Increment();

                    result.Add(p.Substring(0, i) + prefix + p.Substring(i));
                }
            }

            return result;
        }
    }
}
