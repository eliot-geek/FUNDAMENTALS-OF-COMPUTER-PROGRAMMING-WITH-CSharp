using System;

namespace Ex06FractionOfFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 6
            // Write a program that calculates N!/K! for given N and K (1<K<N).
            // Guide: Multiply the numbers from K+1 to N (think why this is correct). You may check the properties of the factorial function
            // in Wikipedia: http://en.wikipedia.org/wiki/Factorial.
            #endregion

            Console.WriteLine("Calculates N!/K! for given N and K, (1 < K < N).");
            // Prompt the user to enter the value of n
            Console.Write("Enter n (1<K<N) : ");
            // Read the value of n from the console and convert it to an integer
            int n = Int32.Parse(Console.ReadLine());
            // Prompt the user to enter the value of k
            Console.Write("Enter k (1<K<N) : ");
            // Read the value of k from the console and convert it to an integer
            int k = Int32.Parse(Console.ReadLine());

            // Check if k is between 1 and n (exclusive)
            if ((1 < k) && (k < n))
            {
                // Initialize a variable Nfactrial to 1 to store the value of n factorial
                decimal Nfactrial = 1;
                // Calculate the value of n factorial using a for loop
                for (int i = 1; i <= n; i++)
                {
                    Nfactrial *= i;
                }
                // Initialize a variable Kfactrial to 1 to store the value of k factorial
                decimal Kfactrial = 1;
                // Calculate the value of k factorial using a for loop
                for (int i = 1; i <= k; i++)
                {
                    Kfactrial *= i;
                }
                // Calculate the value of N!/K!
                decimal num = Nfactrial / Kfactrial;
                // Print the result to the console
                Console.WriteLine("N!/K! = " + num);
            }
            else
            {
                // Print an error message if k is not between 1 and n (exclusive)
                Console.WriteLine("Error!! => Follow this rule (1<K<N)");
            }
            Console.ReadLine();



            // Print a message to indicate the start of the second method
            Console.WriteLine("\nSecond Method");
            // Prompt the user to enter the values of n and k
            Console.Write("Enter N: (1<K<N) ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            k = Int32.Parse(Console.ReadLine());
            int result = 1; // Initialize the result to 1
            // Calculate the result by multiplying the numbers from K+1 to N because N!/K! is equal to the product of all integers from K+1 to N.
            for (int i = k + 1; i <= n; i++)
            {
                result *= i; 
            }
            // Print the result
            Console.WriteLine($"N!/K! = {result}");
            Console.ReadLine();
            
        }
    }
}
