using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.TechnicalQuestions
{
    [TestClass]
    public class TwoSortedArraysTest
    {
        private TwoSortedArrays sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new TwoSortedArrays();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var a = new int[] { 13, 27, 35, 40, 49, 55, 59 };
            var b = new int[] { 17, 35, 39, 40, 55, 58, 60 };

            // Act
            var result = sut.BruteForce(a, b);

            // Assert
            result[0].ShouldEqual(35);
            result[1].ShouldEqual(40);
            result[2].ShouldEqual(55);

            // Analyze
            sut.Counter.Print(a.Length * b.Length);
        }

        [TestMethod]
        public void TestHashSet()
        {
            // Arrange
            var a = new int[] { 13, 27, 35, 40, 49, 55, 59 };
            var b = new int[] { 17, 35, 39, 40, 55, 58, 60 };

            // Act
            var result = sut.HashSet(a, b);

            // Assert
            result[0].ShouldEqual(35);
            result[1].ShouldEqual(40);
            result[2].ShouldEqual(55);

            // Analyze
            sut.Counter.Print(b.Length);
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var a = new int[] { 13, 27, 35, 40, 49, 55, 59 };
            var b = new int[] { 17, 35, 39, 40, 55, 58, 60 };

            // Act
            var result = sut.Optimized(a, b);

            // Assert
            result[0].ShouldEqual(35);
            result[1].ShouldEqual(40);
            result[2].ShouldEqual(55);

            // Analyze
            sut.Counter.Print(b.Length);
        }
    }
}
