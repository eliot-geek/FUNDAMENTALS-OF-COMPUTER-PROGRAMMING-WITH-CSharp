using System;

namespace Ex23AllVariatOfKElements
{
    class Program
    {
        // By declaring the variable as public, it can be accessed from anywhere in the program.
        // By declaring it as static, it can be accessed without creating an instance of the class it belongs to.
        // The variable is declared as an integer (int), but it is not initialized to any value.It is simply declared so that it can be used later in the program.
        public static int n;

        /// <summary>
        /// This is a recursive function that takes an array and an index as input parameters. It will generate all possible permutations of the array using recursion.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        static void RecSolution(int[] array, int index)
        {
            // If the index is not equal to the length of the array, set the elements at the current index to values between 1 and n recursively
            // Check if the current index is less than the length of the array. If it is, continue generating permutations by calling the function recursively.
            if (index != array.Length)
            {
                // Loop through all possible values for the current index and set the current index of the array to each value in turn.
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    // Call the function recursively with the array and the next index.
                    RecSolution(array, index + 1);
                }
            }
            // If the index is equal to the length of the array, print the array to the console
            // If the current index is equal to the length of the array, then we have generated a complete permutation, so we print it to the console.
            else
            {
                // Print an opening curly brace to the console.
                Console.Write("{");
                // Loop through the array and print each element with a space on either side.
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(" " + array[i] + " ");
                }
                // Print a closing curly brace to the console.
                Console.Write("}");
                // Print a new line to the console.
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            #region Task 23
            /* Write a program, which reads the integer numbers N and K from the console and prints all variations of K elements of the numbers in the interval 
            [1…N]. Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.
            
            Guide: Start from the first variation in the lexicographical order: {1, 1, …} K times. Think of this as k-digit number. To obtain the next variation, increase the last digit. 
            If it becomes greater than N, change it to 1 and increase the next digit on the left. Do the same on the left until the first digit goes greater than N. */
            #endregion

            Console.WriteLine("Solution 1");
            // Prompt the user to enter a value for n
            Console.Write("Enter number N : ");
            n = Int32.Parse(Console.ReadLine());
            // Prompt the user to enter a value for k
            Console.Write("Enter number K : ");
            int k = Int32.Parse(Console.ReadLine());
            // Create an array of size k to store the solution
            int[] myArray = new int[k];
            // Call the recursive solution with the array and starting index set to 0
            RecSolution(myArray, 0);
            Console.ReadLine();



            Console.WriteLine("\nSolution 2");
            // Read the input values N and K from the console
            Console.Write("Enter number N : ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter number K : ");
            int K = int.Parse(Console.ReadLine());

            // Create an array to store the current variation
            int[] variation = new int[K];

            // Initialize the first variation to {1, 1, ..., 1} K times
            for (int i = 0; i < K; i++)
            {
                variation[i] = 1;
            }
            Console.Write("{");
            // Print the first variation
            Console.Write(string.Join(" ", variation));
            Console.Write("}\n");

            // Generate and print the remaining variations
            while (true)
            {
                // Initialize the index of the rightmost element
                int index = K - 1;
                // Increment the rightmost element until it becomes greater than N or until it reaches the leftmost element
                while (index >= 0 && variation[index] == N)
                {
                    index--;
                }

                // If all elements are greater than N, break the loop
                if (index < 0)
                {
                    break;
                }

                // Increment the current element
                variation[index]++;
                // Set all elements to the right of the current element to 1
                for (int i = index + 1; i < K; i++)
                {
                    variation[i] = 1;
                }
                Console.Write("{");
                // Print the current variation
                Console.Write(string.Join(" ", variation));
                Console.Write("}\n");
            }
            Console.ReadKey();
        }
    }
}
