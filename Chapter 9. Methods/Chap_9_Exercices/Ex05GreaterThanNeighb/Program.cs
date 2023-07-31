namespace Ex05GreaterThanNeighb
{
    internal class Program
    {
        /// <summary>
        /// Greater Than Neighbours
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        static bool GreaterThanNeighbours1(int[] arr, int position)
        {
            // Check if the element at the specified position has at least two neighbors
            if (position > 0 && position < arr.Length - 1)
            {
                // Compare the element at the specified position with its left and right neighbors
                int left = arr[position - 1];
                int current = arr[position];
                int right = arr[position + 1];

                return current > left && current > right;
            }

            // For the first and last position, compare with the single neighbor
            if (position == 0 && arr.Length > 1)
            {
                int current = arr[position];
                int right = arr[position + 1];
                return current > right;
            }

            if (position == arr.Length - 1 && arr.Length > 1)
            {
                int current = arr[position];
                int left = arr[position - 1];
                return current > left;
            }

            // If the position is out of bounds or the array has only one element, return false
            return false;
        }

        static bool GreaterThanNeighbours(int[] arr, int position)
        {
            if (arr.Length <= 2 || position < 0 || position >= arr.Length)
            {
                // The element at the specified position has less than two neighbors, so it cannot be greater than both
                return false;
            }

            // Compare the element at the specified position with its left and right neighbors
            int left = arr[position - 1];
            int current = arr[position];
            int right = arr[position + 1];

            return current > left && current > right;
        }

        static void TestGreaterThanNeighbours(int[] array, int position)
        {
            bool result = GreaterThanNeighbours(array, position);
            Console.WriteLine($"For the array: [{string.Join(", ", array)}], element at position {position} is greater than its two neighbors: {result}");
        }

        static void Main(string[] args)
        {
            #region Task 05
            /* Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors. Test whether the method works correctly.
            Guide: Just perform a check. The elements of the first and the last position in the array will be compared only with their left and right neighbor. 
            Test examples like GreaterThanNeighbours(new int[]{1,3,2}, 1) --> true and GreaterThanNeighbours(new int[]{1}, 0) --> true */
            #endregion

            int[] array = { 1, 3, 2 };
            int position = 1;
            bool result = GreaterThanNeighbours(array, position);
            Console.WriteLine($"Element at position {position} is greater than its two neighbors: {result}");


            // Test examples
            int[] array1 = { 1, 3, 2 };
            int position1 = 1;
            int[] array2 = { 1 };
            int position2 = 0;
            // Test the GreaterThanNeighbours method with different examples
            TestGreaterThanNeighbours(array1, position1);
            TestGreaterThanNeighbours(array2, position2);


            Console.WriteLine("\nSolution 2");
            Console.WriteLine($"For the array: [{string.Join(", ", array1)}], element at position {position1} is greater than its two neighbors: {GreaterThanNeighbours1(array1, position1)}");
            Console.WriteLine($"For the array: [{string.Join(", ", array2)}], element at position {position2} is greater than its two neighbors: {GreaterThanNeighbours1(array2, position2)}");
        }
    }
}