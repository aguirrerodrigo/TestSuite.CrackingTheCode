using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.LinkedLists
{
    [TestClass]
    public class DeleteMiddleTest
    {
        private DeleteMiddle sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new DeleteMiddle();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var collection = new int[] { 1, 2, 3, 4, 5, 6 };
            var linkedList = new SinglyLinkedList<int>(collection);

            // Act
            sut.BruteForce(linkedList);
            var result = linkedList.ToArray();

            // Assert
            result.ShouldEqual(1, 2, 4, 5, 6);
        }

        [TestMethod]
        public void TestBruteForceCorrect()
        {
            // Arrange
            var collection = new int[] { 1, 2, 3, 4, 5, 6 };
            var linkedList = new SinglyLinkedList<int>(collection);

            // Act
            sut.BruteForceCorrect(linkedList, 5);
            var result = linkedList.ToArray();

            // Assert
            result.ShouldEqual(1, 2, 3, 4, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TestBruteForceCorrect6()
        {
            // Arrange
            var collection = new int[] { 1, 2, 3, 4, 5, 6 };
            var linkedList = new SinglyLinkedList<int>(collection);

            // Act
            sut.BruteForceCorrect(linkedList, 6);
            var result = linkedList.ToArray();

            // Assert
            result.ShouldEqual(1, 2, 3, 4, 5, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TestBruteForceCorrect1()
        {
            // Arrange
            var collection = new int[] { 1, 2, 3, 4, 5, 6 };
            var linkedList = new SinglyLinkedList<int>(collection);

            // Act
            sut.BruteForceCorrect(linkedList, 1);
            var result = linkedList.ToArray();

            // Assert
            result.ShouldEqual(1, 2, 3, 4, 5, 6);
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var collection = new int[] { 1, 2, 3, 4, 5, 6 };
            var linkedList = new SinglyLinkedList<int>(collection);

            // Act
            sut.Optimized(linkedList);
            var result = linkedList.ToArray();

            // Assert
            result.ShouldEqual(1, 2, 4, 5, 6);
        }
    }
}
