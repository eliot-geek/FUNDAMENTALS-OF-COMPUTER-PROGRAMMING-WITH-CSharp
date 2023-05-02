using System;

namespace Ex13RectangArray3X3Size
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 13

            /* Write a program, which creates a rectangular array with size of n by m elements. The dimensions and the elements 
            should be read from the console. Find a platform with size of (3, 3) with a maximal sum.
            
            Guide: Modify the example about maximal platform with size of 2 by 2. */
            #endregion  

            Console.WriteLine("Write a program, which creates a rectangular array with size of n by m elements");
            // Read the dimensions of the rectangular array from the console
            Console.Write("Enter the number of rows n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns m : ");
            int m = int.Parse(Console.ReadLine());

            int row = 0;
            int col = 0;
            long sum = -1000;

            // Declare and initialize the rectangular array with size of n by m elements
            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Array [{0}][{1}] = ", i, j);
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            // Find the maximal sum platform of size 3 x 3
            for (int tempRow = 0; tempRow < arr.Length - 2; tempRow++)
            {
                for (int tempCol = 0; tempCol < arr.GetLength(0) - 2; tempCol++)
                {
                    long tempSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] +
                        arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] +
                        arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                    if (tempSum > sum)
                    {
                        row = tempRow;
                        col = tempCol;
                        sum = tempSum;
                    }
                }
            }
            // Print the result
            Console.WriteLine("\nThe best platform is : ");
            Console.WriteLine("{0,3} {1,3} {2,3}", arr[row, col], arr[row, col + 1], arr[row, col + 2]);
            Console.WriteLine("{0,3} {1,3} {2,3}", arr[row + 1, col], arr[row + 1, col + 1], arr[row + 1, col + 2]);
            Console.WriteLine("{0,3} {1,3} {2,3}", arr[row + 2, col], arr[row + 2, col + 1], arr[row + 2, col + 2]);
            Console.WriteLine("\nThe maximum sum is {0}.", sum);
            Console.ReadLine();




            Console.WriteLine("\nSolution 2");
            // Read the dimensions of the rectangular array from the console
            Console.Write("Enter the number of rows: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            m = int.Parse(Console.ReadLine());

            // Declare and initialize the rectangular array with size of n by m elements
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the elements of row {0}: ", i + 1);
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            // Find the maximal sum platform of size 3 x 3
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int roww = 0; roww < n - 2; roww++)
            {
                for (int coll = 0; coll < m - 2; coll++)
                {
                    long summma = matrix[roww, coll] + matrix[roww, coll + 1] + matrix[roww, coll + 2] +
                               matrix[roww + 1, coll] + matrix[roww + 1, coll + 1] + matrix[roww + 1, coll + 2] +
                               matrix[roww + 2, coll] + matrix[roww + 2, coll + 1] + matrix[roww + 2, coll + 2];
                    if (sum > bestSum)
                    {
                        bestSum = summma;
                        bestRow = roww;
                        bestCol = coll;
                    }
                }
            }

            // Print the result
            Console.WriteLine("\nThe best platform is:");
            Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("\nThe maximal sum is: {0}", bestSum);
        }
    }
}
