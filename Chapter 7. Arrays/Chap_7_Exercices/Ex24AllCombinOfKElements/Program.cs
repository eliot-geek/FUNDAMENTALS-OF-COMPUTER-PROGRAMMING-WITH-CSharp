using System;

namespace Ex24AllCombinOfKElements
{
    class Program
    {
        private static int[] numbers;   // declaration of array to hold combination elements
        private static int n;           // declaration of N
        private static int k;           // declaration of K

        /// <summary>
        /// Prints the combination
        /// </summary>
        /// <param name="length"></param>
        private static void Print(int length)
        {
            Console.Write("{"); 
            // for loop to iterate through array elements
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", numbers[i] + 1);  // prints the array element and a space
            }
            Console.Write("}");
            Console.WriteLine();
        }

        /// <summary>
        /// Combine the elements
        /// </summary>
        /// <param name="i"></param>
        /// <param name="after"></param>
        private static void Combine(int i, int after)
        {
            // if the array is bigger than K return nothing
            if (i > k)
            {
                return;
            }
            // iterate through the array to combine elements
            for (int j = after; j < n; j++)
            {
                numbers[i - 1] = j; // set the value of the array element at i-1 to j
                if (i == k) // if the array is equal to K, print the combination
                {
                    Print(i);
                }
                // combine the elements
                Combine(i + 1, j + 1);
            }
        }

        static void Main(string[] args)
        {
            #region Task 24
            /* Write a program, which reads an integer number N from the console and prints all combinations of K elements of numbers in range [1 … N]. 
            Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}.
            Guide: Modify the algorithm from the previous problem in the following way: start from {1, 2, …, N} and increase the last digit (with the digits at 
            the left when required), but always keep all elements in the array in ascending order (element p[i] should start increasing from p[i-1]+1). */
            #endregion


            #region Solution 1

            Console.WriteLine("Solution 1");
            string numberN;
            do
            {
                Console.Write("Enter number N : ");
                numberN = Console.ReadLine();
            }
            while (!Int32.TryParse(numberN, out n) || n <= 0);  // keep asking for input until it's valid

            string numberK;
            do
            {
                Console.Write("Enter number K : ");
                numberK = Console.ReadLine();
            }
            while (!Int32.TryParse(numberK, out k) || k <= 0 || k > n); // keep asking for input until it's valid
            
            numbers = new int[n];   // initialize the array
            Combine(1, 0);          // combine the elements starting from 1
            Console.ReadLine();     // wait for the user to press enter

            #endregion


            #region Solution 2

            Console.WriteLine("\nSolution 2");
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine()); // Read input N from user
            Console.Write("Enter K: ");
            k = int.Parse(Console.ReadLine()); // Read input K from user

            int[] combination = new int[k]; // Initialize an array to hold the combination
            for (int i = 0; i < k; i++)
            {
                combination[i] = i + 1;     // Initialize the combination array with the first k numbers
            }

            while (true)
            {
                Console.WriteLine(string.Join(" ", combination));  // Print the current combination
                int index = k - 1;                                  // Initialize index to the last position in the combination array
                while (index >= 0 && combination[index] == n - k + index + 1)
                {
                    index--; // Find the rightmost element that can be incremented
                }
                if (index < 0)
                {
                    break; // If no element can be incremented, we have generated all combinations
                }

                combination[index]++;                       // Increment the rightmost element that can be incremented
                for (int i = index + 1; i < k; i++)
                {
                    combination[i] = combination[i - 1] + 1; // Reset the elements to the right of the incremented element
                }
            }
            Console.ReadKey();

            #endregion
        }
    }
}
