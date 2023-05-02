using System;
using System.Collections.Generic;

namespace Ex19AllPrimeNumbersRange
{
    class Program
    {
        /// <summary>
        /// A method to print a list of integers, with an option to print or skip zero values - Print List
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="printZero"></param>
        static void PrintList(List<int> numbers, bool printZero = true)
        {
            foreach (int n in numbers)
            {
                // If printZero is false and the current number is 0, skip it
                if (!printZero && n == 0)
                {
                    continue;
                }
                Console.Write("{0} ", n);  // Print the current number with a period and a space after it
            }
            Console.WriteLine();    // Move to a new line after all numbers have been printed
        }
        
        static void Main(string[] args)
        {
            #region Task 19
            /* Write a program, which finds all prime numbers in the range [1…10,000,000].
            Guide: Find on the Internet information about "The sieve of Erathostenes" (you have probably heard about it in math classes in high-school). */

            #endregion


            #region Method Call PrintList
            
            Console.WriteLine("Write a program, which finds all prime numbers in the range.");
            // Create a new List of integers named "numbers" and add all numbers between 2 and 100 to it
            List<int> numbers = new List<int>(); // 1 is not a prime number

            for (int i = 2; i <= 100; i++)
            {
                numbers.Add(i);
            }
            // Initialize two integers named "position" and "indexAt" to 2 and 0, respectively, and a boolean named "limitReached" to false
            int position = 2, indexAt = 0;
            bool limitReached = false;

            // Start a while loop that will execute until the limit is reached
            while (!limitReached)
            {
                // Start a for loop that will iterate through all numbers in the "numbers" List
                for (int i = 0; i < numbers.Count ; i++)
                {
                    // Get the value of the number at the current index in the List
                    int v = numbers[i];
                    // If the number is divisible by "position" and is not equal to "position", set its value in the List to 0
                    if (v % position == 0 && v != position)
                    {
                        numbers[i] = 0;
                    }
                }
                // Start a do-while loop that will execute until "position" is not equal to 0
                do
                {
                    // Set "position" to the value at the "indexAt" position in the List and increment "indexAt"
                    position = numbers[indexAt++];
                    // If "indexAt" is greater than or equal to the size of the List minus 1, set "limitReached" to true and break out of the loop
                    if (indexAt >= numbers.Count - 1)
                    {
                        limitReached = true;
                        break;
                    }
                } while (position == 0);
            }
            // Call the PrintList method with the "numbers" List and a value of false for the "printZero" parameter
            PrintList(numbers, false);
            // Wait for the user to press Enter before closing the console window
            Console.ReadLine();

            #endregion


            #region Another way

            
            Console.WriteLine("\nWrite a program, which finds all prime numbers in the range.");
            //int n = 10000000;
            int n = 100;
            bool[] primes = new bool[n + 1];
            // initialize all numbers as potential prime numbers
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }

            // start at 2 (the first prime number) and mark all of its multiples as non-prime
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (primes[i] == true)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            // output all prime numbers
            Console.WriteLine("Prime numbers in the range [1...{0}]:", n);
            for (int i = 2; i <= n; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();

            #endregion
        }
    }
}
