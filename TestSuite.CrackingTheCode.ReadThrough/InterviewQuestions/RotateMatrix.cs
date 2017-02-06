using System;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions
{
    /// <summary>
    /// Given an image represented by an NxN matrix, where each pixel in the image is 4
    /// bytes, write a method to rotate the image by 90 degrees. Can you do this in place?
    /// </summary>
    public class RotateMatrix
    {
        public int[][] BruteForce(int[][] matrix, int size)
        {
            var result = new int[size][];
            for(int i = 0; i < size; i++)
            {
                result[i] = new int[size];
            }

            for(var row = 0; row < size; row++)
            {
                for(var column = 0; column < size; column++)
                {
                    result[size - column - 1][row] = matrix[row][column];
                }
            }

            return result;
        }

        public Matrix<int> BruteForce(Matrix<int> matrix)
        {
            var result = new Matrix<int>(matrix.Columns, matrix.Rows);
            
            for (var row = 0; row < result.Rows; row++)
            {
                for (var column = 0; column < result.Columns; column++)
                {
                    result[row, column] = matrix[result.Columns - column - 1, row];
                }
            }

            return result;
        }

        public void InPlace(int[][] matrix, int size)
        {
            for (var row = 0; row < size / 2; row++)
            {
                for (var column = row; column < size - row - 1; column++)
                {
                    var n = matrix[row][column];
                    matrix[row][column] = matrix[column][size - row - 1];
                    matrix[column][size - row - 1] = matrix[size - row - 1][size - column - 1];
                    matrix[size - row - 1][size - column - 1] = matrix[size - column - 1][row];
                    matrix[size - column - 1][row] = n;
                }
            }
        }

        public void InPlace(Matrix<int> matrix)
        {
            for (var row = 0; row < matrix.Rows / 2; row++)
            {
                for (var column = row; column < matrix.Columns - row - 1; column++)
                {
                    var n = matrix[row, column];
                    matrix[row, column] = matrix[matrix.Rows - column - 1, row];
                    matrix[matrix.Rows - column - 1, row] = matrix[matrix.Rows - row - 1, matrix.Columns - column - 1];
                    matrix[matrix.Rows - row - 1, matrix.Columns - column - 1] = matrix[column, matrix.Columns - row - 1];
                    matrix[column, matrix.Columns - row - 1] = n;
                }
            }
        }
    }
}