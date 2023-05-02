using System;

namespace Ex17MergeSortArray
{
    class Program
    {
        /// <summary>
        /// This method implements the merge step of the Merge Sort algorithm to merge two sorted sub-arrays into one sorted array
        /// Merge method to merge two sorted subarrays - Doing Merge Sort 
        /// </summary>
        /// <param name="numbers">an array of integers</param>
        /// <param name="left">the indice of the left sub-array</param>
        /// <param name="middle">the index of the middle element</param>
        /// <param name="right">the indice of the right sub-array</param>
        static public void MergeSort(int[] numbers, int left, int middle, int right)
        {
            // Create a temporary array to hold the sorted elements during the merge
            int[] temp = new int[25];
            // Initialize variables for the left end of the left sub-array, the number of elements to sort, and the current position in the temporary array
            int leftEnd, numbElements, tempPosition;

            // Set the index of the last element in the left sub-array
            leftEnd = (middle - 1);
            // Set the starting position for copying elements into the temporary array
            tempPosition = left;
            // Calculate the number of elements in the sub-array to be sorted
            numbElements = (right - left + 1);

            // Merge the two sub-arrays by comparing the elements at the current indices and adding the smaller element to the temporary array
            // Merge the left and right sub-arrays, copying the smallest element into the temporary array first, until one sub-array is fully processed
            while ((left <= leftEnd) && (middle <= right))
            {
                // If the left element is smaller than or equal to the middle element, copy the left element into the temporary array and increment the temporary array position and the left sub-array position
                if (numbers[left] <= numbers[middle])
                {
                    temp[tempPosition++] = numbers[left++];
                }
                // Otherwise, copy the middle element into the temporary array and increment the temporary array position and the right sub-array position
                else
                {
                    temp[tempPosition++] = numbers[middle++];
                }
            }

            // Copy any remaining elements in the left sub-array into the temporary array, since they are already sorted and greater than any elements in the right sub-array
            while (left <= leftEnd)
            {
                temp[tempPosition++] = numbers[left++];
            }

            // Copy any remaining elements in the right sub-array into the temporary array, since they are already sorted and greater than any elements in the left sub-array
            while (middle <= right)
            {
                temp[tempPosition++] = numbers[middle++];
            }

            // Copy the sorted elements from the temporary array back into the original array in descending order
            for (int i = 0; i < numbElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        /// <summary>
        /// Merge sort algorithm - Merge Sort Recursive
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static public void MergeSortRecursive(int[] numbers, int left, int right)
        {
            int middle;
            if (right > left)
            {
                middle = (right + left) / 2;                            // Find the middle point of the array
                MergeSortRecursive(numbers, left, middle);              // Sort the left half of the array
                MergeSortRecursive(numbers, (middle + 1), right);       // Sort the right half of the array
                
                MergeSort(numbers, left, (middle + 1), right);          // Merge the two sorted halves of the array
            }
        }

        /// <summary>
        /// Merge sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static public void MergeSort2(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point of the array
                int mid = (left + right) / 2;
                // Sort the left half of the array
                MergeSort2(arr, left, mid);
                // Sort the right half of the array
                MergeSort2(arr, mid + 1, right);
                // Merge the two sorted halves of the array
                Merge(arr, left, mid, right);
            }
        }

        /// <summary>
        /// Merge method to merge two sorted subarrays
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        static void Merge(int[] arr, int left, int mid, int right)
        {
            // Create temporary arrays to hold the two halves of the array
            int[] leftArray = new int[mid - left + 1];
            int[] rightArray = new int[right - mid];

            // Copy the left half of the array into the left temporary array
            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = arr[left + i];
            }

            // Copy the right half of the array into the right temporary array
            for (int i = 0; i < rightArray.Length; i++)
            {
                rightArray[i] = arr[mid + 1 + i];
            }

            // Merge the two temporary arrays back into the original array
            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = left;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    arr[mergeIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[mergeIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergeIndex++;
            }

            // Copy the remaining elements from the left temporary array into the original array
            while (leftIndex < leftArray.Length)
            {
                arr[mergeIndex] = leftArray[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            // Copy the remaining elements from the right temporary array into the original array
            while (rightIndex < rightArray.Length)
            {
                arr[mergeIndex] = rightArray[rightIndex];
                rightIndex++;
                mergeIndex++;
            }
        }

        /// <summary>
        /// Merge sort algorithm with three preallocated arrays
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="tempArray1"></param>
        /// <param name="tempArray2"></param>
        /// <param name="resultArray"></param>
        static void MergeSort3(int[] ar, int left, int right, int[] tempArray1, int[] tempArray2, int[] resultArray)
        {
            if (left < right)
            {
                // Find the middle point of the array
                int mid = (left + right) / 2;

                // Sort the left half of the array
                MergeSort3(ar, left, mid, tempArray1, tempArray2, resultArray);

                // Sort the right half of the array
                MergeSort3(ar, mid + 1, right, tempArray1, tempArray2, resultArray);

                // Merge the two sorted halves of the array
                Merge3(ar, left, mid, right, tempArray1, tempArray2, resultArray);
            }
            else
            {
                // If there is only one element in the array, copy it to the result array
                resultArray[left] = ar[left];
            }
        }

        /// <summary>
        /// Merge method to merge two sorted subarrays with three preallocated arrays
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        /// <param name="tempArray1"></param>
        /// <param name="tempArray2"></param>
        /// <param name="resultArray"></param>
        static void Merge3(int[] arr, int left, int mid, int right, int[] tempArray1, int[] tempArray2, int[] resultArray)
        {
            // Copy the left half of the array into the first temporary array
            for (int i = left; i <= mid; i++)
            {
                tempArray1[i] = arr[i];
            }

            // Copy the right half of the array into the second temporary array
            for (int i = mid + 1; i <= right; i++)
            {
                tempArray2[i] = arr[i];
            }

            // Merge the two temporary arrays back into the original array
            int leftIndex = left;
            int rightIndex = mid + 1;
            int mergeIndex = left;

            while (leftIndex <= mid && rightIndex <= right)
            {
                if (tempArray1[leftIndex] <= tempArray2[rightIndex])
                {
                    resultArray[mergeIndex] = tempArray1[leftIndex];
                    leftIndex++;
                }
                else
                {
                    resultArray[mergeIndex] = tempArray2[rightIndex];
                    rightIndex++;
                }
                mergeIndex++;
            }

            // Copy the remaining elements from the left temporary array into the result array
            // Copy the remaining elements from the left temporary array into the result array
            while (leftIndex <= mid)
            {
                resultArray[mergeIndex] = tempArray1[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            // Copy the remaining elements from the right temporary array into the result array
            while (rightIndex <= right)
            {
                resultArray[mergeIndex] = tempArray2[rightIndex];
                rightIndex++;
                mergeIndex++;
            }

            // Copy the sorted elements from the result array back into the original array
            for (int i = left; i <= right; i++)
            {
                arr[i] = resultArray[i];
            }
        }

        static void Main(string[] args)
        {
            #region Task 17
            /* Write a program, which sorts an array of integer elements using a "merge sort" algorithm.
            Guide: Find on the Internet information about the algorithm "merge sort" and its implementations in C#. It is a bit complicated to write merge sort 
            efficiently. You can have 3 preallocated arrays when merging arrays: two arrays for keeping the numbers for merging and а result array. 
            Thus you will never allocate new arrays during the algorithm’s execution. The arrays will be allocated just once at the start and you will just 
            change their purpose (swap them) during the algorithm execution. */
            #endregion


            #region MergeSortRecursive and MergeSort

            Console.WriteLine("Write a program, which sorts an array of integer elements using a \"merge sort\" algorithm");
            // Ask the user to enter the size of the array
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());

            // Ask the user to enter the array elements
            int[] array = new int[length];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            // Sort the array using merge sort
            MergeSortRecursive(array, 0, array.Length - 1);

            // Display the sorted array
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();

            #endregion


            #region MergeSort2 and Merge
            
            // Ask the user to enter the size of the array
            Console.Write("\nEnter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            // Ask the user to enter the array elements
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Sort the array using merge sort
            MergeSort2(arr, 0, arr.Length - 1);

            // Display the sorted array
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region MergeSort3 and Merge3

            // Ask the user to enter the size of the array
            Console.Write("\nEnter the size of the array: ");
            size = int.Parse(Console.ReadLine());

            // Ask the user to enter the array elements
            int[] ar = new int[size];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}: ", i);
                ar[i] = int.Parse(Console.ReadLine());
            }

            // Sort the array using merge sort
            int[] tempArray1 = new int[size];
            int[] tempArray2 = new int[size];
            int[] resultArray = new int[size];

            MergeSort3(ar, 0, size - 1, tempArray1, tempArray2, resultArray);

            // Display the sorted array
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", resultArray[i]);
            }
            Console.WriteLine();
            Console.ReadKey();

            #endregion

        }
    }
}
