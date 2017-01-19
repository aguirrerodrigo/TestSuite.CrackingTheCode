using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.TechnicalQuestions
{
    [TestClass]
    public class StringPermutationsTest
    {
        private StringPermutations sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new StringPermutations();
        }

        [TestMethod]
        public void TestA()
        {
            // Arrange
            var s = "a";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result[0].ShouldEqual("a");

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
            sut.Counter.Print(Factorial(s.Length));
        }

        [TestMethod]
        public void TestAB()
        {
            // Arrange
            var s = "ab";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result[0].ShouldEqual("ba");
            result[1].ShouldEqual("ab");

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
            sut.Counter.Print(Factorial(s.Length));
        }

        [TestMethod]
        public void TestABC()
        {
            // Arrange
            var s = "abc";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result.Length.ShouldEqual(Factorial(s.Length));

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
            sut.Counter.Print(Factorial(s.Length));
        }

        [TestMethod]
        public void TestABCD()
        {
            // Arrange
            var s = "abcd";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result.Length.ShouldEqual(Factorial(s.Length));

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
            sut.Counter.Print(Factorial(s.Length));
        }

        [TestMethod]
        public void TestABCDE()
        {
            // Arrange
            var s = "abcde";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result.Length.ShouldEqual(Factorial(s.Length));

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
            sut.Counter.Print(Factorial(s.Length));
        }

        [TestMethod]
        public void TestABCDEF()
        {
            // Arrange
            var s = "abcdef";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result.Length.ShouldEqual(Factorial(s.Length));

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
            sut.Counter.Print(Factorial(s.Length));
        }

        [TestMethod]
        public void TestABCDEFG()
        {
            // Arrange
            var s = "abcdefg";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result.Length.ShouldEqual(Factorial(s.Length));

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
            sut.Counter.Print(Factorial(s.Length));
        }

        [TestMethod]
        public void TestABCDEFGH()
        {
            // Arrange
            var s = "abcdefgh";

            // Act
            var result = sut.GetPermutations(s);

            // Assert
            result.Length.ShouldEqual(Factorial(s.Length));

            // Analyze
            foreach (var p in result)
                Console.WriteLine(p);
        }

        private int Factorial(int n)
        {
            if (n < 0)
                throw new InvalidOperationException("Negative numbers not supported.");

            var result = 1;
            for (var i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
