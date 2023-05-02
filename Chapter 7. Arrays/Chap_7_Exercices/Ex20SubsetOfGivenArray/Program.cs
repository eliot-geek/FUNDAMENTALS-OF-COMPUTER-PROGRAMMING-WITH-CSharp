using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex20SubsetOfGivenArray
{
    class Program
    {
        // Define variables to store the possible sum and whether a solution was found
        static int possibleSum;
        static bool solution = false;

        /// <summary>
        /// Recursive function to generate all possible subsets of the given array and check them - Genereate Subset
        /// </summary>
        /// <param name="arr">the input array</param>
        /// <param name="subset">array to hold the current subset being generated</param>
        /// <param name="index">index of the current element in subset</param>
        /// <param name="current">index of the current element in arr to be considered for the subset</param>
        /// <param name="elementsSubset">number of elements in the subset being generated</param>
        static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsSubset)
        {
            // If the subset is complete, check it for the desired sum - // If the current subset is of required size, call CheckSubsets method and return
            if (index == elementsSubset)
            {
                CheckSubsets(subset, elementsSubset);
                return;
            }

            // Otherwise, for each element in arr starting from index 'current', add it to the subset and call the method recursively for next element in arr
            // For each element in the array starting from the current position, add it to the subset and generate the next element recursively
            for (int i = current; i < arr.Length; i++)
            {
                subset[index] = arr[i];
                GenerateSubset(arr, subset, index + 1, i + 1, elementsSubset);
            }
        }

        /// <summary>
        /// Check if a subset has the desired sum and print it if it does - Check Subsets
        /// </summary>
        /// <param name="subset"></param>
        /// <param name="elementsSubset"></param>
        static void CheckSubsets(int[] subset, int elementsSubset)
        {
            int sum = 0;    // Initialize sum to zero
            // Calculate the sum of all elements in the subset
            for (int i = 0; i < elementsSubset; i++)
            {
                sum += subset[i];
            }

            // If the sum of elements in the subset is equal to the desired sum
            if (sum == possibleSum)
            {
                // Print the subset elements separated by a space
                for (int i = 0; i < elementsSubset; i++)
                {
                    Console.Write("{0} ", subset[i]);
                }
                Console.WriteLine(); // Move to the next line
                solution = true; // Set solution flag to true
            }
        }

        static void Main(string[] args)
        {
            #region Task 20
            /* Write a program, which checks whether there is a subset of given array of N elements, which has a sum S. The numbers N, S and the array values 
            are read from the console. Same number can be used many times. Example: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14 => yes (1 + 2 + 5 + 6 = 14)
            
            Guide: Generate all possible sums this way: take all the numbers and mark them as "possible sum". Then take every number ko, k2, …, kn-1 and for 
            each already marked "possible sum" p, mark as possible the sum p+ki. If at some step you get S, a solution is found. You can keep track of the 
            "possible sums" either in a bool[] array possible[], where each index is a possible sum, or in a more complex data structure like Set<int>. 
            Once you have possible[S] == true, you can find a number ki such that possible[S-ki] == true, print ki and subtract it from S. Repeat the same 
            to find the next ki and print and subtract is again, until S reaches 0.

            Another algorithm: generate all possible subsets of the numbers by a for-loop from 0 to 2N-1. If we have a number p, take its binary representation 
            (which consists of exactly N bits) and sum the numbers that correspond to 1 in the binary representation of p (with a nested loop from 0 to N-1). 
            Thus all possible sums will be generated and if some of them is S, it can be printed. Note that this algorithm is slow (needs exponential time and 
            cannot run for 100 or 1000 elements). It also does not allow using the same array element twice in the sum. */
            #endregion


            #region First way 

            Console.WriteLine("Write a program, which checks whether there is a subset of given array of N elements, which has a sum S.");
            // Read the input values from the console
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter S: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers separated by space: ", n);
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            List<int> possibleSums = new List<int>();
            possibleSums.Add(0); // an empty subset has a sum of 0

            // Find all possible sums using dynamic programming
            for (int i = 0; i < n; i++)
            {
                int count = possibleSums.Count; // need to cache the count
                for (int j = 0; j < count; j++)
                {
                    int sum = possibleSums[j] + numbers[i];
                    if (sum == s)
                    {
                        // A subset that adds up to the target sum has been found
                        Console.WriteLine("Yes ({0})", String.Join(" + ", possibleSums[j], numbers[i]));
                        return;
                    }
                    possibleSums.Add(sum);
                }
            }
            // No subset found
            Console.WriteLine("No subset with sum {0}", s);

            #endregion


            #region Second way

            // Read the input values from the console
            Console.Write("\nEnter N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter S: ");
            s = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} numbers separated by space: ", n);
            int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            bool foundSubset = false;

            // Generate all possible subsets of the array
            for (int i = 0; i < (1 << n); i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        sum += number[j];
                    }
                }

                if (sum == s)
                {
                    // Found a subset with the target sum
                    foundSubset = true;
                    Console.Write("Yes (");
                    for (int j = 0; j < n; j++)
                    {
                        if ((i & (1 << j)) != 0)
                        {
                            Console.Write("{0}", number[j]);
                            if (sum - number[j] > 0)
                            {
                                Console.Write(" + ");
                            }
                            sum -= number[j];
                        }
                    }
                    Console.WriteLine(" = {0})", s);
                }
            }

            if (!foundSubset)
            {
                Console.WriteLine("No subset with sum {0}", s);
            }

            Console.ReadLine();

            #endregion


            #region Method way

            Console.WriteLine("\nWrite a program, which checks whether there is a subset of given array of N elements, which has a sum S.");
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Enter Sum : ");
            possibleSum = Int32.Parse(Console.ReadLine());

            int[] subs = new int[length];

            for (int i = 1; i <= length; i++)
            {
                GenerateSubset(arr, subs, 0, 0, i);
            }
            if (!solution)
            {
                Console.WriteLine("No subset with sum {0} found.", possibleSum);
            }
            Console.ReadLine();

            #endregion
        }
    }
}
