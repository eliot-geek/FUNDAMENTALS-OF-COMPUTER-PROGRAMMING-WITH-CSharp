namespace Ex09BigElemSortArray
{
    internal class Program
    {
        /// <summary>
        /// Method to find the biggest element in the given range of the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        static int FindBiggestElement(int[] arr, int start, int end)
        {
            int maxIndex = start;
            for (int i = start + 1; i <= end; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// Method to swap two elements in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        static void SwapElements(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// Method to perform sorting in descending order using the selection sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        static void SortDescending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Find the index of the biggest element in the range [i...n-1]
                int maxIndex = FindBiggestElement(arr, i, arr.Length - 1);
                // Swap the biggest element with the element at position i
                SwapElements(arr, i, maxIndex);
            }
        }

        /// <summary>
        /// Method to perform sorting in ascending order using the selection sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        static void SortAscending(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // Find the index of the biggest element in the range [i...n-1]
                int maxIndex = FindBiggestElement(arr, 0, i);
                // Swap the biggest element with the element at position i
                SwapElements(arr, i, maxIndex);
            }
        }


        /// <summary>
        /// Method to print the elements of the array
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Task 09
            /* Write a method that finds the biggest element of an array. Use that method to implement sorting in descending order.
            Guide: First write a method that finds the biggest element in array and then modify it to find the biggest element in given range of the array, e.g. 
            in the elements at indexes [3…10]. Finally find the biggest number in the range [1…n-1] and swap it with the first element, 
            then find the biggest element in the range [2…n-1] and swap it with the second element of the array and so on. Think when the algorithm should finish. */
            #endregion

            int[] array = { 12, 45, 7, 99, 23, 56, 34, 67, 87, 1, 100 };
            int maxElement = array[FindBiggestElement(array, 0, array.Length - 1)];
            Console.WriteLine("The biggest element in the array is: " + maxElement);

            SortDescending(array);
            Console.WriteLine("Array sorted in descending order:");
            PrintArray(array);

            SortAscending(array);
            Console.WriteLine("Array sorted in ascending order:");
            PrintArray(array);
            Console.ReadLine();



            Console.WriteLine("\nSecond Solution");
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("\nEnter start index: ");
            int startIndex = Int32.Parse(Console.ReadLine());
            Console.Write("Enter end index: ");
            int endIndex = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Biggest number in interval {0}-{1} is {2}.", startIndex, endIndex, FindBiggestElement(arr, startIndex, endIndex));
            Console.ReadLine();
        }
    }
}