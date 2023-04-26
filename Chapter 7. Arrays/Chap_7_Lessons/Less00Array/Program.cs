using System;
using System.Xml.Linq;

namespace Less00Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays - Arrays are vital for most programming languages. They are collections of variables, which we call elements
            // All elements of a given array are of the same type, no matter whether they are primitive or reference types.
            // Arrays can be in different dimensions, but the most used are the one-dimensional and the two-dimensional arrays.
            // One-dimensional arrays are also called vectors and two-dimensional are also known as matrices.

            // Declaration and Allocation of Memory for Arrays
            // Declaring an Array
            // int[] myArray; the memory for elements of the array is not allocated (picture) 
            // Creation of an Array – the Operator "new"
            // int[] myArray = new int[6]; we allocate an array with length of 6 elements of type int.
            // In C#, the elements of an array are always stored in the dynamic memory (called also heap).
            // Array Initialization and Default Values
            // int[] myArray = { 1, 2, 3, 4, 5, 6 }; we create and initialize the elements of the array at the time of the declaration.
            // Declaration and Initialization of an Array – Example
            // string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday" };
            // Boundaries of an Array
            // The enumeration of the elements starts from 0. The first element has the index 0, the second – 1, etc. In an array of N elements, the last element has the index N-1.
            // Access to the Elements of an Array - We access the array elements directly using their indices.
            // We allocate an array of numbers and then we change some of them
            // int[] myArray = new int[6];
            // myArray[1] = 1; 
            // myArray[5] = 5;


            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]); 
            }
            Console.ReadLine();


            // Going Out of Bounds of the Array
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(myArray[6]); //  System.IndexOutOfRangeException: Index was outside the bounds of the array.
        }
    }
}
