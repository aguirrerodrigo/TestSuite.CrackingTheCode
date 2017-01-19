using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.TechnicalQuestions
{
    [TestClass]
    public class DifferenceKTest
    {
        private DifferenceK sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new DifferenceK();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var k = 2;
            var n = new int[] { 1, 7, 5, 9, 2, 12, 3 };

            // Act
            var result = sut.BruteForce(k, n);

            // Assert
            result[0].ShouldEqual(1, 3);
            result[1].ShouldEqual(7, 9);
            result[2].ShouldEqual(5, 7);
            result[3].ShouldEqual(3, 5);

            // Analyze
            sut.Counter.Print(n.Length * n.Length);
        }

        [TestMethod]
        public void TestSortFirst()
        {
            // Arrange
            var k = 2;
            var n = new int[] { 1, 7, 5, 9, 2, 12, 3 };

            // Act
            var result = sut.SortFirst(k, n);

            // Assert
            result[0].ShouldEqual(1, 3);
            result[1].ShouldEqual(3, 5);
            result[2].ShouldEqual(5, 7);
            result[3].ShouldEqual(7, 9);

            // Analyze
            sut.Counter.Print(n.Length * k);
        }

        [TestMethod]
        public void TestHashSet()
        {
            // Arrange
            var k = 2;
            var n = new int[] { 1, 7, 5, 9, 2, 12, 3 };

            // Act
            var result = sut.HashSet(k, n);

            // Assert
            result[0].ShouldEqual(1, 3);
            result[1].ShouldEqual(7, 9);
            result[2].ShouldEqual(5, 7);
            result[3].ShouldEqual(3, 5);

            // Analyze
            sut.Counter.Print(n.Length);
        }

        [TestMethod]
        public void TestSortedSet()
        {
            // Arrange
            var k = 2;
            var n = new int[] { 1, 7, 5, 9, 2, 12, 3 };

            // Act
            var result = sut.SortedSet(k, n);

            // Assert
            result[0].ShouldEqual(1, 3);
            result[1].ShouldEqual(3, 5);
            result[2].ShouldEqual(5, 7);
            result[3].ShouldEqual(7, 9);

            // Analyze
            sut.Counter.Print(n.Length);
        }
    }
}
