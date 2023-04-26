using System;

namespace Less04PrintArrayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing an Array to the Console
            string[] array = { "one", "two", "three", "four" };
            Console.WriteLine(array); // Prints just the type
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
            Console.ReadLine();


            // Iteration through Elements of an Array
            // Iteration with a For Loop
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("\nOutput { 1, 2, 3, 4, 5 } : ");
            for (int i = 0; i < myArray.Length; i++)
            {
                // Doubling the number
                myArray[i] = 2 * myArray[i];
                // Print the number
                Console.Write(myArray[i] + " ");
            }
            Console.ReadLine();


            // We can iterate through some of the elements of the array, not through all of them
            myArray = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("\nOutput { 1, 2, 3, 4, 5 } : ");
            // we are iterating through all elements at even positions
            for (int i = 0; i < myArray.Length; i += 2)
            {
                // we square their values
                myArray[i] = myArray[i] * myArray[i];
                Console.Write(myArray[i] + " ");
            }
            Console.ReadLine();


            // Sometimes we want to iterate through the array in a reverse order
            myArray = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("\nReverse Output { 1, 2, 3, 4, 5 } : ");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.ReadLine();


            // Iteration with "foreach" Loop - One of the most used constructs for iterating through elements of an array is foreach.
            // The main difference is that the iteration is made always through all elements – from the start to the end.
            // We cannot access the current index, we are just iterating through the collection in a way, defined by the collection itself
            // From the first element to the last one.
            // The loop variable in foreach-loops is read-only so we cannot modify the current loop item from the loop body.

            // Iteration with "foreach" Loop – Example
            Console.WriteLine("\n");
            string[] capitals = { "Sofia", "Washington", "London", "Paris" };
            foreach (string capital in capitals)
            {
                Console.WriteLine(capital);
            }
            Console.ReadLine();
        }
    }
}
