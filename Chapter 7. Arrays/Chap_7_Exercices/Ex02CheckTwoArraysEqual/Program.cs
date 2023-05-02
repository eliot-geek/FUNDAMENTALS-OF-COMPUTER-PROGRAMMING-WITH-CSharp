using System;

namespace Ex02CheckTwoArraysEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            // Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal 
            // when they are of equal length and all of their elements, which have the same index, are equal).
            // Guide : Two arrays are equal if they have the same value for the length and the values for their elements. 
            // You can check for the second condition using a for-loop.
            #endregion


            Console.WriteLine("Write a program, which reads two arrays from the console and checks whether they are equal.");
            // Initialize a boolean variable Equal to true
            bool Equal = true;

            // Read the length of the first array from the console and create an array with that length.
            Console.Write("Enter the length of the first array: ");
            int firstLength = Int32.Parse(Console.ReadLine());
            int[] firstArray = new int[firstLength];
            // Use a for loop to read each element of the first array from the console.
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                firstArray[i] = Int32.Parse(Console.ReadLine());
            }

            // Read the length of the second array from the console and check if it has the same length as the first array.
            Console.Write("Enter the length of the second array: ");
            int secondLength = Int32.Parse(Console.ReadLine());
            if (firstLength != secondLength)
            {
                Console.WriteLine("The arrays have different lengths.");
            }
            else
            {
                // Create an array with the same length as the second array and read each element from the console
                int[] secondArray = new int[secondLength];
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write("Enter element {0} : ", i);
                    secondArray[i] = Int32.Parse(Console.ReadLine());
                }

                // Use a for loop to compare each element of the first array with the corresponding element of the second array
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("The arrays are differents.");
                        // Set the value of Equal to false if the arrays are different
                        Equal = false;
                        // Exit the loop if the arrays are different
                        break; 
                    }
                }

                if (Equal)
                {
                    Console.WriteLine("They are equals.");
                }
            }
            Console.ReadLine();




            Console.WriteLine("\nSolution 2");
            // Read the first array from the console.
            Console.Write("Enter the first array: ");
            int[] array1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // Array.ConvertAll() creates a new array of integers from the array of strings produced by the Split() method and the int.Parse() method.
                                                                                       // Split(' ') if the input string is "1 2 3", the resulting array of substrings would be ["1", "2", "3"].

            // Read the second array from the console.
            Console.Write("Enter the second array: ");
            int[] array2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Check if the two arrays are equal.
            bool areEqual = true;
            if (array1.Length != array2.Length)
            {
                areEqual = false;
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            // Print the result to the console.
            if (areEqual)
            {
                Console.WriteLine("The two arrays are equal.");
            }
            else
            {
                Console.WriteLine("The two arrays are not equal.");
            }
        }
    }
}
