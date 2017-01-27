using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions
{
    [TestClass]
    public class AllUniqueTest
    {
        private AllUnique sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new AllUnique();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZa";

            // Act
            var result = sut.BruteForce(s);

            // Assert
            result.ShouldBeFalse();

            // Analyze
            sut.Counter.Print(s.Length * s.Length);
        }

        [TestMethod]
        public void HashSet()
        {
            // Arrange
            var s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZa";

            // Act
            var result = sut.HashSet(s);

            // Assert
            result.ShouldBeFalse();

            // Analyze
            sut.Counter.Print(s.Length);
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZa";

            // Act
            var result = sut.Optimized(s);

            // Assert
            result.ShouldBeFalse();

            // Analyze
            sut.Counter.Print(s.Length);
        }

        [TestMethod]
        public void TestNoDataStructure()
        {
            // Arrange
            var s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZa";

            // Act
            var result = sut.NoDataStructure(s);

            // Assert
            result.ShouldBeFalse();

            // Analyze
            sut.Counter.Print(s.Length);
        }
    }
}
