using System;

namespace Ex10MostFrequentlyOccurr
{
    class Program
    {
        /// <summary>
        /// FindMostFrequentElement
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int FindMostFrequentElement(int[] arr)
        {
            Array.Sort(arr); // Sort the array in ascending order

            int maxCount = 1;
            int mostFrequent = arr[0];
            int currentCount = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1]) // The current element is equal to the previous element
                {
                    currentCount++;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mostFrequent = arr[i];
                    }
                }
                else // The current element is not equal to the previous element
                {
                    currentCount = 1;
                }
            }
            return mostFrequent;
        }

        /// <summary>
        /// CountOccurrences
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static int CountOccurrences(int[] arr, int value)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            #region Task 10
            /* Write a program, which finds the most frequently occurring element in an array. 
            Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).
            Guide : This exercise can be solved in a couple of ways. One of them is the following: get the first number and check how many 
            times it is repeated in the array and store this number in a variable. After a repeated number is found we change its value to 
            int.MinValue. Then pass to the next number and do the same with it. The current number is remembered if its occurrences are maximal. 
            As you may guess, when a number equal to int.MinValue is found (already processed number) we should skip it.
            Another solution is to sort the numbers in ascending order and then the elements with same value will be placed next to each other. 
            So, basically we then find the longest sequence of neighbor equal elements. */
            #endregion


            #region 1st way

            
            // Define the array directly in the code
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int maxCount = 0;               // variable to store the maximum count of a number
            int maxValue = array[0];          // variable to store the value of the number with the maximum count

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;          // variable to count the number of occurrences of the current number
                int value = array[i];     // variable to store the current number

                // loop through the array to count the number of occurrences of the current number
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == value)
                    {
                        count++;
                    }
                }

                // check if the current number has more occurrences than the previous maximum
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = value;
                }
            }
            Console.WriteLine("{0} ({1} times)", maxValue, maxCount);
            Console.WriteLine("{0} was found {1} times.", maxValue, maxCount);

            Console.ReadKey();
            #endregion


            #region Call Method way

            int[] ar = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int mostFrequent = FindMostFrequentElement(ar);
            Console.WriteLine("{0} ({1} times)", mostFrequent, CountOccurrences(ar, mostFrequent));
            Console.ReadKey();

            #endregion


            #region 2nd way


            Console.WriteLine("Write a program, which finds the most frequently occurring element in an array");
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());

            int counter = 0;
            int tempCounter = 1;
            int foundNumber = 0;

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = arr[i];
                }
            }
            Console.WriteLine("{0} was found {1} times.", foundNumber, counter);
            Console.ReadLine();
            #endregion

        }
    }
}
