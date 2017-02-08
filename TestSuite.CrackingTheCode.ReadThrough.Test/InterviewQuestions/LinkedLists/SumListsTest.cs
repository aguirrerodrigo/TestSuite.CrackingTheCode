using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.LinkedLists
{
    [TestClass]
    public class SumListsTest
    {
        private SumLists sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new SumLists();
        }
        
        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var linkedList1 = new LinkedList<int>(new int[] { 7, 1, 6 });
            var linkedList2 = new LinkedList<int>(new int[] { 5, 9, 2 });

            // Act
            var result = sut.BruteForce(linkedList1, linkedList2).ToArray();

            // Assert
            result.ShouldEqual(2, 1, 9);
        }

        [TestMethod]
        public void TestBruteForce2()
        {
            // Arrange
            var linkedList1 = new LinkedList<int>(new int[] { 7, 1, 9 });
            var linkedList2 = new LinkedList<int>(new int[] { 5, 9, 2 });

            // Act
            var result = sut.BruteForce(linkedList1, linkedList2).ToArray();

            // Assert
            result.ShouldEqual(2, 1, 2, 1);
        }

        [TestMethod]
        public void TestBruteForce3()
        {
            // Arrange
            var linkedList1 = new LinkedList<int>(new int[] { 7, 1, 6, 8 });
            var linkedList2 = new LinkedList<int>(new int[] { 5, 9, 3 });

            // Act
            var result = sut.BruteForce(linkedList1, linkedList2).ToArray();

            // Assert
            result.ShouldEqual(2, 1, 0, 9);
        }

        [TestMethod]
        public void TestBruteForceReverse()
        {
            // Arrange
            var linkedList1 = new LinkedList<int>(new int[] { 6, 1, 7 });
            var linkedList2 = new LinkedList<int>(new int[] { 2, 9, 5 });

            // Act
            var result = sut.BruteForceReverse(linkedList1, linkedList2).ToArray();

            // Assert
            result.ShouldEqual(9, 1, 2);
        }

        [TestMethod]
        public void TestBruteForceReverse2()
        {
            // Arrange
            var linkedList1 = new LinkedList<int>(new int[] { 9, 1, 7 });
            var linkedList2 = new LinkedList<int>(new int[] { 2, 9, 5 });

            // Act
            var result = sut.BruteForceReverse(linkedList1, linkedList2).ToArray();

            // Assert
            result.ShouldEqual(1, 2, 1, 2);
        }

        [TestMethod]
        public void TestBruteForceReverse3()
        {
            // Arrange
            var linkedList1 = new LinkedList<int>(new int[] { 8, 6, 1, 7 });
            var linkedList2 = new LinkedList<int>(new int[] { 3, 9, 5 });

            // Act
            var result = sut.BruteForceReverse(linkedList1, linkedList2).ToArray();

            // Assert
            result.ShouldEqual(9, 0, 1, 2);
        }
    }
}
