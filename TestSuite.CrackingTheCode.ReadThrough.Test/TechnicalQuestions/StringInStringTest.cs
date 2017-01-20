using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.TechnicalQuestions
{
    [TestClass]
    public class StringInStringTest
    {
        private StringInString sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new StringInString();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var s = "abbc";
            var b = "cbabadcbbabbcbabaabccbabc";

            // Act
            var result = sut.BruteForce(s, b);

            // Assert
            result[0].ShouldEqual(0);
            result[1].ShouldEqual(6);
            result[2].ShouldEqual(9);
            result[3].ShouldEqual(11);
            result[4].ShouldEqual(12);
            result[5].ShouldEqual(20);
            result[6].ShouldEqual(21);

            // Analyze
            sut.Counter.Print(Factorial(s.Length) + b.Length);
        }

        [TestMethod]
        public void TestBruteForce_Mid()
        {
            // Arrange
            var s = "cbabadcbbabb";
            var b = "cbabadcbbabbcbabaabccbabc";

            // Act
            var result = sut.BruteForce(s, b);

            // Analyze
            sut.Counter.Print(Factorial(s.Length) + b.Length);
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var s = "abbc";
            var b = "cbabadcbbabbcbabaabccbabc";

            // Act
            var result = sut.Optimized(s, b);

            // Assert
            result[0].ShouldEqual(0);
            result[1].ShouldEqual(6);
            result[2].ShouldEqual(9);
            result[3].ShouldEqual(11);
            result[4].ShouldEqual(12);
            result[5].ShouldEqual(20);
            result[6].ShouldEqual(21);

            // Analyze
            sut.Counter.Print(s.Length * b.Length);
        }

        [TestMethod]
        public void TestOptimized_Mid()
        {
            // Arrange
            var s = "cbabadcbbabb";
            var b = "cbabadcbbabbcbabaabccbabc";

            // Act
            var result = sut.Optimized(s, b);

            // Analyze
            sut.Counter.Print(s.Length * b.Length);
        }

        private int Factorial(int n)
        {
            if (n < 0)
                throw new InvalidOperationException("negative numbers not supported.");

            var result = 1;
            for (var i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
