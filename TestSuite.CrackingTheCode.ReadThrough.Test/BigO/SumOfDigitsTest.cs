using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.BigO;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.BigO
{
    [TestClass]
    public class SumOfDigitsTest
    {
        private SumOfDigits sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new SumOfDigits();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var n = 123456789;

            // Assert
            var result = sut.BruteForce(n);

            // Act
            result.ShouldEqual(45);
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var n = 123456789;

            // Assert
            var result = sut.Optimized(n);

            // Act
            result.ShouldEqual(45);
        }

        [TestMethod]
        public void TestOptimized_1()
        {
            // Arrange
            var n = 1;

            // Assert
            var result = sut.Optimized(n);

            // Act
            result.ShouldEqual(1);
        }
    }
}
