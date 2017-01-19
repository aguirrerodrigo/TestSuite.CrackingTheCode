using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.BigO;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.BigO
{
    [TestClass]
    public class ReverseArrayTest
    {
        private ReverseArray sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new ReverseArray();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var result = sut.BruteForce(n);

            // Assert
            result[0].ShouldEqual(10);
            result[1].ShouldEqual(9);
            result[2].ShouldEqual(8);
            result[3].ShouldEqual(7);
            result[4].ShouldEqual(6);
            result[5].ShouldEqual(5);
            result[6].ShouldEqual(4);
            result[7].ShouldEqual(3);
            result[8].ShouldEqual(2);
            result[9].ShouldEqual(1);

            // Analyze
            sut.Counter.Print(n.Length);
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var result = sut.Optimized(n);

            // Assert
            result[0].ShouldEqual(10);
            result[1].ShouldEqual(9);
            result[2].ShouldEqual(8);
            result[3].ShouldEqual(7);
            result[4].ShouldEqual(6);
            result[5].ShouldEqual(5);
            result[6].ShouldEqual(4);
            result[7].ShouldEqual(3);
            result[8].ShouldEqual(2);
            result[9].ShouldEqual(1);

            // Analyze
            sut.Counter.Print(n.Length);
        }
    }
}
