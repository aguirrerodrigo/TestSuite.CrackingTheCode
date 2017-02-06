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

        [TestMethod]
        public void TestNLogNCorrect()
        {
            // Arrange
            var s1 = "abbc";
            var s2 = "cabb";

            // Act
            var result = sut.NLogNCorrect(s1, s2);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestNCorrect()
        {
            // Arrange
            var s1 = "abbc";
            var s2 = "cabb";

            // Act
            var result = sut.NCorrect(s1, s2);

            // Assert
            result.ShouldBeTrue();
        }
    }
}
