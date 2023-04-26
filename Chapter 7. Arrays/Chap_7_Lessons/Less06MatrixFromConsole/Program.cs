using System;

namespace Less06MatrixFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading Matrices from the Console – Example
            // We will learn how to read a two-dimensional array from the console.

            Console.Write("Enter the number of the rows : ");
            int rows = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the number of the colums : ");
            int cols = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Enter the cells of the matrix : ");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
