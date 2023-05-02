using System;

namespace Ex08SortingAnArray
{
    class Program
    {
        /// <summary>
        /// Selection Sort Algorithm
        /// </summary>
        /// <param name="arr"></param>
        static void SelectionSortAlgorithm(int[] array)
        {
            int n = array.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min_idx])
                    {
                        min_idx = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            #region Task 8
            // Sorting an array means to arrange its elements in an increasing (or decreasing) order. 
            // Write a program, which sorts an array using the algorithm "selection sort".
            // Guide : Find in Internet information about "Selection sort" and its C# implementations. Briefly the idea is to find the smallest 
            // element and to place it at position 0 (through swapping) then to find the smallest number excluding the first and place it at 
            // position 1 and so on, until the entire array is arranged in ascending order.
            #endregion


            // Define an array of integers to be sorted
            int[] array = { 64, 25, 12, 22, 11 };
            // Sort the array using selection sort
            SelectionSortAlgorithm(array);
            // Print the sorted array
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(); Console.ReadKey();



            Console.WriteLine("\nWrite a program, which sorts an array using the algorithm [selection sort]");
            int Min;
            int temp;
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int j = 0; j < length - 1; j++)
            {
                Min = j;
                for (int i = j + 1; i < length; i++)
                {
                    if (arr[i] < arr[Min])
                    {
                        Min = i;
                    }
                }
                if (Min != j)
                {
                    temp = arr[j];              // moves the value of current element in temp
                    arr[j] = arr[Min];          // moves the value of min in current element
                    arr[Min] = temp;            // moves the current element on the free place from min element
                }
            }

            // Prints the sorted array
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
