using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions
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
    }
}
