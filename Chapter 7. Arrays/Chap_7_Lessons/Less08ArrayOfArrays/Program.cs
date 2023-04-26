using System;

namespace Less08ArrayOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays of Arrays - In C# we can have arrays of arrays, which we call jagged arrays.
            // Jagged arrays are arrays of arrays, or arrays in which each row contains an array of its own, and that array can have length different than those in the other rows.

            // Declaration and Allocation an Array of Arrays
            int[][] jaggedArray;
            jaggedArray = new int[2][];     // Create an instance of the jagged array with two rows
            jaggedArray[0] = new int[5];    // Initialize the first row of the jagged array with an array of length 5
            jaggedArray[1] = new int[3];    // Initialize the second row of the jagged array with an array of length 3

            // Here is how we declare, allocate and initialize an array of arrays (a jagged array whose elements are arrays of integer values) 
            // Declare and initialize a jagged array of integers with three rows
            int[][] myJaggedArray =
            {
                new int[] {5, 7, 2},        // Initialize the first row of the jagged array with an array containing three integers
                new int[] {10, 20, 40 },    // Initialize the second row of the jagged array with an array containing three integers
                new int[] {3, 25 }          // Initialize the third row of the jagged array with an array containing two integers
            };

            // Memory Allocation
            // A jagged array does not directly contain any arrays, but rather has elements pointing to them. (picture)

            // Initialization and Access to the Elements
            // We will access the element with index 3 of the array stored at index 0 in the myJaggedArray
            // myJaggedArray[0][2] = 45 assigns the value 45 to the element with index 2 in the first row of myJaggedArray, which originally held the value 2.
            myJaggedArray[0][2] = 45;
            Console.WriteLine(myJaggedArray[0][2]);

            // The elements of the jagged array can be one-dimensional and multi-dimensional arrays.
            // Here is an example for jagged array of two-dimensional arrays:
            int[][,] jaggedOfMulti = new int[2][,];                         // Declare a jagged array of multidimensional integer arrays with two rows
            jaggedOfMulti[0] = new int[,] { { 5, 15 }, { 125, 206 } };      // Initialize the first row of the jagged array with a 2D integer array containing two rows and two columns
            jaggedOfMulti[1] = new int[,] { { 3, 4, 5 }, { 7, 8, 9 } };     // Initialize the second row of the jagged array with a 2D integer array containing two rows and three columns

        }
    }
}
