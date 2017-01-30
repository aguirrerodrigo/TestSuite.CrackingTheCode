using System.Text;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions
{
    /// <summary>
    /// Implement a method to perform basic string compression using the counts
    /// of repeated characters. For example, the string aabcccccaaa would become a2b1c5a3. If the
    /// "compressed" string would not become smaller than the original string, your method should return
    /// the original string. You can assume the string has only uppercase and lowercase letters(a - z).
    /// </summary>
    public class StringCompression
    {
        public string BruteForce(string s)
        {
            if (s.Length == 0)
                return s;

            StringBuilder builder = new StringBuilder();

            var prevC = s[0];
            var count = 1;
            for(int i = 1; i < s.Length; i++)
            {
                var c = s[i];
                if (c == prevC)
                {
                    count++;
                    if(i == s.Length - 1)
                    {
                        builder.Append(c);
                        builder.Append(count);
                    }
                }
                else
                {
                    builder.Append(prevC);
                    builder.Append(count);
                    prevC = c;
                    count = 1;
                }
            }

            var result = builder.ToString();
            if (result.Length > s.Length)
                result = s;

            return result;
        }
    }
}
