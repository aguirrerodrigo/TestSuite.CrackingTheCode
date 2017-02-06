using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions
{
    [TestClass]
    public class StringCompressionTest
    {
        private StringCompression sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new StringCompression();
        }

        [TestMethod]
        public void TestBruteForce_SameString()
        {
            // Arrange
            var s = "abcdefghi";

            // Act
            var result = sut.BruteForce(s);

            // Assert
            result.ShouldEqual("abcdefghi");
        }

        [TestMethod]
        public void TestBruteForce_Compress()
        {
            // Arrange
            var s = "aabcccccaaa";

            // Act
            var result = sut.BruteForce(s);

            // Assert
            result.ShouldEqual("a2b1c5a3");
        }

        [TestMethod]
        public void TestOptimized_SameString()
        {
            // Arrange
            var s = "abcdefghi";

            // Act
            var result = sut.Optimized(s);

            // Assert
            result.ShouldEqual("abcdefghi");
        }

        [TestMethod]
        public void TestOptimizede_Compress()
        {
            // Arrange
            var s = "aabcccccaaa";

            // Act
            var result = sut.Optimized(s);

            // Assert
            result.ShouldEqual("a2b1c5a3");
        }
    }
}
