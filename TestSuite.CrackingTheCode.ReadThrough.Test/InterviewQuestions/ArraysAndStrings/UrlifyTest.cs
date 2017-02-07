using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.ArraysAndStrings
{
    [TestClass]
    public class UrlifyTest
    {
        private Urlify sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new Urlify();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var s = "Mr John Smith    ".ToCharArray();
            var stringLength = 13;

            // Act
            sut.BruteForce(s, stringLength);
            var result = new string(s);

            // Assert
            result.ShouldEqual("Mr%20John%20Smith");

            // Analyze
            sut.Counter.Print(s.Length + s.Length);
        }

        [TestMethod]
        public void TestBruteForce_Long()
        {
            // Arrange
            var s = "Mr John Smith Mr John Smith Mr John Smith Mr John Smith                      ".ToCharArray();
            var stringLength = 55;

            // Act
            sut.BruteForce(s, stringLength);
            var result = new string(s);

            // Assert
            result.ShouldEqual("Mr%20John%20Smith%20Mr%20John%20Smith%20Mr%20John%20Smith%20Mr%20John%20Smith");

            // Analyze
            sut.Counter.Print(s.Length + s.Length);
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var s = "Mr John Smith    ".ToCharArray();
            var stringLength = 13;

            // Act
            sut.Optimized(s, stringLength);
            var result = new string(s);

            // Assert
            result.ShouldEqual("Mr%20John%20Smith");

            // Analyze
            sut.Counter.Print(s.Length + s.Length);
        }

        [TestMethod]
        public void TestOptimized_Long()
        {
            // Arrange
            var s = "Mr John Smith Mr John Smith Mr John Smith Mr John Smith                      ".ToCharArray();
            var stringLength = 55;

            // Act
            sut.Optimized(s, stringLength);
            var result = new string(s);

            // Assert
            result.ShouldEqual("Mr%20John%20Smith%20Mr%20John%20Smith%20Mr%20John%20Smith%20Mr%20John%20Smith");

            // Analyze
            sut.Counter.Print(s.Length + s.Length);
        }

        [TestMethod]
        public void TestOptimizedBetter()
        {
            // Arrange
            var s = "Mr John Smith    ".ToCharArray();
            var stringLength = 13;

            // Act
            sut.OptimizedBetter(s, stringLength);
            var result = new string(s);

            // Assert
            result.ShouldEqual("Mr%20John%20Smith");

            // Analyze
            sut.Counter.Print(s.Length + s.Length);
        }

        [TestMethod]
        public void TestOptimizedBetter_Long()
        {
            // Arrange
            var s = "Mr John Smith Mr John Smith Mr John Smith Mr John Smith                      ".ToCharArray();
            var stringLength = 55;

            // Act
            sut.OptimizedBetter(s, stringLength);
            var result = new string(s);

            // Assert
            result.ShouldEqual("Mr%20John%20Smith%20Mr%20John%20Smith%20Mr%20John%20Smith%20Mr%20John%20Smith");

            // Analyze
            sut.Counter.Print(s.Length + s.Length);
        }
    }
}
