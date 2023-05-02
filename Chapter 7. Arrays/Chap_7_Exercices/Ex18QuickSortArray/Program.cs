using System;

namespace Ex18QuickSortArray
{
    class Program
    {
        /// <summary>
        /// Quick sort method that recursively sorts the array - Quick Sort
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void DoQuickSort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            // Selecting a pivot element
            IComparable pivot = elements[(left + right) / 2];

            // Partitioning the array into two sections based on the pivot
            while (i <= j)
            {
                // Finding the leftmost element greater than the pivot
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                // Finding the rightmost element less than the pivot
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                // Swapping the elements to their correct positions
                if (i <= j)
                {
                    int temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = temp;
                    i++;
                    j--;
                }
            }

            // Recursively calling the DoQuickSort method for the left and right sections of the array
            if (left < j)
            {
                DoQuickSort(elements, left, j);
            }
            if (i < right)
            {
                DoQuickSort(elements, i, right);
            }
        }

        /// <summary>
        /// QuickSort method that sorts an array of integers
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(arr, left, right);   // Get the pivot index

                // Recursively call QuickSort on the left and right sides of the pivot
                QuickSort(arr, left, pivotIndex - 1);           // Recursively sort the left subarray
                QuickSort(arr, pivotIndex + 1, right);          // Recursively sort the right subarray
            }
        }

        /// <summary>
        /// Partition method that selects a pivot and partitions the array into two sections
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right]; // Choose the rightmost element as pivot
            int i = left - 1; // Index of smaller element

            for (int j = left; j < right; j++)
            {
                // If current element is smaller than or equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;
                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[right] (or pivot)
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp2;

            return i + 1;
        }

        static void Main(string[] args)
        {
            #region Task 18
            /* Write a program, which sorts an array of integer elements using a "quick sort" algorithm.
            Guide: Find information about the "quick sort" algorithm in Internet and its C# implementations. It can be best implemented by using recursion. 
            See the chapter “Recursion” to read about recursive algorithms. Generally at each step you choose an element called pivot and reorder the array 
            into two sections: at the left side move all elements ≤ pivot and at the right side move all elements > pivot. Finally run the quicksort algorithm 
            recursively over the left and the right sides. */
            #endregion


            #region QuickSort and Partition
            
            Console.WriteLine("Write a program, which sorts an array of integer elements using a \"quick sort\" algorithm.");
            // Define an unsorted array of integers
            int[] numbers = { 5, 8, 1, 3, 7, 9, 2, 6, 4 };

            // Call the QuickSort method to sort the array
            QuickSort(numbers, 0, numbers.Length - 1);

            // Print the sorted array to the console
            Console.WriteLine("Sorted array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); Console.ReadKey();

            #endregion


            #region DoQuickSort
            
            Console.WriteLine("\nWrite a program, which sorts an array of integer elements using a \"quick sort\" algorithm.");
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            DoQuickSort(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.ReadLine(); Console.ReadKey();

            #endregion
        }
    }
}
