using System;

namespace Ex03CompareCharLexicograp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 3
            // Write a program, which compares two arrays of type char lexicographically (character by character)
            // and checks, which one is first in the lexicographical order.
            // Guide: In lexicographic order the elements are compared one by one starting from the very left. 
            // If the elements are not the same, the array, whose element is smaller (comes earlier in the alphabet), comes first. 
            // If the elements are equal, the next character is compared. If the end of one of the arrays is reached, without finding 
            // different elements, the shorter array is the smaller (comes earlier lexicographically). 
            // If all elements are equal, the arrays are equal.
            #endregion


            Console.WriteLine("Write a program, which compares two arrays of type char lexicographically (character by character)\n");
            // Initialize a boolean variable that will be used to check if the two arrays are equal
            bool Equal = true;
            // Initialize the first array with four elements
            char[] firstArr = new char[] { 'a', 'b', 'c', 'd' };
            // Initialize the second array with four elements
            char[] secondArr = new char[] { 'a', 'b', 'c', 'd' };

            // Compare the lengths of the two arrays
            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine("The second array is lexicographicaly first.");
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("The first array is lexicographicaly first.");
            }
            else
            {
                // Loop through each element in the arrays and compare them
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("The first array is lexicographicaly first.");
                        // If the first array element is smaller, set Equal to false and break the loop
                        Equal = false;
                        break;
                    }
                    if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine("The second array is lexicographicaly first.");
                        // If the second array element is smaller, set Equal to false and break the loop
                        Equal = false;
                        break;
                    }
                }
                // If all elements are equal, the arrays are equal
                if (Equal)
                {
                    Console.WriteLine("The arrays are lexicographicaly equal.");
                }
            }
            Console.ReadLine();





            Console.WriteLine("\nSolution 2");
            Console.Write("Enter the first array (type char) : ");
            // Read the first array from the console
            char[] array1 = Console.ReadLine().ToCharArray(); 
            Console.Write("Enter the second array (type char) : ");
            // Read the second array from the console
            char[] array2 = Console.ReadLine().ToCharArray();
            // Find the length of the shorter array
            int minLength = Math.Min(array1.Length, array2.Length);

            // Loop through each element of the shorter array
            for (int i = 0; i < minLength; i++) 
            {
                // Compare the characters at the current position in both arrays
                if (array1[i] < array2[i]) 
                {
                    Console.WriteLine("The 1st array is first in lexicographic order.");
                    return; // Exit the program
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine("The 2nd array is first in lexicographic order.");
                    return; // Exit the program
                }
            }

            // Check if the first array is shorter than the second
            if (array1.Length < array2.Length) 
            {
                Console.WriteLine("The first array is first in lexicographic order.");
            }
            // Check if the second array is shorter than the first
            else if (array1.Length > array2.Length) 
            {
                Console.WriteLine("The second array is first in lexicographic order.");
            }
            // If the lengths of the arrays are equal, they are equal
            else
            {
                Console.WriteLine("The arrays are equal.");
            }
            Console.ReadLine();
        }
    }
}
