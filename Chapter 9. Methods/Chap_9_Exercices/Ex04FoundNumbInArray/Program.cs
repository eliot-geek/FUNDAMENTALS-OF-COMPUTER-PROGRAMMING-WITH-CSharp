namespace Ex04FoundNumbInArray
{
    internal class Program
    {
        /// <summary>
        /// Method that finds how many times certain number can be found in a given array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        static int CountOccurrences(int[] arr, int number)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num == number)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Method that finds how many times certain number can be found in a given array
        /// </summary>
        /// <param name="number"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int CountNumber(int number, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++) 
                if (number == arr[i]) 
                    counter++;

            return counter;
        }

        /// <summary>
        /// Test
        /// </summary>
        /// <param name="array"></param>
        /// <param name="number"></param>
        static void TestCountOccurrences(int[] array, int number)
        {
            int occurrences = CountOccurrences(array, number);
            Console.WriteLine($"The number {number} occurs {occurrences} times in the array.");
        }

        static void Main(string[] args)
        {
            #region Task 04
            /* Write a method that finds how many times certain number can be found in a given array. Write a program to test that the method works correctly.
            Guide: The method must take as parameter an array of integer numbers (int[]) and the number that has to be counted (int). 
            Test it with few examples like this: CountOccurences(new int[]{3,2,2,5,1,-8,7,2}, 2) --> 3. */
            #endregion

            int[] numbers = { 3, 2, 2, 5, 1, -8, 7, 2 };
            int numberToCount = 2;
            int occurrences = CountOccurrences(numbers, numberToCount);
            Console.WriteLine($"The number {numberToCount} occurs {occurrences} times in the array.");

            // Test cases
            int[] array1 = { 3, 2, 2, 5, 1, -8, 7, 2 };
            int number1 = 2;
            int[] array2 = { 1, 1, 1, 1, 1 };
            int number2 = 1;
            int[] array3 = { 2, 4, 6, 8, 10 };
            int number3 = 3;

            // Test the CountOccurrences method with different examples
            TestCountOccurrences(array1, number1);
            TestCountOccurrences(array2, number2);
            TestCountOccurrences(array3, number3);
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
            Console.Write("Enter number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} was found {1} times.", number, CountNumber(number, arr));
        }
    }
}