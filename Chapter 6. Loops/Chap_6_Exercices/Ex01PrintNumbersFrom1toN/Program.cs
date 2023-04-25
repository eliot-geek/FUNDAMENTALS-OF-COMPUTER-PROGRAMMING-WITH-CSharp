using System;

namespace Ex01PrintNumbersFrom1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            // Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            // Use a for-loop
            #endregion

            Console.Write("Enter a number: ");
            // Read the input from the user
            int n = Int32.Parse(Console.ReadLine());
            // Loop from 1 to n and print each number
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            // Add a newline at the end to make the output look nicer
            Console.WriteLine();
        }
    }
}
