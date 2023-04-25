using System;
using System.Numerics;

namespace Ex19TrailingZeroesInN_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 19
            // Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
            // Your program should work well for very big numbers, e.g. n = 100000.
            #endregion

            Console.Write("Enter a number: ");
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger zeros = 0;
            int powFive = 1;
            int denominator = 0;

            while (denominator <= number)
            {
                denominator = (int)Math.Pow(5, powFive);
                zeros += number / denominator;
                ++powFive;
            }
            Console.WriteLine("{0}! has {1} trailing zeros.", number, zeros);



            // Get input from the user
            Console.Write("Enter a number: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.Write($"The factorial of {n}");
            // Initialize variables
            BigInteger count = 0;
            // Count the number of factors of 5 in the number
            while (n > 0)
            {
                count += n / 5;
                n /= 5;
            }
            // Display the result
            Console.WriteLine($" has {count} trailing zeroes.");
        }
    }
}
