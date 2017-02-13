using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.LinkedLists
{
    [TestClass]
    public class PalindromeTest
    {
        private Palindrome sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new Palindrome();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 });

            // Act
            var result = sut.BruteForce(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestBruteForceSingly()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 });

            // Act
            var result = sut.BruteForce(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimizedSingly()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 });

            // Act
            var result = sut.Optimized(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimizedSingly1()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1 });

            // Act
            var result = sut.Optimized(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimizedSingly2()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 1 });

            // Act
            var result = sut.Optimized(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestOptimizedSingly3()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 1 });

            // Act
            var result = sut.Optimized(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursive()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 });

            // Act
            var result = sut.Recursive(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursive2()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 1 });

            // Act
            var result = sut.Recursive(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursive1()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1 });

            // Act
            var result = sut.Recursive(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursive3()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 1 });

            // Act
            var result = sut.Recursive(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursiveSeek()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 });

            // Act
            var result = sut.RecursiveSeek(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursiveSeek2()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 1 });

            // Act
            var result = sut.RecursiveSeek(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursiveSeek1()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1 });

            // Act
            var result = sut.RecursiveSeek(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursiveSeek3()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 1 });

            // Act
            var result = sut.RecursiveSeek(linkedList);

            // Assert
            result.ShouldBeTrue();
        }

        [TestMethod]
        public void TestRecursiveSeek4()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 });

            // Act
            var result = sut.RecursiveSeek(linkedList);

            // Assert
            result.ShouldBeTrue();
        }
    }
}
