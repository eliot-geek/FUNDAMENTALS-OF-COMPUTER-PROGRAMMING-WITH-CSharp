using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex22RemovMinNumbOfElemnts
{
    class Program
    {
        /// <summary>
        /// Implements the dynamic programming algorithm to find the longest increasing subsequence. 
        /// Finds the longest increasing subsequence of an input array using dynamic programming
        /// </summary>
        /// <param name="array"></param>
        /// <returns>an array containing the elements of the longest increasing subsequence</returns>
        static int[] FindLIS(int[] array)
        {
            // Initialize arrays to store the dynamic programming values and previous indices
            int[] dp = new int[array.Length];
            int[] prev = new int[array.Length];

            // Initialize variables to store the maximum length of the subsequence and its ending index
            int maxLength = 0;
            int maxIndex = 0;

            // Iterate over the input array
            for (int i = 0; i < array.Length; i++)
            {
                // Initialize the dynamic programming value and previous index for the current element
                dp[i] = 1;
                prev[i] = -1;

                // Iterate over the previous elements to update the dynamic programming value and previous index for the current element
                for (int k = 0; k < i; k++)
                {
                    if (array[i] > array[k] && dp[k] + 1 > dp[i])
                    {
                        dp[i] = dp[k] + 1;
                        prev[i] = k;
                    }
                }

                // Update the maximum length and ending index if the dynamic programming value for the current element is larger
                if (dp[i] > maxLength)
                {
                    maxLength = dp[i];
                    maxIndex = i;
                }
            }

            // Create an array to store the longest increasing subsequence
            int[] lis = new int[maxLength];
            int index = maxLength - 1;
            
            // Traverse the previous indices to populate the longest increasing subsequence array
            while (maxIndex != -1)
            {
                lis[index] = array[maxIndex];
                maxIndex = prev[maxIndex];
                index--;
            }
            // Return the longest increasing subsequence
            return lis;
        }

        static void Main(string[] args)
        {
            #region Task 22
            /* Write a program, which reads an array of integer numbers from the console and removes a minimal number of elements in such a way that 
            the remaining array is sorted in an increasing order.Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
            Guide: Use dynamic programming to find the longest increasing sub-sequence in the input sequence arr[], just like in problem #6. 
            The elements not included in the maximal increasing sequence should be removed in order the array to become sorted. */
            #endregion


            #region Solution 2

            Console.WriteLine("Write a program, which reads an array of integer numbers from the console and removes a minimal number of elements");
            // Given array
            int[] array1 = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            // Find longest increasing subsequence using dynamic programming
            int[] lis = FindLIS(array1);
            // Create a new array to store the elements that should remain in the array to make it sorted
            int[] result = new int[lis.Length];
            // Iterate over array1 and add the elements that are part of the longest increasing subsequence to result
            int k = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (k < lis.Length && array1[i] == lis[k])
                {
                    result[k] = array1[i];
                    k++;
                }
            }
            // Print the resulting array
            Console.WriteLine(string.Join(", ", result));
            Console.ReadKey();

            #endregion


            #region Solution 1

            
            Console.WriteLine("\nWrite a program, which reads an array of integer numbers from the console and removes a minimal number of elements");
            // Initialize variables for the longest increasing sub-sequence
            int subset = 0;
            int longestLength = 0;

            // Prompt the user to enter the array length
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());

            // Create an array of the entered length and prompt the user to enter each element
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            // Generate all possible subsets of the entered array using a bit mask.
            int m = (1 << length);      // calculates the number of possible subsets based on the length of the input array by shifting the binary value 1 to the left by the length of the array.
                                        // This is equivalent to raising 2 to the power of the array length, which is the total number of subsets.
            int[,] subsets = new int[m, length];    // store all the possible subsets. Each element of the "subsets" array will be either 0 or 1, indicating whether the corresponding element is included or excluded from the subset

            // Loop through all possible subsets and fill in the 2D subset array, using binary numbers to represent each subset.
            for (int i = 0; i < m; i++)
            {
                // This loop iterates over each element of the input array
                for (int j = 0; j < length; j++)
                {
                    // Calculates whether the j-th element should be included in the i-th subset. It does this by performing integer division on i with the corresponding
                    // power of 2, and then taking the remainder when divided by 2. This gives a binary representation of the subset.
                    subsets[i, j] = i / (m / 2 / (1 << j)) % 2;
                }
            }
            // Loop through all possible subsets and find the longest increasing sub-sequence.
            // This loop iterates through each row of the 'subsets' array.
            for (int i = 0; i < m; i++)
            {
                // Initialize the maximum value and the count of increasing numbers to zero.
                int max = -1000;
                int count = 0;

                // This loop iterates through each column of the current row.
                for (int j = 0; j < length; j++)
                {
                    // Check if the current element of the 'subsets' array is greater than zero.
                    if (subsets[i, j] > 0)
                    {
                        // If the current element of 'arr' is greater than or equal to the maximum value seen so far,
                        // increment the count and update the maximum value.
                        if (arr[j] >= max)
                        {
                            count++;
                            max = arr[j];
                        }
                        // If the current element of 'arr' is less than the maximum value seen so far,
                        // reset the count and break out of the loop.
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                }
                // At the end of the inner loop, the 'count' variable contains the length of the longest increasing subsequence that corresponds to the current row of the 'subsets' array.

                // Update the longest increasing sub-sequence and subset
                // If the length of the longest increasing subsequence seen so far is less than the length of the current subsequence,
                // update the 'longestLength' variable and record the current subset index in the 'subset' variable.
                if (longestLength < count)
                {
                    longestLength = count;
                    subset = i;
                }
            }

            // Output the longest increasing sub-sequence by iterating through the subset array and printing the corresponding elements in the original array
            Console.Write("Result : ");
            for (int i = 0; i < length; i++)
            {
                if (subsets[subset, i] > 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            // Wait for the user to press a key before closing the console window.
            Console.ReadLine();

            #endregion

        }
    }
}
