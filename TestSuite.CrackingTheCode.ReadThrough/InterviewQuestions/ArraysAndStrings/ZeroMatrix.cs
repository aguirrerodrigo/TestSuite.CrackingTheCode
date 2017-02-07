using System;
using System.Collections.Generic;

namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings
{
    /// <summary>
    /// Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
    /// column are set to 0.
    /// </summary>
    public class ZeroMatrix
    {
        public int[][] BruteForce(int[][] matrix)
        {
            var result = new int[matrix.Length][];
            for(var i = 0; i < result.Length; i++)
            {
                var length = matrix[i].Length;
                result[i] = new int[length];
                Array.Copy(matrix[i], result[i], length);
            }

            var rows = matrix.Length;
            var cols = matrix[0].Length;

            for(var row = 0; row < rows; row++)
            {
                for(var col = 0; col < cols; col++)
                {
                    var n = matrix[row][col];
                    if(n == 0)
                    {
                        SetRow(result[row], 0);
                        SetColumn(result, col, 0);
                    }
                }
            }

            return result;
        }

        private class RowCol
        {
            public int Row { get; set; }
            public int Column { get; set; }

            public RowCol(int row, int column)
            {
                this.Row = row;
                this.Column = column;
            }
        }

        public void UseQueue(int[][] matrix)
        {
            var queue = new Queue<RowCol>();
            var rows = matrix.Length;
            var cols = matrix[0].Length;

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    var n = matrix[row][col];
                    if (n == 0)
                    {
                        queue.Enqueue(new RowCol(row, col));
                    }
                }
            }
            
            while(queue.Count > 0)
            {
                var rowCol = queue.Dequeue();
                SetRow(matrix[rowCol.Row], 0);
                SetColumn(matrix, rowCol.Column, 0);
            }
        }

        private void SetRow(int[] row, int value)
        {
            for(var i = 0; i < row.Length; i++)
            {
                row[i] = value;
            }
        }

        private void SetColumn(int[][] matrix, int colIndex, int value)
        {
            for(var i = 0; i < matrix.Length; i++)
            {
                matrix[i][colIndex] = value;
            }
        }

        public void Optimized(int[][] matrix)
        {
            for(var i = 0; i < matrix.Length; i++)
            {
                for(var j = 0; j < matrix[i].Length; j++)
                {
                    var n = matrix[i][j];
                    if (n == -1)
                        matrix[i][j] = 0;
                    else if (n == 0)
                    {
                        SetRow(matrix, i, 0, j + 1, 0);
                        SetRow(matrix, i, j + 1, matrix[i].Length - j - 1, -1, 0);
                        SetColumn(matrix, j, 0, i + 1, 0);
                        SetColumn(matrix, j, i + 1, matrix.Length - i - 1, -1, 0);
                    }
                }
            }
        }

        private void SetRow(int[][] matrix, int rowIndex, int colStart, int length, int value, int? unless = null)
        {
            for(var i = colStart; i < colStart + length; i++)
            {
                if(unless == null || matrix[rowIndex][i] != unless)
                    matrix[rowIndex][i] = value;
            }
        }

        private void SetColumn(int[][] matrix, int colIndex, int rowStart, int length, int value, int? unless = null)
        {
            for(var i = rowStart; i < rowStart + length; i++)
            {
                if (unless == null || matrix[i][colIndex] != unless)
                    matrix[i][colIndex] = value;
            }
        }

        public void Optimized2(Matrix<int> matrix)
        {
            var zeroRows = new bool[matrix.Rows];
            var zeroColumns = new bool[matrix.Columns];
            for(int i = 0; i < matrix.Rows; i++)
            {
                for(int j = 0; j < matrix.Columns; j++)
                {
                    var n = matrix[i, j];
                    if(n == 0)
                    {
                        zeroRows[i] = true;
                        zeroColumns[j] = true;
                    }
                }
            }

            for(int i = 0; i < zeroRows.Length; i++)
            {
                if(zeroRows[i])
                    matrix.SetAllRow(i, 0);
            }

            for(int i = 0; i < zeroColumns.Length; i++)
            {
                if(zeroColumns[i])
                matrix.SetAllColumn(i, 0);
            }
        }

        public void Optimized3(Matrix<int> matrix)
        {
            var shouldClearFirstRow = false;
            var shouldClearFirstColumn = false;

            for(int i = 0; i < matrix.Rows; i++)
            {
                if(matrix[i, 0] == 0)
                {
                    shouldClearFirstRow = true;
                    break;
                }
            }
            
            for(int i = 0; i < matrix.Columns; i++)
            {
                if(matrix[0, i] == 0)
                {
                    shouldClearFirstColumn = true;
                    break;
                }
            }

            for(int i = 0; i < matrix.Rows; i++)
            {
                for(int j = 0; j < matrix.Columns; j++)
                {
                    if(matrix[i, j] == 0)
                    {
                        matrix[0, j] = 0;
                        matrix[i, 0] = 0;
                    }
                }
            }

            // clear columns
            for(int col = 1; col < matrix.Columns; col++)
            {
                if(matrix[0, col] == 0)
                {
                    for(int row = 1; row < matrix.Rows; row++)
                    {
                        matrix[row, col] = 0;
                    }
                }
            }

            // clear rows
            for(int row = 1; row < matrix.Rows; row++)
            {
                if(matrix[row, 0] == 0)
                {
                    for(int col = 1; col < matrix.Columns; col++)
                    {
                        matrix[row, col] = 0;
                    }
                }
            }

            if(shouldClearFirstColumn)
            {
                for (int row = 0; row < matrix.Rows; row++)
                    matrix[row, 0] = 0;
            }


            if (shouldClearFirstRow)
            {
                for (int col = 0; col < matrix.Columns; col++)
                    matrix[0, col] = 0;
            }
        }
    }
}
