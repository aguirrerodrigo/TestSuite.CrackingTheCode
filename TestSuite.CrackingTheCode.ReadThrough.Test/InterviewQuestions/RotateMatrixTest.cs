﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions
{
    [TestClass]
    public class RotateMatrixTest
    {
        private RotateMatrix sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new RotateMatrix();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var matrix = new int[4][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };

            // Act
            var result = sut.BruteForce(matrix, 4);

            // Assert
            result[0].ShouldEqual(new int[] { 4, 8, 12, 16 });
            result[1].ShouldEqual(new int[] { 3, 7, 11, 15 });
            result[2].ShouldEqual(new int[] { 2, 6, 10, 14 });
            result[3].ShouldEqual(new int[] { 1, 5, 9, 13 });
        }

        [TestMethod]
        public void TestInPlace()
        {

            // Arrange
            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 2, 3, 4, 5 };
            matrix[1] = new int[] { 6, 7, 8, 9, 10 };
            matrix[2] = new int[] { 11, 12, 13, 14, 15 };
            matrix[3] = new int[] { 16, 17, 18, 19, 20 };
            matrix[4] = new int[] { 21, 22, 23, 24, 25 };

            // Act
            sut.InPlace(matrix, 5);

            // Assert
            matrix[0].ShouldEqual(new int[] { 5, 10, 15, 20, 25 });
            matrix[1].ShouldEqual(new int[] { 4, 9, 14, 19, 24 });
            matrix[2].ShouldEqual(new int[] { 3, 8, 13, 18, 23 });
            matrix[3].ShouldEqual(new int[] { 2, 7, 12, 17, 22 });
            matrix[4].ShouldEqual(new int[] { 1, 6, 11, 16, 21 });
        }


        [TestMethod]
        public void TestInPlace2()
        {

            // Arrange
            var matrix = new int[7][];
            matrix[0] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            matrix[1] = new int[] { 8, 9, 10, 11, 12, 13, 14 };
            matrix[2] = new int[] { 15, 16, 17, 18, 19, 20, 21 };
            matrix[3] = new int[] { 22, 23, 24, 25, 26, 27, 28};
            matrix[4] = new int[] { 29, 30, 31, 32, 33, 34, 35 };
            matrix[5] = new int[] { 36, 37, 38, 39, 40, 41, 42 };
            matrix[6] = new int[] { 43, 44, 45, 46, 47, 48, 49 };

            // Act
            sut.InPlace(matrix, 7);

            // Assert
            matrix[0].ShouldEqual(new int[] { 7, 14, 21, 28, 35, 42, 49 });
            matrix[1].ShouldEqual(new int[] { 6, 13, 20, 27, 34, 41, 48 });
            matrix[2].ShouldEqual(new int[] { 5, 12, 19, 26, 33, 40, 47 });
            matrix[3].ShouldEqual(new int[] { 4, 11, 18, 25, 32, 39, 46 });
            matrix[4].ShouldEqual(new int[] { 3, 10, 17, 24, 31, 38, 45 });
            matrix[5].ShouldEqual(new int[] { 2, 9, 16, 23, 30, 37, 44 });
            matrix[6].ShouldEqual(new int[] { 1, 8, 15, 22, 29, 36, 43 });
        }
    }
}