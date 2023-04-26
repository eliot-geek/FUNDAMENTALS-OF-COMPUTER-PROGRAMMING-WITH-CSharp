using System;

namespace Less07MaximalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maximal Platform in a Matrix – Example
            // We are given a two-dimensional rectangular array (matrix) of integers and our task is to find the
            // sub-matrix of size of 2 by 2 with maximum sum of its elements and to print it to the console

            // Declare and initialize the matrix
            int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };

            // Find the maximal sum platform of size 2 x 2
            // Declare variables to keep track of the bestSum, bestRow and bestCol for the platform of size 2 x 2
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            // Output the minimum value of a long integer for reference
            Console.WriteLine("Long.MinValue = " + bestSum);

            // Iterate over each possible 2 x 2 platform in the matrix
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    // Calculate the sum of the current 2 x 2 platform
                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    // Check if the current sum is greater than the best sum found so far
                    if (sum > bestSum)
                    {
                        // If so, update the bestSum, bestRow and bestCol
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            // Output the best platform and its corresponding sum
            Console.WriteLine("The best platform is : ");
            Console.WriteLine(" {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            Console.WriteLine(" {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
            Console.WriteLine("The maximal sum is : {0}", bestSum);
            Console.ReadLine();
        }
    }
}
