using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex26PrintsAllPermutations
{
    class Program
    {
        /// <summary>
        /// All Permutations - This method takes in a list, a start string and another string 'str'
        /// </summary>
        /// <param name="list"></param>
        /// <param name="start"></param>
        /// <param name="str"></param>
        /// <returns>Returns all permutation of 'str'</returns>
        public static List<string> AllPermutations(List<string> list, String start, String str)
        {
            // If the length of 'str' is less than or equal to 1, add the concatenation of 'start' and 'str' to the list
            if (str.Length <= 1)
                list.Add(start + str);
            // Otherwise, loop through each character in 'str'
            else
                for (int i = 0; i < str.Length; i++)
                {
                    // Create a new string by removing the character at the current index in 'str'
                    String newStr = str.Substring(0, i) + str.Substring(i + 1);
                    // Recursively call the method with a new 'start' string containing the current character, and the new string without the removed character
                    AllPermutations(list, start + str.ElementAt(i), newStr);
                }
            // Return the list of all permutations
            return list;
        }

        /// <summary>
        /// Define a function to generate permutations recursively
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        /// <param name="n"></param>
        public static void GeneratePermutations(int[] arr, int size, int n)
        {
            // Base case: if current size of the array is equal to n, print it
            if (size == n)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            // Recursive case: generate all possible permutations
            for (int i = size; i < n; i++)
            {
                Swap(ref arr[i], ref arr[size]);        // Swap the i-th element with the size-th element
                GeneratePermutations(arr, size + 1, n); // Recursively generate permutations for the remaining elements
                Swap(ref arr[i], ref arr[size]);        // Swap back the elements to restore the original array
            }
        }

        /// <summary>
        /// Define a function to swap two elements in an array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            #region Task 26
            /* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
            Example: N = 3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1} */
            #endregion


            Console.WriteLine("Solution 1");
            Console.Write("Enter a number N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("All possible permutations are : ");
            int[] arr = Enumerable.Range(1, n).ToArray();       // Initialize the array with numbers [1 ... N]
            GeneratePermutations(arr, 0, n);                    // Generate and print all permutations
            Console.ReadKey();


            Console.WriteLine("\nSolution 2");
            // Read some integer number
            Console.Write("Please, enter some integer number : ");
            int N = int.Parse(Console.ReadLine());
            // Create one word with all needed numbers
            string word = String.Empty;
            for (int i = 1; i <= N; i++)
            {
                word += i;
            }
            // Find all permutations of the numbers
            List<string> numbers = new List<string>();
            numbers = AllPermutations(numbers, "", word);
            // Print all possible permutations
            Console.WriteLine("All possible permutations are : ");
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
