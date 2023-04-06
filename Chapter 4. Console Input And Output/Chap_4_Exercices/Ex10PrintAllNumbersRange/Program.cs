using System;

namespace Ex10PrintAllNumbersRange
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
            Guide: Use a combination of loops (see the chapter "Loops") and the methods Console.ReadLine(), Console.WriteLine() and Int32.Parse(). */

            // Prompt the user to enter a number
            Console.Write("Enter an integer number n : ");
            // read the user's input as a string, convert it to an interger using Pars().
            int n = Int32.Parse(Console.ReadLine());

            // loop from 0 to n (inclusive) using a for loop
            for (int i = 0; i <= n; i++)
            {
                // prompt the current value of i to the console, followed by a newline character
                Console.WriteLine(i);
            }
        }
    }
}
