namespace Ex06FirstBiggerNeigh
{
    internal class Program
    {
        /// <summary>
        /// Method to find the position of the first element greater than its neighbors 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Returns the position if found, otherwise returns -1</returns>
        static int FindFirstElementGreaterThanNeighbors(int[] arr)
        {
            // If the array has less than 3 elements, it's not possible to have an element with two neighbors - So, return -1 as per the requirement
            if (arr.Length < 3)
                return -1;

            // Iterate through the array starting from the second element (index 1) to the second-to-last element (index arr.Length - 2)
            // We don't need to check the first and last elements since they have only one neighbor each
            for (int i = 1; i < arr.Length - 1; i++)
            {
                // Check if the current element (arr[i]) is greater than both its neighbors
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    return i; // If condition satisfies, return the current index as the first occurrence found
            }
            // If no element satisfying the condition is found, return -1
            return -1;
        }

        static void Main(string[] args)
        {
            #region Task 06
            /* Write a method that returns the position of the first occurrence of an element from an array, such that it is greater than its two neighbors simultaneously. 
            Otherwise the result must be -1. 
            Guide: Invoke the method from the previous problem in a for-loop */
            #endregion

            // int[] array = { 1, 1, 1, 2, 2, 4, 4, 6 }; // No element found that satisfies the condition.
            int[] array = { 1, 3, 5, 2, 7, 4, 8, 6 };

            // Find the first element greater than its neighbors
            int result = FindFirstElementGreaterThanNeighbors(array);

            // Check if an element is found or not and display the result accordingly
            if (result != -1)
            {
                Console.WriteLine($"The first element greater than its neighbors is at position {result}");
            }
            else
            {
                Console.WriteLine("No element found that satisfies the condition.");
            }
        }
    }
}