using System;

namespace Ex07FractOfFactorialsMult
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 7
            // Write a program that calculates N!*K!/(N-K)! for given N and K (1 < K < N).
            // Guide: One solution is to calculate separately each factorial and at the end to perform the respective operations with the results.
            // Think how you can optimize the calculations, in order to not calculate too many factorials! In fractions of factorials there are many
            // possibilities to reduce the same factors in the numerator and denominator. These optimizations will not only reduce the calculations and
            // increase the performance but will save you from overflows in some situations.You might need to use arrays num[0..N] and denum[0..n]
            // to hold the factors in the numerator and in the denominator and to cancel the fraction.You may read about arrays in the chapter “Arrays”.
            #endregion

            // Works only for n <= 6 and k <=5, after these inputs the program will give incorrect answer
            Console.WriteLine("Calculates N!*K!/(N-K)! for given N and K (1 < K < N)");
            Console.Write("Enter n (1<K<N) : ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter k (1<K<N) : ");
            int k = Int32.Parse(Console.ReadLine());
            int n_k = n - k;

            if ((1 < k) && (k < n))
            {
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                for (int i = k - 1; i > 0; i--)
                {
                    k *= i;
                }
                for (int i = n_k - 1; i > 0; i--)
                {
                    n_k *= i;
                }
                Console.WriteLine("N!*K!  is {0}", n * k);
                Console.WriteLine("(N-K)! is {0}", n_k);
                Console.WriteLine("N!*K!/(N-K)! is {0}", n * k / n_k);
            }
            else
            {
                Console.WriteLine("Error!! => Follow this rule (1<K<N)");
            }


            // When calculating N!*K!/(N-K)!, we can optimize the calculation by reducing the number of multiplications needed.
            // One way to do this is by calculating the product of numbers from 1 to (n-k) and the product of numbers from (n-k+1) to n separately,
            // and then multiply them with the product of numbers from 1 to k. This is because the denominator of the fraction contains the product
            // of numbers from 1 to (n-k), which can be cancelled out with the same factor in the numerator. Therefore, we only need to calculate the
            // product of numbers from (n-k+1) to n and the product of numbers from 1 to k. This reduces the number of multiplications needed and can
            // prevent overflows in some situations.

            Console.WriteLine("\nSolution 2");
            // Prompt the user to enter the values of n and k
            Console.Write("Enter n (1<k<n): ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter k (1<k<n): ");
            k = int.Parse(Console.ReadLine());

            // Initialize variables
            long numerator = 1;
            long denominator = 1;

            // Calculate the product of numbers from 1 to (n-k)
            for (int i = 1; i <= n - k; i++)
            {
                denominator *= i;
            }
            // Calculate the product of numbers from (n-k+1) to n
            for (int i = n - k + 1; i <= n; i++)
            {
                numerator *= i;
            }
            // Calculate the product of numbers from 1 to k
            for (int i = 1; i <= k; i++)
            {
                numerator *= i;
            }
            // Calculate the final result
            long result = numerator / denominator;
            // Display the result to the user
            Console.WriteLine("N!*K!  is {0}", numerator);
            Console.WriteLine("(N-K)! is {0}", denominator);
            Console.WriteLine("N!*K!/(N-K)! = " + result);
        }
    }
}
