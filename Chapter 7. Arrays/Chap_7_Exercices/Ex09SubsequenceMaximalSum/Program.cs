using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Ex09SubsequenceMaximalSum
{
    class Program
    {
        /// <summary>
        /// The first way is to use brute force method, which in this case means that using two nested loops we check every possible start and end and its corresponding sum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int BruteForceMaxSubsequenceSum(int[] array)
        {
            int n = array.Length;
            int maxSum = int.MinValue;

            // Iterate over all possible subsequences and find the maximum sum
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += array[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }

        /// <summary>
        /// Method to find the maximum subsequence sum using a one-loop approach
        /// The second way is to use one loop through the array to scan it from left to right and sum the elements. 
        /// Once we get a negative sum, we can restart summing from the next element. At each step we check if the current sum is greater than the current max.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int FindMaxSubsequenceSum(int[] array1)
        {
            // Initialize variables to store the current and maximum subsequence sums
            int currentSumm = 0;
            int maximumSum = int.MinValue;

            // Iterate over the array and sum its elements
            for (int i = 0; i < array1.Length; i++)
            {
                currentSumm += array1[i];

                // If the current sum is negative, restart summing from the next element
                if (currentSumm < 0)
                {
                    currentSumm = 0;
                }

                // Check if the current sum is greater than the current maximum and update the maximum if necessary
                if (currentSumm > maximumSum)
                {
                    maximumSum = currentSumm;
                }
            }

            // Return the maximum subsequence sum
            return maximumSum;
        }

        static void Main(string[] args)
        {
            #region Task 9
            /* Write a program, which finds a subsequence of numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} ---> 11
            Guide : There are two ways to solve this problem. 
            The first way is to use brute force method, which in this case means that using two nested loops we check every possible start and end and its corresponding sum. 
            The second way is to use one loop through the array to scan it from left to right and sum the elements. Once we get a negative sum, we can restart summing from the 
            next element. Think why this is correct! At each step we check if the current sum is greater than the current max. */
            #endregion


            #region 1st way
            
            // Define an array of integers to find the maximum subsequence sum
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            // Find the maximum subsequence sum using the brute force method
            int maxSum = BruteForceMaxSubsequenceSum(array);                    // Note that the brute force method has a time complexity of O(n^2), so it may not be suitable for very large arrays.
            // Print the maximum subsequence sum
            Console.WriteLine("Maximum subsequence sum: " + maxSum);
            Console.ReadKey();
            #endregion


            #region 2nd way

            // Define the array
            int[] array1 = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            // Print instructions for the user to find the maximum subsequence sum
            Console.WriteLine("Write a program, which finds a subsequence of numbers with maximal sum");
            // Find the maximum subsequence sum using the one-loop approach
            int maximumSum = FindMaxSubsequenceSum(array1);                 // We have found the maximum subsequence sum without having to consider every possible subsequence, which would be much less efficient.
            // Print the maximum subsequence sum to the console
            Console.WriteLine("Maximum subsequence sum is {0}. ", maximumSum);
            // Wait for user input before closing the console window
            Console.ReadLine(); Console.ReadKey();
            #endregion


            #region 2nd way 2

            // The second way is to use one loop through the array to scan it from left to right and sum the elements. Once we get a negative sum, we can restart summing from the 
            // next element. Think why this is correct! At each step we check if the current sum is greater than the current max.
            Console.WriteLine("\nSolution 2");
            // Print instructions for the user to enter the array
            Console.WriteLine("Write a program, which finds a subsequence of numbers with maximal sum");
            Console.Write("Enter the array : ");
            // Read the array from the user input and initialize variables to store the current and maximum subsequence sums
            int[] ar = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int currentSum = 0;
            int maxSumm = int.MinValue;
            // Iterate over the array and sum its elements
            for (int i = 0; i < ar.Length; i++)
            {
                currentSum += ar[i];

                // If the current sum is negative, restart summing from the next element
                if (currentSum < 0)
                {
                    currentSum = 0;
                }

                // Check if the current sum is greater than the current maximum and update the maximum if necessary
                if (currentSum > maxSumm)
                {
                    maxSumm = currentSum;
                }
            }
            // Print the maximum subsequence sum to the console
            Console.WriteLine("Result is {0}. ", maxSumm);
            #endregion


            #region 1st way 2


            Console.WriteLine("\nSolution 3");
            // Print instructions for the user to enter the array length
            Console.WriteLine("Write a program, which finds a subsequence of numbers with maximal sum");
            Console.Write("Enter the array's length : ");
            // Read the array length from the user input and initialize a variable to store the sum
            int length = Int32.Parse(Console.ReadLine());
            int sum = 0;
            // Create an integer array of the specified length
            int[] arr = new int[length];
            // Iterate over the array and prompt the user to enter each element
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            // Iterate over all possible subsequences and find the maximum sum
            for (int i = 0; i < length - 1; i++)
            {
                int tempSum = arr[i];
                for (int j = i + 1; j < length; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                    }
                }
            }
            // Print the maximum subsequence sum to the console
            Console.Write("Maximum subsequence sum is {0}. ", sum);
            // Wait for the user to press enter before exiting the program
            Console.ReadLine();
            #endregion
        }
    }
}
