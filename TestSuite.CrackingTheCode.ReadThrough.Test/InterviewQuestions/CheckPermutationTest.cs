using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions
{
    [TestClass]
    public class CheckPermutationTest
    {
        private CheckPermutation sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new CheckPermutation();
        }

        [TestMethod]
        public void TestNLogN()
        {
            // Arrange
            var shorter = "abbc";
            var longer = "cdefghijklmnobabc";

            // Act
            var result = sut.NLogN(shorter, longer);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestN()
        {
            // Arrange
            var shorter = "abbc";
            var longer = "cdefghijklmnobabc";

            // Act
            var result = sut.N(shorter, longer);

            // Assert
            result.ShouldBeTrue();
        }
    }
}
