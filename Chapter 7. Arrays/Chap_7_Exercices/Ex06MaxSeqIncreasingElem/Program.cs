using System;
using System.Collections.Generic;

namespace Ex06MaxSeqIncreasingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 6
            // Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. 
            // It is not necessary the elements to be consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} --> {2, 4, 6, 8}.

            // Guide: We can solve the problem with two nested loops and one more array len[0…n-1]. In the array len[i] we can keep the length of the longest
            // consecutively increasing sequence, which starts somewhere in the array (it does not matter where exactly) and ends with the element arr[i].
            // Therefore len[0]=1, len[x] is the maximal sum max(1 + len[prev]), where prev < x and arr[prev] < arr[x]. Following the definition, we can
            // calculate len[0…n-1] with two nested loops: the outer loop will iterate through the array from left to right with the loop variable x.
            // The inner loop will iterate through the array from the start to position x-1 and searches for the element prev with maximal value of len[prev], 
            // where arr[prev] < arr[x]. After the search, we initialize len[x] with 1 + the biggest found value of len[prev] or with 1, if such a value is
            // not found. The described algorithm finds the lengths of all maximal ascending sequences, which end at each of the elements.
            // The biggest one of these values is the length of the longest increasing sequence. If we need to find the elements themselves, which compose that
            // longest sequence, we can start from the element, where the sequence ends (at index x), we can print it and we can search for a previous element
            // (prev). By definition prev < x and len[x] = 1 + len[prev] so we can find prev with a for-loop from 1 to x-1. After that we can repeat the same
            // for x=prev. By finding and printing the previous element (prev) many times until it exists, we can find the elements, which compose the longest
            // sequence in reversed order (from the last to the first).
            #endregion

            Console.WriteLine("Write a program, which finds the maximal sequence of increasing elements in an array");

            int counter = 0;    // Initialize a counter variable to keep track of the length of the longest increasing subsequence found so far
            int tempIndex;      // Declare a temporary index variable to keep track of the last index in the current subsequence
            int tempCounter;    // Declare a temporary counter variable to keep track of the length of the current subsequence

            Console.Write("Enter the array's length : ");   // Prompt the user to enter the length of the array
            int length = Int32.Parse(Console.ReadLine());   // Read in the length entered by the user and store it in the 'length' variable as an integer

            int[] arr = new int[length];     // Declare an integer array 'arr' of size 'length' to hold user-entered values
            int[] result = new int[length];  // Declare an integer array 'result' of size 'length' to hold the longest increasing subsequence found so far

            // Loop through each element in the 'arr' array
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);    // Prompt the user to enter the i-th element of the array
                arr[i] = Int32.Parse(Console.ReadLine());    // Read in the i-th element entered by the user and store it in the 'arr' array
            }

            // Loop through each element in the 'arr' array
            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];    // Declare a temporary integer array to hold the current increasing subsequence
                tempIndex = tempCounter = 1;           // Initialize temporary variables 'tempIndex' and 'tempCounter' to 1
                tempResult[0] = arr[i];                // Initialize the first element of 'tempResult' with the i-th element of 'arr'

                // Loop through the remaining elements of 'arr' starting from i+1
                for (int jj = i + 1; jj < length; jj++)
                {
                    if (arr[jj] > tempResult[tempIndex - 1])  // If the j-th element of 'arr' is greater than the last element of 'tempResult'
                    {
                        tempResult[tempIndex] = arr[jj];      // Add the j-th element of 'arr' to 'tempResult'
                        tempIndex++;                         // Increment 'tempIndex'
                        tempCounter++;                       // Increment 'tempCounter'
                    }
                    else if (tempIndex > 1 && arr[jj] > tempResult[tempIndex - 2] && arr[jj] < tempResult[tempIndex - 1])
                    {
                        // Replace the second-last element of 'tempResult' with the j-th element of 'arr'
                        tempResult[tempIndex - 1] = arr[jj];
                    }
                }
                if (counter < tempCounter)     // If the length of the increasing subsequence found is greater than the longest one found so far
                {
                    counter = tempCounter;     // Update the length of the longest increasing subsequence found so far
                    result = tempResult;       // Update the longest increasing subsequence found so far with the current one
                }
            }
            // Loop through the result array and print each element separated by a comma and space
            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0} ", result[i]);
            }
            // Wait for the user to press Enter before closing the console window
            Console.ReadLine();


        }
    }
}
