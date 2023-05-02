using System;

namespace Ex04MaxSequenceConsecElem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 4
            // Write a program, which finds the maximal sequence of consecutive equal elements in an array. 
            // E.g.: {1, 1, 2, 3, 2, 2, 2, 1} --> {2, 2, 2}.
            // Guide: Scan the array from left to right. Every time when the current number is different from the one before it, 
            // a new sequence starts. If the current element is equal to the one before it, it is a continuation of the same sequence.
            // So, if we keep the index of the start position of the current sequence (in the beginning it is 0) in start and the 
            // length of the current sequence (in the beginning it is 1) in len, we can find all sequences of equal elements and their 
            // lengths. We can easily keep the shortest one in two additional variables – bestStart and bestLen.
            #endregion


            Console.WriteLine("Write a program, which finds the maximal sequence of consecutive equal elements in an array");
            // Initialize the input array
            int[] arr = { 1, 1, 2, 3, 2, 2, 2, 1 };
            // Initialize variables to keep track of the longest consecutive subarray
            int start = 0, len = 1, bestStart = 0, bestLen = 1;
            // Iterate through the array, starting from the second element
            for (int i = 1; i < arr.Length; i++)
            {
                // If the current element is the same as the previous element, increment the length of the current run
                if (arr[i] == arr[i - 1])
                {
                    len++;
                }
                else // If the current element is different from the previous element, update the best subarray so far and start a new run
                {
                    // If the current run is longer than the best run so far, update the best subarray
                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                    // Start a new run from the current index
                    start = i;
                    len = 1;
                }
            }

            // Check if the last run is the longest one
            if (len > bestLen)
            {
                bestStart = start;
                bestLen = len;
            }

            // Print the longest consecutive subarray
            Console.Write("{ ");
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("}");
            Console.ReadLine();




            Console.WriteLine("\nSolution 2");
            // Initialize variables to keep track of the length and number of the longest consecutive subarray
            int count = 1;
            int tempCount = 1;
            int number = 0;

            // Read the length of the array from the user
            //int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());
            // Initialize an array with the given length and read its elements from the user
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            // Iterate through the array, starting from the first element, and count the consecutive runs of equal elements
            for (int i = 0; i < array.Length - 1; i++)
            {
                // If the current element is the same as the next element, increment the temporary count
                if (array[i] == array[i + 1]) 
                {
                    tempCount++;
                }
                // If the current element is different from the next element, update the count and the number if necessary
                else
                {
                    // Start a new run from the next element
                    tempCount = 1; 
                }
                // If the current run is longer than the longest run so far, update the count and the number
                if (tempCount > count) 
                {
                    count = tempCount;
                    number = array[i];
                }
            }
            // Print the longest consecutive subarray
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", number);
            }
            Console.ReadLine();
        }
    }
}
