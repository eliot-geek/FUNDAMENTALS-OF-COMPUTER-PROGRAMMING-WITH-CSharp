using System;

namespace Ex09CalculatesSumFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 9
            // Write a program that for a given integers n and x, calculates the sum: s = 1+1!/x + 2!/x^2 + ...+ n!/x^n
            // Guide: You can solve the problem with a for-loop for k=0…n, by using three additional variables factorial, power and sum in which you
            // will keep for the kth iteration of the loop respectively k!, xk and the sum of the first k members of sequence. If your implementation
            // is good, you should have only one loop and you should not use external functions to calculate factorials and to raise power.
            #endregion

            Console.WriteLine("Calculates the sum : s = 1+1!/x + 2!/x^2 + ...+ n!/x^n");
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of x: ");
            int x = int.Parse(Console.ReadLine());

            double sum = 1.0;
            int factorial = 1;
            int power = 1;

            for (int k = 1; k <= n; k++)
            {
                factorial *= k;                     // calculate k!
                power *= x;                         // calculate x^k
                sum += (double)factorial / power;   // add k! / x^k to the sum
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
