using System;

namespace Ex21FindKOutOfNumbersNSum
{
    class Program
    {
        /// <summary>
        /// This method recursively finds a subset of the given array that sums to the given sum and has the given size - Find Solution
        /// </summary>
        /// <param name="arr">is an array of integers representing the input numbers</param>
        /// <param name="filter">is a boolean array of the same length as arr, used to keep track of which elements are included in the current subset being considered by the algorithm</param>
        /// <param name="index">is an integer representing the index of the current element in the arr array being considered by the algorithm</param>
        /// <param name="summa">is an integer representing the desired sum of the subset being searched for</param>
        /// <param name="size"> is an integer representing the desired size of the subset being searched for</param>
        /// <returns></returns>
        public static int[] FindSolution(int[] arr, bool[] filter, int index, int summa, int size)
        {
            // If we haven't considered all elements of the array yet
            if (index < arr.Length)
            {
                // Include the current element in the subset and continue the search
                filter[index] = true;
                int[] x = FindSolution(arr, filter, index + 1, summa, size);
                
                // If a solution was found, return it
                if (x.Length > 0)
                {
                    return x;
                }
                else
                {
                    // Otherwise, exclude the current element and continue the search
                    filter[index] = false;
                    return FindSolution(arr, filter, index + 1, summa, size);
                }
            }
            else
            {
                // If we have considered all elements of the array, check if the current subset satisfies the conditions
                int sum = 0, count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (filter[i])
                    {
                        sum += arr[i];
                        count++;
                    }
                }
                // If the subset sums up to "summa" and has the correct size, return it
                int[] solution = new int[0];
                if (sum == summa && count == size)
                {
                    solution = new int[count];
                    count = 0;

                    // Copy the selected elements to the solution array
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (filter[i])
                        {
                            solution[count++] = arr[i];
                        }
                    }
                }
                return solution;
            }
        }
        
        static void Main(string[] args)
        {
            #region Task 21
            /* Write a program which by given N numbers, K and S, finds K elements out of the N numbers, the sum of which is exactly S or says it is not possible.
            Example: {3, 1, 2, 4, 9, 6}, S = 14, K = 3 => yes (1 + 4 + 9 = 14)
            Guide: See the previous problem. Generate all subsets of exactly K elements (the second algorithm) and check if their sum is equal to S.  */
            #endregion


            #region One program way without method

            // The input array of numbers
            int[] numbers = { 3, 1, 2, 4, 9, 6 };
            // The desired sum
            int S = 14;
            // The number of elements to choose
            int K = 3;
            // The length of the input array
            int n = numbers.Length;

            // Initialize a boolean variable to indicate if a solution was found
            bool solutionFound = false;

            // Generate all subsets of exactly K elements and check if their sum is S
            for (int i = 0; i < (1 << n); i++)
            {
                // Initialize a variable to store the sum of the selected numbers
                int sum = 0;
                // Initialize a variable to store the count of the selected numbers
                int count = 0;

                // Calculate the sum and count of elements in each subset
                // Loop through each number of the original array and check if it's included in the current subset
                for (int j = 0; j < n; j++)
                {
                    // Use a bit mask to determine whether the j-th element of the original array should be included in the subset
                    // If the j-th element is included in the subset, add it to the sum and increment the count
                    if ((i & (1 << j)) != 0)
                    {
                        sum += numbers[j];
                        count++;
                    }
                }
                // If the sum and count are correct, print the solution and set the solutionFound flag to true
                // Check if the current subset has exactly K elements and its sum is equal to S
                if (sum == S && count == K)
                {
                    // Print the solution
                    Console.WriteLine("Solution found: ");
                    for (int j = 0; j < n; j++)
                    {
                        if ((i & (1 << j)) != 0)
                        {
                            Console.Write(numbers[j] + " ");
                        }
                    }
                    Console.WriteLine();
                    // Set the flag to indicate that a solution has been found
                    solutionFound = true;
                    // Exit the loop since a solution has been found
                    break;
                }
            }
            // If no solution was found, print a message indicating that fact
            if (!solutionFound)
            {
                Console.WriteLine("No solution found.");
            }
            Console.ReadLine();
            Console.ReadKey();

            #endregion


            #region Method Call Solution

            Console.WriteLine("Write a program which by given N numbers, K and S, finds K elements out of the N numbers, the sum of which is exactly S");
            // Prompt the user to enter the number of input numbers (N)
            Console.Write("Enter N numbers : ");
            n = Int32.Parse(Console.ReadLine());

            // Prompt the user to enter the number of elements to include in the subset (K)
            Console.Write("Enter K elements : ");
            int size = Int32.Parse(Console.ReadLine());

            // Create an array to store the input numbers
            int[] array = new int[n];

            // Prompt the user to enter each input number one at a time
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} : ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            // Prompt the user to enter the desired sum of the subset
            Console.Write("Sum of elements, Summa : ");
            int summa = Int32.Parse(Console.ReadLine());

            // Find the solution by calling the FindSolution method with the input parameters
            int[] solution = FindSolution(array, new bool[array.Length], 0, summa, size);

            // Print the solution to the console
            Console.Write("Your solution : ");
            for (int i = 0; i < solution.Length; i++)
            {
                Console.Write(solution[i] + " ");
            }
            // Wait for the user to press enter before closing the console window
            Console.ReadLine();

            #endregion

        }
    }
}
