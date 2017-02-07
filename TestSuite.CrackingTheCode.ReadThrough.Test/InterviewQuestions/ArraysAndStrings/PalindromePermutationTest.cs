using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.ArraysAndStrings
{
    [TestClass]
    public class PalindromePermutationTest
    {
        private PalindromePermutation sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new PalindromePermutation();
        }
        
        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var s = "Tact coa";

            // Act
            var result = sut.Optimized(s);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimizedNoToLower()
        {
            // Arrange
            var s = "Tact coazZ";

            // Act
            var result = sut.OptimizedNoToLower(s);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimizedBitVector()
        {
            // Arrange
            var s = "Tact coazZ";

            // Act
            var result = sut.OptimizedBitVector(s);

            // Assert
            result.ShouldBeTrue();
        }

    }
}
