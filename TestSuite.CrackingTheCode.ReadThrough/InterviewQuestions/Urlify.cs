using System;
using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions
{
    /// <summary>
    /// URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
    /// has sufficient space at the end to hold the additional characters, and that you are given the "true"
    /// length of the string. (Note: If implementing in Java, please use a character array so that you can
    /// perform this operation in place.)
    /// EXAMPLE
    /// Input: "Mr John Smith    ", 13
    /// Output: "Mr%20John%20Smith"
    /// </summary>
    public class Urlify
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        public void BruteForce(char[] s, int length)
        {
            for(var i = length - 1; i >= 0; i--)
            {
                this.Counter.Increment();

                if (s[i] == ' ')
                {
                    MoveRight(s, i + 1, 2);
                    s[i + 2] = '0';
                    s[i + 1] = '2';
                    s[i] = '%';
                }
            }
        }

        private void MoveRight(char[] s, int startIndex, int right)
        {
            for (var i = s.Length - right - 1; i >= startIndex; i--)
            {
                this.Counter.Increment();

                s[i + right] = s[i];
            }
        }

        public void Optimized(char[] s, int stringLength)
        {
            int spaceCount = 0;
            for(int i = 0; i < stringLength; i++)
            {
                this.Counter.Increment();
                if (s[i] == ' ')
                    spaceCount++;
            }

            int lastMovedIndex = stringLength - 1;
            for(int i = stringLength - 1; i >= 0; i--)
            {
                if (spaceCount == 0)
                    break;

                this.Counter.Increment();

                if (s[i] == ' ')
                {
                    var spaces = spaceCount * 2;
                    MoveRight(s, i + 1, lastMovedIndex, spaces);
                    lastMovedIndex = i - 1;
                    spaceCount--;

                    s[i + spaces] = '0';
                    s[i + spaces - 1] = '2';
                    s[i + spaces - 2] = '%';
                }
            }
        }

        public void OptimizedBetter(char[] s, int stringLength)
        {
            int spaceCount = 0;
            for (int i = 0; i < stringLength; i++)
            {
                this.Counter.Increment();
                if (s[i] == ' ')
                    spaceCount++;
            }

            var index = stringLength + (spaceCount * 2) - 1;
            for(int i = stringLength - 1; i >= 0; i--)
            {
                this.Counter.Increment();

                var c = s[i];
                if(c == ' ')
                {
                    s[index] = '0';
                    s[index - 1] = '2';
                    s[index - 2] = '%';
                    index -= 3;
                }
                else
                {
                    s[index] = c;
                    index--;
                }
            }
        }

        public void MoveRight(char[] s, int startIndex, int endIndex, int right)
        {
            for(int i = endIndex; i >= startIndex; i --)
            {
                this.Counter.Increment();

                s[i + right] = s[i];
            }
        }
    }
}
