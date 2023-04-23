using Microsoft.VisualBasic;
using System;

namespace Less08NestedLoopsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested Loops - The nested loops are programming constructs consisting of several loops located into each other.
            // The innermost loop is executed more times, and the outermost – less times.

            // for (initialization, verification, update)
            // {
            //     for (initialization, verification, update)
            //     {
            //         executable code
            //     }
            // }

            // Printing a Triangle - The outer loop will traverse the lines, and the inner one – the elements in them.
            // - We initialize the loop variable with 1 (the first number that we will print): col = 1;
            // - The repetition condition depends on the line on which we are: col <= row;
            // - We increase the loop variable with one unit at each iteration of the internal loop.

            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Enter n : 10

            // 1
            // 1 2
            // 1 2 3
            // 1 2 3 4
            // 1 2 3 4 5
            // 1 2 3 4 5 6
            // 1 2 3 4 5 6 7
            // 1 2 3 4 5 6 7 8
            // 1 2 3 4 5 6 7 8 9
            // 1 2 3 4 5 6 7 8 9 10
        }
    }
}
