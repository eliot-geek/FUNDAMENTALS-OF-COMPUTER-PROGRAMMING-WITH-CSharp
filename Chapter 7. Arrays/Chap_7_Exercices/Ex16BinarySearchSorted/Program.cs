using System;

namespace Ex16BinarySearchSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 16
            /* Write a program, which uses a binary search in a sorted array of integer numbers to find a certain element.
             Guide: Find on the Internet information about the algorithm "binary search". Note that binary search works only on sorted arrays.*/
            #endregion

            Console.WriteLine("Solution Binary Search");
            Console.WriteLine("Write a program, which uses a binary search in a sorted array of integer numbers to find a certain element");
            // Create a sorted array of integer numbers
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            // Get the number to search for from the user
            Console.Write("Enter a number to search for: ");
            int searchNumber = int.Parse(Console.ReadLine());

            // Perform binary search
            int left = 0;
            int right = numbers.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (numbers[middle] == searchNumber)
                {
                    // Number is found
                    Console.WriteLine("{0} found at index {1}.", searchNumber, middle);
                    break;
                }
                else if (numbers[middle] < searchNumber)
                {
                    // Number is in the right half of the array
                    left = middle + 1;
                }
                else
                {
                    // Number is in the left half of the array
                    right = middle - 1;
                }
            }

            // If the number is not found, output a message
            if (left > right)
            {
                Console.WriteLine("{0} not found in the array.", searchNumber);
            }
            Console.ReadKey();
        }
    }
}
