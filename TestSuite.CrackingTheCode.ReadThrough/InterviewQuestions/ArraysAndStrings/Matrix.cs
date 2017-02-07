namespace TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings
{
    public class Matrix<T>
    {
        private T[,] matrix;
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public T this[int row, int column]
        {
            get
            {
                return this.matrix[row, column];
            }
            set
            {
                this.matrix[row, column] = value;
            }
        }

        public Matrix(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.matrix = new T[this.Rows, this.Columns];
        }

        public Matrix(int size) : this(rows: size, columns: size)
        {
        }

        public void SetRow(int rowIndex, params T[] values)
        {
            for(int i = 0; i < this.Columns; i++)
            {
                this.matrix[rowIndex, i] = values[i];
            }
        }

        public T[] GetRow(int rowIndex)
        {
            var result = new T[this.Columns];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = this.matrix[rowIndex, i];
            }
            return result;
        }

        public void SetAllRow(int rowIndex, T value)
        {
            for (int i = 0; i < this.Columns; i++)
            {
                this.matrix[rowIndex, i] = value;
            }
        }

        public void SetAllColumn(int columnIndex, T value)
        {
            for (int i = 0; i < this.Rows; i++)
            {
                this.matrix[i, columnIndex] = value;
            }
        }
    }
}