using System;

namespace Ex07ConseElemWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 7
            // Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. 
            // Find those K consecutive elements in the array, which have maximal sum.
            // Guide : You can find out which sequence of the sequences of K numbers has the biggest sum by checking the sums of all of those 
            // sequences. The first sequence starts at index 0 and finishes at index K-1 and has sum S. Then the second one starts at index 1 and 
            // ends at index K and we can find its sum using S by subtracting the element at index 0 and adding the element at index K. 
            // In this way we can reach the end of the sequence
            #endregion


            Console.WriteLine("Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers");
            // Read the input values from the console
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            // Declare and initialize the array
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int maxSum = int.MinValue;
            int startIndex = 0;

            // Find the K consecutive elements with maximum sum
            for (int i = 0; i <= n - k; i++)
            {
                int currentSum = 0;
                // Calculate the sum of the current K consecutive elements
                for (int j = i; j < i + k; j++)
                {
                    currentSum += numbers[j];
                }
                // Update the maximum sum and the start index of the sequence
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = i;
                }
            }
            // Print the result
            Console.Write("The {0} consecutive elements with maximum sum are: ", k);
            for (int i = startIndex; i < startIndex + k; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine("(sum = {0})", maxSum);
        }
    }
}
