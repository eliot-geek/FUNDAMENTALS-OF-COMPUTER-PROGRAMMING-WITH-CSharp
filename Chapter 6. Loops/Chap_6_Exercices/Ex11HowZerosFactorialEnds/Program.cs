using System;
using System.Numerics;

namespace Ex11HowZerosFactorialEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 11
            // Write a program that calculates with how many zeroes the factorial of a given number ends. Examples:
            // N = 10 -> N! = 3628800   -> 2
            // N = 20 -> N! = 2432902008176640000  -> 4
            // Guide: The number of zeros at the end of n! depends on how many times the number 10 is a divisor of the factorial. Because the product 1*2*3…*n
            // has a greater number of divisors 2, than 5 and because 10 = 2 * 5, then the number of zeros in n! is exactly as many as the multipliers with value
            // 5 in the product 1 * 2 * 3 * … * n. Because every fifth number is divisible by 5, and every 25th number is divisible by 5 two times, etc.,
            // the number of zeros in n! is the sum: n/5 + n/25 + n/125 + …
            #endregion

            // decimal number until 30
            // BigInteger more and more 50000

            Console.WriteLine("Solution 1");
            // Prompt the user to enter a number for which the factorial value needs to be calculated.
            Console.Write("Enter a factorial number n : ");
            // Read the input number 'n' from the console and parse it to a BigInteger data type.
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            // Initialize a variable 'zeroes' to store the number of trailing zeroes in the factorial value of 'n'.
            int zeroes = 0;
            // Calculate the factorial of 'n' using a for loop.
            // The loop starts from n-1 and iterates till i is greater than 0.
            for (int i = (int)(n - 1); i > 0; i--)
            {
                // Within the loop, each value of i is multiplied with n to calculate the factorial of 'n'.
                n *= i;
            }
            // Display the calculated factorial value of 'n' on the console.
            Console.Write("n! = {0} --> ", n);
            // Use a do-while loop to determine the number of trailing zeroes in the calculated factorial value.
            // The loop divides 'n' by 10 until it reaches a non-zero digit.
            do
            {
                n /= 10;
                zeroes++;
            } while (n % 10 == 0);
            // Display the number of trailing zeroes in the factorial value of 'n' on the console.
            Console.WriteLine("{0} zeroes.", zeroes);
            Console.ReadLine();



            Console.WriteLine("\nSolution 2");
            // Ask the user to input a number
            Console.Write("Enter a number: ");
            // Parse the user's input as an integer
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            // Initialize the count of zeroes to 0, and the divisor to 5
            BigInteger count = 0;
            BigInteger divisor = 5;

            // Use a loop to calculate the number of fives in the factorial
            while (divisor <= num)
            {
                // Add the number of times divisor goes into n to the count of zeroes
                count += num / divisor;
                // Multiply divisor by 5 to check for the next power of 5
                divisor *= 5;
            }
            // Calculate the factorial of 'num' using a for loop.
            // The loop starts from n-1 and iterates till i is greater than 0.
            for (int i = (int)(num - 1); i > 0; i--)
            {
                // Within the loop, each value of i is multiplied with n to calculate the factorial of 'n'.
                num *= i;
            }
            // Print the result
            Console.Write("N! = {0} --> ", num);
            Console.WriteLine("{0} zeroes.", zeroes);
        }
    }
}
