namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings
{
    /// <summary>
    /// Assume you have a method isSubst ring which checks if one word is a substring
    /// of another. Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one
    /// call to isSubstring(e.g., "waterbottle" is a rotation of"erbottlewat").
    /// </summary>
    public class StringRotation
    {
        public bool IsRotation(string s1, string s2)
        {
            if (s1 == null || s2 == null || s1.Length != s2.Length)
                return false;

            if (s1 == s2)
                return true;

            var concat = string.Concat(s2, s2);
            return concat.Contains(s1);
        }
    }
}