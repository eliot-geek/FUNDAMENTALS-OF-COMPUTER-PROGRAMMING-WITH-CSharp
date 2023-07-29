namespace Less08Sorting
{
    internal class Program
    {
        /// <summary>
        /// "selection sort" algorithm
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static int[] Sort(params int[] numbers)
        {
            // The sorting logic
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Loop operating over the unsorted part of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Swapping the values
                    if (numbers[i] > numbers[j])
                    {
                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            } // End of the sorting logic
            return numbers;
        }

        /// <summary>
        /// Prints Numbers
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}", numbers[i]);
                if (i < (numbers.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }

        static void Main(string[] args)
        {
            // Sorting
            int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);
            PrintNumbers(numbers);
        }
    }
}