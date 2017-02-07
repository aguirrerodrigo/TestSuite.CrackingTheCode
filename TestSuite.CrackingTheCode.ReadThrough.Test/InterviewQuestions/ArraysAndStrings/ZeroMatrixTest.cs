using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.ArraysAndStrings
{
    [TestClass]
    public class ZeroMatrixTest
    {
        private ZeroMatrix sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new ZeroMatrix();
        }

        [TestMethod]
        public void TestBruteForce()
        {
            // Arrange
            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 0, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };
            matrix[4] = new int[] { 17, 18, 19, 0 };

            // Act
            var result = sut.BruteForce(matrix);

            // Assert
            result[0].ShouldEqual(new int[] { 1, 0, 3, 0 });
            result[1].ShouldEqual(new int[] { 5, 0, 7, 0 });
            result[2].ShouldEqual(new int[] { 0, 0, 0, 0 });
            result[3].ShouldEqual(new int[] { 13, 0, 15, 0 });
            result[4].ShouldEqual(new int[] { 0, 0, 0, 0 });
        }

        [TestMethod]
        public void TestBruteForce_Overlap()
        {
            // Arrange
            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 0, 3, 0 };
            matrix[1] = new int[] { 0, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };
            matrix[4] = new int[] { 17, 18, 19, 20 };

            // Act
            var result = sut.BruteForce(matrix);

            // Assert
            result[0].ShouldEqual(new int[] { 0, 0, 0, 0 });
            result[1].ShouldEqual(new int[] { 0, 0, 0, 0 });
            result[2].ShouldEqual(new int[] { 0, 0, 11, 0 });
            result[3].ShouldEqual(new int[] { 0, 0, 15, 0 });
            result[4].ShouldEqual(new int[] { 0, 0, 19, 0 });
        }

        [TestMethod]
        public void TestUseQueue()
        {
            // Arrange
            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 0, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };
            matrix[4] = new int[] { 17, 18, 19, 0 };

            // Act
            sut.UseQueue(matrix);

            // Assert
            matrix[0].ShouldEqual(new int[] { 1, 0, 3, 0 });
            matrix[1].ShouldEqual(new int[] { 5, 0, 7, 0 });
            matrix[2].ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix[3].ShouldEqual(new int[] { 13, 0, 15, 0 });
            matrix[4].ShouldEqual(new int[] { 0, 0, 0, 0 });
        }

        [TestMethod]
        public void TestUseQueue_Overlap()
        {
            // Arrange
            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 0, 3, 0 };
            matrix[1] = new int[] { 0, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };
            matrix[4] = new int[] { 17, 18, 19, 20 };

            // Act
            sut.UseQueue(matrix);

            // Assert
            matrix[0].ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix[1].ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix[2].ShouldEqual(new int[] { 0, 0, 11, 0 });
            matrix[3].ShouldEqual(new int[] { 0, 0, 15, 0 });
            matrix[4].ShouldEqual(new int[] { 0, 0, 19, 0 });
        }

        [TestMethod]
        public void TestOptimized()
        {
            // Arrange
            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 0, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };
            matrix[4] = new int[] { 17, 18, 19, 0 };

            // Act
            sut.Optimized(matrix);

            // Assert
            matrix[0].ShouldEqual(new int[] { 1, 0, 3, 0 });
            matrix[1].ShouldEqual(new int[] { 5, 0, 7, 0 });
            matrix[2].ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix[3].ShouldEqual(new int[] { 13, 0, 15, 0 });
            matrix[4].ShouldEqual(new int[] { 0, 0, 0, 0 });
        }

        [TestMethod]
        public void TestOptimized_Overlap()
        {
            // Arrange
            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 0, 3, 0 };
            matrix[1] = new int[] { 0, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };
            matrix[4] = new int[] { 17, 18, 19, 20 };

            // Act
            sut.Optimized(matrix);

            // Assert
            matrix[0].ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix[1].ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix[2].ShouldEqual(new int[] { 0, 0, 11, 0 });
            matrix[3].ShouldEqual(new int[] { 0, 0, 15, 0 });
            matrix[4].ShouldEqual(new int[] { 0, 0, 19, 0 });
        }

        [TestMethod]
        public void TestOptimized2()
        {
            // Arrange
            var matrix = new Matrix<int>(5, 4);
            matrix.SetRow(0, new int[] { 1, 2, 3, 4 });
            matrix.SetRow(1, new int[] { 5, 6, 7, 8 });
            matrix.SetRow(2, new int[] { 9, 0, 11, 12 });
            matrix.SetRow(3, new int[] { 13, 14, 15, 16 });
            matrix.SetRow(4, new int[] { 17, 18, 19, 0 });
            
            // Act
            sut.Optimized2(matrix);

            // Assert
            matrix.GetRow(0).ShouldEqual(new int[] { 1, 0, 3, 0 });
            matrix.GetRow(1).ShouldEqual(new int[] { 5, 0, 7, 0 });
            matrix.GetRow(2).ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix.GetRow(3).ShouldEqual(new int[] { 13, 0, 15, 0 });
            matrix.GetRow(4).ShouldEqual(new int[] { 0, 0, 0, 0 });
        }

        [TestMethod]
        public void TestOptimized2_Overlap()
        {
            // Arrange
            var matrix = new Matrix<int>(5, 4);
            matrix.SetRow(0, new int[] { 1, 0, 3, 0 });
            matrix.SetRow(1, new int[] { 0, 6, 7, 8 });
            matrix.SetRow(2, new int[] { 9, 10, 11, 12 });
            matrix.SetRow(3, new int[] { 13, 14, 15, 16 });
            matrix.SetRow(4, new int[] { 17, 18, 19, 20 });

            // Act
            sut.Optimized2(matrix);

            // Assert
            matrix.GetRow(0).ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix.GetRow(1).ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix.GetRow(2).ShouldEqual(new int[] { 0, 0, 11, 0 });
            matrix.GetRow(3).ShouldEqual(new int[] { 0, 0, 15, 0 });
            matrix.GetRow(4).ShouldEqual(new int[] { 0, 0, 19, 0 });
        }

        [TestMethod]
        public void TestOptimized3()
        {
            // Arrange
            var matrix = new Matrix<int>(5, 4);
            matrix.SetRow(0, new int[] { 1, 2, 3, 4 });
            matrix.SetRow(1, new int[] { 5, 6, 7, 8 });
            matrix.SetRow(2, new int[] { 9, 0, 11, 12 });
            matrix.SetRow(3, new int[] { 13, 14, 15, 16 });
            matrix.SetRow(4, new int[] { 17, 18, 19, 0 });

            // Act
            sut.Optimized3(matrix);

            // Assert
            matrix.GetRow(0).ShouldEqual(new int[] { 1, 0, 3, 0 });
            matrix.GetRow(1).ShouldEqual(new int[] { 5, 0, 7, 0 });
            matrix.GetRow(2).ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix.GetRow(3).ShouldEqual(new int[] { 13, 0, 15, 0 });
            matrix.GetRow(4).ShouldEqual(new int[] { 0, 0, 0, 0 });
        }

        [TestMethod]
        public void TestOptimized3_Overlap()
        {
            // Arrange
            var matrix = new Matrix<int>(5, 4);
            matrix.SetRow(0, new int[] { 1, 0, 3, 0 });
            matrix.SetRow(1, new int[] { 0, 6, 7, 8 });
            matrix.SetRow(2, new int[] { 9, 10, 11, 12 });
            matrix.SetRow(3, new int[] { 13, 14, 15, 16 });
            matrix.SetRow(4, new int[] { 17, 18, 19, 20 });

            // Act
            sut.Optimized3(matrix);

            // Assert
            matrix.GetRow(0).ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix.GetRow(1).ShouldEqual(new int[] { 0, 0, 0, 0 });
            matrix.GetRow(2).ShouldEqual(new int[] { 0, 0, 11, 0 });
            matrix.GetRow(3).ShouldEqual(new int[] { 0, 0, 15, 0 });
            matrix.GetRow(4).ShouldEqual(new int[] { 0, 0, 19, 0 });
        }
    }
}
