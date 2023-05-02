using System;

namespace Ex01ArrayOf20Integersby5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            // Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with 
            // a value equals to the index of the element multiplied by 5. Print the elements to the console.
            // Guide : Use an int[] array and a for-loop 
            #endregion

            Console.WriteLine("An array of 20 elements multiplied by 5.");
            // Create an array of 20 integers
            int[] array = new int[20];
            // Use a for loop to iterate over each element in the array
            for (int i = 0; i < array.Length; i++)
            {
                // Set the value of the current element to the index multiplied by 5
                array[i] = i * 5;
                // Print the current element to the console
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
