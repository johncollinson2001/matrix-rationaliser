using System;

namespace MatrixRationaliser
{
    public static class MatrixRationaliserService
    {
        public static int[][] RationaliseMatrix(int[][] matrix, int subject)
        {
            // First discover if the subject exists in the first row/column. We need to do this as 
            // we will make use of the first row/col and need to store their original state.

            var isSubjectInFirstRow = false;
            var isSubjectInFirstColumn = false;

            for (var row = 0; row < matrix.Length; row++)
            {
                if (matrix[row][0] == subject)
                    isSubjectInFirstColumn = true;
            }

            for (var col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[0][col] == subject)
                    isSubjectInFirstRow = true;
            }

            // Iterate all rows/cols. If the subject is found then set the first row/col of that cell
            // to the subject.

            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == subject)
                    {
                        matrix[0][col] = subject;
                        matrix[row][0] = subject;
                    }
                }
            }

            // Now use the updated first row/col to fill entire rows/cols.

            for (var col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[0][col] == subject)
                {
                    for (var row = 1; row < matrix.Length; row++)
                    {
                        matrix[row][col] = subject;
                    }
                }
            }

            for (var row = 0; row < matrix.Length; row++)
            {
                if (matrix[row][0] == subject)
                {
                    for (var col = 1; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] = subject;
                    }
                }
            }

            // Finally, use our initial flags to fill the entire first row/col where required.

            if (isSubjectInFirstRow)
            {
                for (var col = 0; col < matrix[0].Length; col++)
                {
                    matrix[0][col] = subject;
                }
            }

            if (isSubjectInFirstColumn)
            {
                for (var row = 0; row < matrix.Length; row++)
                {
                    matrix[row][0] = subject;
                }
            }

            return matrix;
        }
    }
}
