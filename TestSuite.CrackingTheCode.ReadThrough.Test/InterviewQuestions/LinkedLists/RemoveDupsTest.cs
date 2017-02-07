using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.LinkedLists
{
    [TestClass]
    public class RemoveDupsTest
    {
        private RemoveDups sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new RemoveDups();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var collection = new int[] { 1, 2, 1, 3, 4, 2, 5, 6 };
            var linkedList = new LinkedList<int>(collection);

            // Act
            sut.BruteForce(linkedList);
            var result = linkedList.ToArray();

            result.ShouldEqual(1, 2, 3, 4, 5, 6);
        }

        [TestMethod]
        public void TestNoTempBuffer()
        {
            // Arrange
            var collection = new int[] { 1, 2, 1, 3, 4, 2, 5, 6 };
            var linkedList = new MyLinkedList<int>(collection);

            // Act
            sut.MyNoTempBuffer(linkedList);
            var result = linkedList.ToArray();

            result.ShouldEqual(1, 2, 3, 4, 5, 6);
        }

        [TestMethod]
        public void TestMyBruteForce()
        {
            // Arrange
            var collection = new int[] { 1, 2, 1, 3, 4, 2, 5, 6 };
            var linkedList = new LinkedList<int>(collection);

            // Act
            sut.BruteForce(linkedList);
            var result = linkedList.ToArray();

            result.ShouldEqual(1, 2, 3, 4, 5, 6);
        }

        [TestMethod]
        public void TestMyNoTempBuffer()
        {
            // Arrange
            var collection = new int[] { 1, 2, 1, 3, 4, 2, 5, 6 };
            var linkedList = new LinkedList<int>(collection);

            // Act
            sut.NoTempBuffer(linkedList);
            var result = linkedList.ToArray();

            result.ShouldEqual(1, 2, 3, 4, 5, 6);
        }
    }
}
