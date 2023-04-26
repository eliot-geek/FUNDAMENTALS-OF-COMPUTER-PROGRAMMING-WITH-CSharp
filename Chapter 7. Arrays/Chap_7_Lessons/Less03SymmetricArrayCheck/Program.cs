using System;

namespace Less03SymmetricArrayCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for Symmetric Array – Example
            // An array is symmetric if the first and the last elements are equal and at the same time
            // the second element and the last but one are equal as well and so on.
            // 1221 12321 123321

            Console.Write("Enter a positive integer : ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the values of the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the {i} element of the array : ");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[n - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine("Is symmetric ? {0}", symmetric);
            Console.ReadLine();



            // Is a symmetric array because it is a square matrix (i.e. the number of rows equals the number of columns)
            // and each element at position (i,j) is equal to the element at position (j,i) for all i and j.
            // If we consider the first row and third column of the array, we see that arr[0,2] = 3 and arr[2,0] = 3, which means that the element
            // at position (0,2) is equal to the element at position (2,0). Similarly, we can check all other pairs of elements to confirm that
            // the array is symmetric.

            Console.WriteLine("\nSolution 2");
            int[,] arr = {{1, 2, 3},
                          {2, 4, 5},
                          {3, 5, 6}};

            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);

            bool isSymmetric = true;

            // Check if the number of rows and columns are equal
            if (rows != columns)
            {
                isSymmetric = false;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Check if the element at (i,j) is equal to the element at (j,i)
                    if (arr[i, j] != arr[j, i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }

                if (!isSymmetric)
                {
                    break;
                }
            }

            if (isSymmetric)
            {
                Console.WriteLine("The array is symmetric.");
            }
            else
            {
                Console.WriteLine("The array is not symmetric.");
            }
        }
    }
}
