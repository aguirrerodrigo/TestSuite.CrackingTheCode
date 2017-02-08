using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.LinkedLists;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.LinkedLists
{
    [TestClass]
    public class PartitionTest
    {
        private Partition sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new Partition();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var input = new int[] { 3, 5, 8, 5, 10, 2, 1 };
            var linkedList = new LinkedList<int>(input);

            // Act
            sut.BruteForce(linkedList, 5);
            var result = linkedList.ToArray();

            // Assert
            result.ShouldEqual(3, 2, 1, 5, 10, 5, 8);
        }

        [TestMethod]
        public void TestBruteForce2()
        {
            // Arrange
            var input = new int[] { 7, 3, 5, 8, 5, 10, 2, 1 };
            var linkedList = new LinkedList<int>(input);

            // Act
            sut.BruteForce(linkedList, 5);
            var result = linkedList.ToArray();

            // Assert
            result.ShouldEqual(3, 2, 1, 8, 5, 10, 7, 5);
        }
    }
}
