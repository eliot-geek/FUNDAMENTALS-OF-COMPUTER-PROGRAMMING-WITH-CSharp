using System;

namespace Less05MultidimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multidimensional Arrays - The one-dimensional arrays are known also as vectors in mathematics.
            // What Is a Multidimensional Array? What Are Matrices? - Every valid type in C# can be used for a type of an array. So, we can have an array of arrays

            // Two-dimensional, because they have two dimensions. They are also known as matrices (it is mathematical term).
            // In general arrays with more than one dimension we will call multidimensional. This way we can declare three-dimensional arrays as we add one more
            // In theory there is no limit for an array dimensions

            // Multidimensional Array Declaration and Allocation
            int[,] twoDimensionalArray = new int[3, 4];
            int[,,] threeDimensionalArray = new int[3, 4, 6];
            int[,] intMatrix = new int[3, 4];
            float[,] floatMatrix = new float[8, 2];
            string[,,] stringCube = new string[5, 5, 5];

            // Two-Dimensional Array Initialization
            int[,] matri =
            {
                {1, 2, 3, 4 },  // row 0 values
                {5, 6, 7, 8 },  // row 1 values
            };                  // The matrix size is 2 x 4 (2 rows, 4 cols)

            // Accessing the Elements of a Multidimensional Array
            // The array matrix has 8 elements, stored in 2 rows and 4 columns. Each element can be accessed in the following way:
            // matrix[0, 0] matrix[0, 1] matrix[0, 2] matrix[0, 3]
            // matrix[1, 0] matrix[1, 1] matrix[1, 2] matrix[1, 3]
            // We can access any element as matrix[row, col]

            // Length of Multidimensional Arrays
            // We can get the number of the rows of this two-dimensional array by using matrix.GetLength(0) and the number of all columns per row with matrix.GetLength(1).
            // So, in this case matrix.GetLength(0) returns 2 and matrix.GetLength(1) returns 4.

            // Printing Matrices
            // Declare and initialize a matrix of size 2 x 4
            int[,] matrix =
            {
                {1, 2, 3, 4}, // row 0 values
                {5, 6, 7, 8}, // row 1 value
            };
            // Print the matrix on the console
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
