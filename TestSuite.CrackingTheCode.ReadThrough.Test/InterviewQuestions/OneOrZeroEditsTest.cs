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
    public class OneOrZeroEditsTest
    {
        private OneOrZeroEdits sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new OneOrZeroEdits();
        }

        [TestMethod]
        public void TestOptimized_Equal()
        {
            // Arrange
            var s1 = "abcdefghi";
            var s2 = "abcdefghi";

            // Act
            var result = sut.Optimized(s1, s2);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimized_Length()
        {
            // Arrange
            var s1 = "abcdefghijk";
            var s2 = "abcdefghi";

            // Act
            var result1 = sut.Optimized(s1, s2);
            var result2 = sut.Optimized(s2, s1);

            // Assert
            result1.ShouldBeFalse();
            result2.ShouldBeFalse();
        }

        [TestMethod]
        public void TestOptimized_Add()
        {
            // Arrange
            var s1 = "abcdefghij";
            var s2 = "abcdefghi";

            // Act
            var result = sut.Optimized(s1, s2);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimized_Insert()
        {
            // Arrange
            var s1 = "abcdefghij";
            var s2 = "abcefghij";

            // Act
            var result = sut.Optimized(s1, s2);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimized_Replace()
        {
            // Arrange
            var s1 = "bbcdefghi";
            var s2 = "abcdefghi";

            // Act
            var result = sut.Optimized(s1, s2);

            // Assert
            result.ShouldBeTrue();
        }
    }
}
