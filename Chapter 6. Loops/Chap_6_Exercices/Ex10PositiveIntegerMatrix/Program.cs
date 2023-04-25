using System;
using System.Threading;

namespace Ex10PositiveIntegerMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 10
            // Write a program that reads from the console a positive integer number N(N < 20) and prints a matrix of numbers as on the figures below: 3X3 4X4 5X5
            //         N = 3 →  1 2 3               N = 4 →  1 2 3 4
            //                  2 3 4                        2 3 4 5
            //                  3 4 5                        3 4 5 6
            //                                               4 5 6 7
            // Guide: You should use two nested loops, similar to the problem "Printing a Triangle". The outer loop must run from 1 to N, and the inner –
            // from the value of the outer loop to the value of the outer loop + N - 1.
            #endregion

            Console.WriteLine("Matrix of numbers");
            Console.Write("Enter a positive integer number less than 20 N(N < 20): ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n < 20)
            {
                // Loop through each row of the matrix
                for (int i = 1; i <= n; i++)
                {
                    // Loop through each column of the matrix for the current row
                    for (int j = i; j <= i + n -1; j++)
                    {
                        // Print the current value of 'j', followed by a space
                        Console.Write("{0} ", j);
                    }
                    // Print a newline character to move to the next row of the matrix
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong number. Please put an integer N(N < 20)");
            }
            Console.ReadLine();
        }
    }
}
