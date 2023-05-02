using System;

namespace Ex11SumOfCertainNumberS
{
    class Program
    {
        /// <summary>
        /// FindSequenceWithSum
        /// </summary>
        /// <param name="array"></param>
        /// <param name="Ss"></param>
        /// <returns></returns>
        static int[] FindSequenceWithSum(int[] array, int Ss)
        {
            int[] resul = new int[0];
            // Loop through the array starting from each element
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;

                // Sum elements from the starting index to the right
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];

                    // If sum equals S, store the sequence in the result array and return it
                    if (sum == Ss)
                    {
                        resul = new int[j - i + 1];
                        Array.Copy(array, i, resul, 0, j - i + 1);
                        return resul;
                    }

                    // If sum is greater than S, break out of the inner loop and move to the next starting index
                    else if (sum > Ss)
                    {
                        break;
                    }
                }
            }
            // Return the result array
            return resul;
        }

        /// <summary>
        /// FindSequenceWithSum2 Faster Algorithm
        /// </summary>
        /// <param name="arr2"></param>
        /// <param name="Summa"></param>
        static void FindSequenceWithSum2(int[] arr2, int Summa)
        {
            int summ = 0;
            int start = 0;

            // Loop through the elements in the array
            for (int i = 0; i < arr2.Length; i++)
            {
                // Add the current element to the sum
                summ += arr2[i];

                // If the current sum is greater than Summa, remove elements from the left
                while (summ > Summa)
                {
                    summ -= arr2[start];
                    start++;
                }

                // If the current sum is equal to Summa, print the sequence and exit the method
                if (summ == Summa)
                {
                    for (int j = start; j <= i; j++)
                    {
                        Console.Write(arr2[j] + " ");
                    }
                    Console.WriteLine("= " + Summa);
                    return;
                }
            }
            // If no sequence is found, print a message to the console
            Console.WriteLine("No sequence found with sum of " + Summa);
        }

        static void Main(string[] args)
        {
            #region Task 11
            /* Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S. 
            Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}. 
            Guide: This exercise can be solved with two nested loops. The first loop assigns a starting index. The second loop sums the elements from the starting index to the 
            right until this partial sum reaches or is greater than S. If the sum is equal to S, we will remember the starting index (from the first loop) and the ending 
            index (from the second loop).

            If all numbers are positive, there is a much faster algorithm. We sum all numbers from left to the right, starting from zero. If the current sum becomes greater 
            than S during the summation, we remove the leftmost number in the sequence and we subtract it from the sum. If the current sum is still greater than S, we remove 
            the next leftmost number and do that until the current sum becomes smaller than S. When the sum becomes smaller than S we add the next number on right. 
            If we find a sum equal to S, we print the sum and the sequence to the console. So this solution uses just with one scan through the elements in the array.  */
            #endregion


            #region Call Method

            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int Ss = 11;
            // Call the FindSequenceWithSum method and print the result
            int[] resul = FindSequenceWithSum(array, Ss);
            Console.WriteLine(string.Join(", ", resul));
            Console.ReadKey();

            #endregion


            #region Method with faster Algorithm

            int[] arr2 = { 4, 3, 1, 4, 2, 5, 8 };
            int Summa = 11;
            // Call the method and print the result
            FindSequenceWithSum2(arr2, Summa);
            Console.ReadKey();

            #endregion


            #region Another Solution


            Console.WriteLine("\nAnother solution");
            int[] array1 = { 4, 3, 1, 4, 2, 5, 8 };
            int S = 11;

            for (int i = 0; i < array1.Length; i++)
            {
                int SumChecked = 0;
                for (int j = i; j < array1.Length; j++)
                {
                    SumChecked += array1[j];
                    if (SumChecked == S)
                    {
                        // Prints the result
                        Console.Write("{");
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write(array1[k]);
                            if (k < j)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine("}");
                    }
                }
            }
            Console.ReadLine();

            #endregion


            #region 1st way


            //// Read the array from the user
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //// Print the array using string interpolation and string.Join
            //Console.WriteLine($"[{string.Join(", ", a)}]");

            Console.WriteLine("\nWrite a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S.");
            int sum = 0;
            int start = 0;
            int end = 0;
            bool sumFound = false;
            Console.Write("Enter Sum : ");
            int s = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            // Loop over all possible starting indices
            for (int i = 0; i < length -1; i++)
            {
                sum = arr[i];
                // Loop over all elements from the starting index to the end of the array
                for (int j = i + 1; j < length; j++)
                {
                    sum += arr[j];       // Add the current element to the sum
                    // If the sum is exactly S, remember the starting and ending indices
                    if (sum == s)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                }
                if (sumFound)
                {
                    break;
                }
            }
            // Print the result
            if (sumFound)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write("{0},", arr[i]);
                }
            }
            else
            {
                Console.WriteLine("No sum found.");
            }
            Console.ReadLine();
            Console.ReadKey();
            #endregion

        }
    }
}
