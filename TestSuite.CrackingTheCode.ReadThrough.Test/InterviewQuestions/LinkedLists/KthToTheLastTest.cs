using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.LinkedLists
{
    [TestClass]
    public class KthToTheLastTest
    {
        private KthToTheLast sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new KthToTheLast();
        }

        [TestMethod]
        public void TestBruteForce_1()
        {
            // Arrange
            var items = new int[] { 1 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.BruteForce(linkedList, 1);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestBruteForce_12()
        {
            // Arrange
            var items = new int[] { 1, 2 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.BruteForce(linkedList, 2);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestBruteForce_123()
        {
            // Arrange
            var items = new int[] { 1, 2, 3 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.BruteForce(linkedList, 2);

            // Assert
            result.ShouldEqual(2);
        }

        [TestMethod]
        public void TestBruteForce_123456789()
        {
            // Arrange
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.BruteForce(linkedList, 4);

            // Assert
            result.ShouldEqual(6);
        }

        [TestMethod]
        public void TestOptimized_1()
        {
            // Arrange
            var items = new int[] { 1 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Optimized(linkedList, 1);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestOptimized_12()
        {
            // Arrange
            var items = new int[] { 1, 2 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Optimized(linkedList, 2);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestOptimized_123()
        {
            // Arrange
            var items = new int[] { 1, 2, 3 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Optimized(linkedList, 2);

            // Assert
            result.ShouldEqual(2);
        }

        [TestMethod]
        public void TestOptimized_123456789()
        {
            // Arrange
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Optimized(linkedList, 4);

            // Assert
            result.ShouldEqual(6);
        }

        [TestMethod]
        public void TestUseCount_1()
        {
            // Arrange
            var items = new int[] { 1 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.UseCount(linkedList, 1);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestUseCount_12()
        {
            // Arrange
            var items = new int[] { 1, 2 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.UseCount(linkedList, 2);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestUseCount_123()
        {
            // Arrange
            var items = new int[] { 1, 2, 3 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.UseCount(linkedList, 2);

            // Assert
            result.ShouldEqual(2);
        }

        [TestMethod]
        public void TestUseCount_123456789()
        {
            // Arrange
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.UseCount(linkedList, 4);

            // Assert
            result.ShouldEqual(6);
        }

        [TestMethod]
        public void TestPrint_123456789()
        {
            // Arrange
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            sut.Print(linkedList, 4);

            // Assert
        }

        [TestMethod]
        public void TestRecursive_1()
        {
            // Arrange
            var items = new int[] { 1 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Recursive(linkedList, 1);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestRecursive_12()
        {
            // Arrange
            var items = new int[] { 1, 2 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Recursive(linkedList, 2);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestRecursive_123()
        {
            // Arrange
            var items = new int[] { 1, 2, 3 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Recursive(linkedList, 2);

            // Assert
            result.ShouldEqual(2);
        }

        [TestMethod]
        public void TestRecursive_123456789()
        {
            // Arrange
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Recursive(linkedList, 4);

            // Assert
            result.ShouldEqual(6);
        }

        [TestMethod]
        public void TestSeek_1()
        {
            // Arrange
            var items = new int[] { 1 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Seek(linkedList, 1);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestSeek_12()
        {
            // Arrange
            var items = new int[] { 1, 2 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Seek(linkedList, 2);

            // Assert
            result.ShouldEqual(1);
        }

        [TestMethod]
        public void TestSeek_123()
        {
            // Arrange
            var items = new int[] { 1, 2, 3 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Seek(linkedList, 2);

            // Assert
            result.ShouldEqual(2);
        }

        [TestMethod]
        public void TestSeek_123456789()
        {
            // Arrange
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var linkedList = new MyLinkedList<int>(items);

            // Act
            var result = sut.Seek(linkedList, 4);

            // Assert
            result.ShouldEqual(6);
        }
    }
}
