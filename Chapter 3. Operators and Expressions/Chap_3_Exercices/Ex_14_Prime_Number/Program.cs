using System;

namespace Ex_14_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).
            Guidelines: Use a loop and check the number for divisibility by all integers from 1 to the square root of the number. Since n < 100, you can find in 
            advance all prime numbers from 1 to 100 and checks the input over them. The prime numbers in the range [1…100] are: 
            2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89 and 97. */

            // Get input from user
            Console.Write("Enter a number between 1 and 100: ");
            int n = int.Parse(Console.ReadLine());
            // Check if n is a prime number
            bool isPrime = true;
            // Checking all numbers from 2 up to the square root of n is enough to determine whether n is a prime number, because any factors of n larger than its square root will have
            // corresponding factors that are smaller than the square root, and will have already been checked by the loop.
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (n == 1)
            {
                isPrime = false;
            }
            if (isPrime)
            {
                Console.WriteLine($"{n} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number.");
            }
            Console.ReadKey();


            /* Write a program that puts the first 100 prime numbers    */

            Console.Write("\nSecond Program\nThe prime numbers in the range [1…100] are: ");
            // iterate through numbers from 2 until we have printed primes in the range [1…100]
            for (int i = 2; i < 100; i++) 
            {
                // assume i is prime until proven otherwise
                bool isPrime1 = true;
                // check if i is divisible by any number from 2 to i-1
                for (int j = 2; j < i; j++) 
                {
                    // if i is divisible by j, then i is not a prime number
                    if (i % j == 0) 
                    {
                        isPrime1 = false;
                        break;
                    }
                }
                // if i is a prime number, print it and increment the count
                if (isPrime1) 
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            /* Write a program that puts the first 100 prime numbers    */

            Console.Write("\nThe prime numbers in the range [1…100] are: 2 3 ");
            // iterate through numbers from 2 to 99 (inclusive)
            for (int i = 2; i < 100; i++) 
            {
                // check if i is divisible by any number from 2 to its square root
                for (int j = 2; j * j <= i; j++) 
                {
                    // if i is divisible by j, then i is not a prime number, so break out of the loop
                    if (i % j == 0) 
                    {
                        break;
                    }
                    // if i is not divisible by any number up to its square root, print i
                    else if (j + 1 > Math.Sqrt(i)) 
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
