using System;

namespace Ex08CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 8
            // In combinatorics, the Catalan numbers are calculated by the following formula: Cn=1/n+1(2n n) = (2n)! / ((n+1)! * n!) for n ≥ 0.
            // Write a program that calculates the nth Catalan number by given n.
            // Guide: Use the same concept of canceling the faction of simple factors, like you probably did in the previous problem.
            // You may also read more about the Catalan numbers in Wikipedia (http://en.wikipedia.org/wiki/Catalan_number) and use the
            // recurrent formula for calculating them.

            // The first Catalan numbers for n = 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ... are 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786, ... 
            #endregion


            Console.WriteLine("Catalan numbers");
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());
            // Calculate (2n)! / (n+1)!n! using simple factors cancellation
            decimal result = 1m;
            for (int i = 1; i <= n; i++)
            {
                // Cn = (2n)! / ((n+1)! * n!)
                // The loop in the code you provided calculates the numerator of the above fraction, which is (2n)!.
                // The loop iterates from 1 to n, and for each iteration, it calculates a term(2n - i + 1) / i
                // and multiplies it to the running product(stored in the variable 'result').
                // The term(2n - i + 1) / i can be simplified as (2n - i + 1) *(1 / i), which is equivalent to (2n - i + 1) *(i ^ (-1)).
                // By simplifying the numerator, you can see that(2n - i + 1) is a factor that cancels out with a term in the denominator(i) in the formula
                // for Cn.So, in each iteration of the loop, a factor that cancels out with a term in the denominator is multiplied to the running product,
                // which leads to the final value of Cn.
                // To ensure that the result is calculated as a decimal value, the 'm' suffix is added to the constant value 1 in the line 'decimal result = 1m'.
                
                result *= (2 * n - i + 1) / (decimal)i;
            }
            // Print the result
            Console.WriteLine("Catalan number for n = {0} is {1}", n, result / (n + 1));
        }
    }
}
