using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.TechnicalQuestions
{
    [TestClass]
    public class EqualPolynomialsTest
    {
        private EqualPolynomials sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new EqualPolynomials();
        }

        [TestMethod]
        [Ignore]
        [TestCategory("Very Slow")]
        public void TestBruteForce()
        {
            // Arrange
            var sut = new EqualPolynomials();
            var min = 1;
            var max = 100;

            // Act
            var result = sut.BruteForce(min, max);

            // Assert
            Console.WriteLine($"Number of results: {result.Length}.");
            foreach(var n in result)
            {
                Console.WriteLine($"{n[0]}^3 + {n[1]}^3 = {n[2]}^3 + {n[3]}^3");
            }

            // Analyze
            sut.Counter.Print(max * max * max * max);
        }

        [TestMethod]
        public void TestCalculateForD()
        {
            // Arrange
            var sut = new EqualPolynomials();
            var min = 1;
            var max = 100;

            // Act
            var result = sut.CalculateForD(min, max);

            // Assert
            Console.WriteLine($"Number of results: {result.Length}.");
            foreach (var n in result)
            {
                Console.WriteLine($"{n[0]}^3 + {n[1]}^3 = {n[2]}^3 + {n[3]}^3");
            }

            // Analyze
            sut.Counter.Print(max * max * max);
        }

        [TestMethod]
        public void TestOptimized1()
        {
            // Arrange
            var sut = new EqualPolynomials();
            var min = 1;
            var max = 100;

            // Act
            var result = sut.Optimized1(min, max);

            // Assert
            Console.WriteLine($"Number of results: {result.Length}.");
            foreach (var n in result)
            {
                Console.WriteLine($"{n[0]}^3 + {n[1]}^3 = {n[2]}^3 + {n[3]}^3");
            }

            // Analyze
            sut.Counter.Print(max * max);
        }

        [TestMethod]
        public void TestOptimized2()
        {
            // Arrange
            var sut = new EqualPolynomials();
            var min = 1;
            var max = 100;

            // Act
            var result = sut.Optimized2(min, max);

            // Assert
            Console.WriteLine($"Number of results: {result.Length}.");
            foreach (var n in result)
            {
                Console.WriteLine($"{n[0]}^3 + {n[1]}^3 = {n[2]}^3 + {n[3]}^3");
            }

            // Analyze
            sut.Counter.Print(max * max);
        }
    }
}
