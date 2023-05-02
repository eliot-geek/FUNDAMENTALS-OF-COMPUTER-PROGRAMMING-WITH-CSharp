using System;

namespace Ex12SquareMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 12
            /* Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. The size of the 
            matrices will be read from the console. See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion: 
            
            Guide: a), b), c) Think about appropriate ways for iterating through the matrices with two nested loops.
            d) We can start from (0, 0) and go down N times. Therefore, go to the right N-1 times, after that up N-1 times, after that left N-2 times, 
            after that down N-2 times and etc. At each iteration we place the next number in a sequence 1, 2, 3, …, N in the cell, which we are leaving.  */
            #endregion


            #region First Square Matrix

            // 1   5   9  13            --> --> -->     Filled horizontally 
            // 2   6  10  14
            // 3   7  11  15
            // 4   8  12  16                           

            Console.Write("A) First matrix\nEnter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            // Fill the matrix with values
            int value = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = value++;
                }
            }
            // Print the matrix to the console
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();



            Console.WriteLine("\nA) First matrix");
            Console.Write("Enter height : ");
            int height = Int32.Parse(Console.ReadLine());
            Console.Write("Enter width : ");
            int width = Int32.Parse(Console.ReadLine());

            int a = 0;
            for (int i = 1; i <= height; i++)
            {
                Console.Write("{0, 4}", i);
                a += i;
                for (int j = 1; j < width; j++)
                {
                    a += height;
                    Console.Write("{0, 4}", a);
                }
                a = 0;
                Console.WriteLine();
            }
            Console.ReadKey();



            #endregion


            #region Second Square Matrix

            
            // 1   8   9  16
            // 2   7  10  15
            // 3   6  11  14
            // 4   5  12  13

            Console.WriteLine("\nB)Second matrix.");
            // Read size of the matrix from the console
            Console.Write("Enter size of matrix: ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix2 = new int[size, size];        // Create a new two-dimensional integer array with the given size
            int number = 1;                              // Initialize a counter variable to keep track of the current number to fill the matrix

            // Loop through the columns of the matrix
            for (int col = 0; col < size; col++)
            {
                // If the column index is even
                if (col % 2 == 0)
                {
                    // Loop through the rows of the matrix from top to bottom
                    for (int row = 0; row < size; row++)
                    {
                        matrix2[row, col] = number++;   // Assign the current number to the current element of the matrix
                    }
                }
                // If the column index is odd
                else
                {
                    // Loop through the rows of the matrix from bottom to top
                    for (int row = size - 1; row >= 0; row--)
                    {
                        matrix2[row, col] = number++;   // Assign the current number to the current element of the matrix
                    }
                }
            }
            // Print matrix to console
            // Loop through the rows of the matrix
            for (int row = 0; row < size; row++)
            {
                // Loop through the columns of the matrix
                for (int col = 0; col < size; col++)
                {
                    Console.Write("{0,4}", matrix2[row, col]);  // Print the current element of the matrix with a width of 4 characters
                }
                Console.WriteLine();    // Move to the next line of the console output
            }
            Console.ReadKey();



            Console.WriteLine("\nB)Second matrix.");
            // Prompt the user to enter the size of the matrix
            Console.Write("Enter matrix size : ");
            // Read the size of the matrix from the console, and parse it as an integer
            n = Int32.Parse(Console.ReadLine());
            // Create a new two-dimensional integer array with the given size
            int[,] arr = new int[n, n];

            // Initialize the top-left element of the matrix to 1
            arr[0, 0] = 1;
            // Loop through the columns of the matrix
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                // If the column index is odd
                if (i % 2 == 1)
                {
                    // Calculate the value of the current element based on the value of the previous element and the size of the matrix
                    arr[0, i] = arr[0, i - 1] + n * 2 - 1;
                }
                else
                {
                    // Calculate the value of the current element based on the value of the previous element
                    arr[0, i] = arr[0, i - 1] + 1;
                }
            }
            // Loop through the rows of the matrix, starting from the second row
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                // Loop through the columns of the matrix
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // If the column index is odd
                    if (j % 2 == 1)
                    {
                        // Calculate the value of the current element based on the value of the element above it
                        arr[i, j] = arr[i - 1, j] - 1;
                    }
                    else
                    {
                        // Calculate the value of the current element based on the value of the element above it
                        arr[i, j] = arr[i - 1, j] + 1;
                    }
                }
            }

            // Loop through the rows of the matrix
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Loop through the columns of the matrix
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Print the current element of the matrix with a width of 4 characters
                    Console.Write("{0, 4}", arr[i, j]);
                }
                // Move to the next line of the console output
                Console.WriteLine();
            }
            // Wait for the user to press a key before exiting the program
            Console.ReadLine();

            #endregion


            #region Third Square Matrix
            

            // 7  11  14  16
            // 4   8  12  15
            // 2   5   9  13
            // 1   3   6  10

            Console.WriteLine("\nC)Third matrix.");
            Console.Write("Enter the array's size : ");
            int length = Int32.Parse(Console.ReadLine());
            int[,] array = new int[length, length];             // Create a new two-dimensional integer array with the given length

            array[length - 1, 0] = 1;       // Set the bottom left value of the array to 1
            int counter = 1;                // Initialize a counter variable to 1

            // Loop through each row in the array, starting from the second-to-last row and moving upwards
            for (int row = length - 2; row >= 0; row--)
            {
                // Calculate the value to place in the current row's first column
                array[row, 0] = array[row + 1, 0] + counter;
                // Initialize a new variable to keep track of the row to insert values into
                int newRow = row;

                // Loop through each diagonal in the current row, starting from the second diagonal
                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    // Calculate the value to place in the current diagonal's cell
                    array[newRow + 1, diagonal] = array[newRow, diagonal - 1] + 1;
                    newRow++;   // Move down to the next row
                }
                counter++;      // Increment the counter variable
            }

            // Set the top right value of the array to the square of the length of the array
            array[0, length - 1] = length * length;

            // Initialize variables to keep track of the current position and the previous position
            int diagonallength = 2;
            int posX = 1;
            int posY = length - 1;
            int prevX = 0;
            int prevY = length - 1;

            // Loop through each diagonal in the array, starting from the second diagonal
            for (int i = 1; i <= counter - 1; i++)
            {
                // Loop through each cell in the current diagonal
                for (int j = 1; j <= diagonallength; j++)
                {
                    // Calculate the value to place in the current cell
                    array[posX, posY] = array[prevX, prevY] - 1;

                    // Update the previous position variables
                    prevX = posX;
                    prevY = posY;

                    // Move to the next cell in the diagonal
                    posX--;
                    posY--;
                }
                // Increment the diagonal length variable
                diagonallength++;

                // Move to the next starting position for the next diagonal
                posX = i + 1;
                posY = length - 1;
            }

            // Print the array to the console
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", array[i, j]);
                }
                Console.WriteLine();        // Wait for user to press a key before closing the console
            }
            Console.ReadKey();

            #endregion


            #region Fourth Square Matrix

            // 1  12  11  10
            // 2  13  16   9
            // 3  14  15   8
            // 4   5   6   7

            Console.WriteLine("\nD)Fourth matrix.");                
            Console.Write("Enter the array's size : ");             // Prompt the user to enter the size of the array
            int Length = Int32.Parse(Console.ReadLine());           // Parse the user input as an integer and assign it to the variable Length

            int[,] myArray = new int[Length, Length];                       // Initialize a 2D integer array with dimensions Length x Length
            int numConcentricSquares = (int)Math.Ceiling((Length) / 2.0);   // Determine the number of concentric squares based on the size of the array
                                                                            // A concentric square is a set of squares that are centered at a common point and have the same orientation.
                                                                            //  Math.Ceiling function to round up the result to the nearest integer. 
            
            int sideLen = Length;           // Initialize the side length of the square to be the length of the array
            int currNum = 0;                // Initialize the current number to be 0

            // Loop through each concentric square
            for (int i = 0; i < numConcentricSquares; i++)
            {
                // Populate the top row of the square with incrementing numbers
                for (int j = 0; j < sideLen; j++)
                {
                    myArray[i + j, i] = ++currNum;
                }
                // Populate the rightmost column of the square with incrementing numbers
                for (int j = 1; j < sideLen - 1; j++)
                {
                    myArray[Length - 1 - i, i + j] = ++currNum;
                }
                // Populate the bottom row of the square with incrementing numbers
                for (int j = sideLen - 1; j > 0; j--)
                {
                    myArray[i + j, Length - 1 - i] = ++currNum;
                }
                // Populate the leftmost column of the square with incrementing numbers
                for (int j = sideLen - 1; j > 0; j--)
                {
                    myArray[i, i + j] = ++currNum;
                }
                // Decrement the side length of the square by 2
                sideLen -= 2;
            }

            // Loop through each element in the array and print it to the console in a formatted manner
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", myArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();



            Console.WriteLine("\nD)Fourth matrix.");
            // Read size of the matrix from the console
            Console.Write("Enter size of matrix: ");
            size = int.Parse(Console.ReadLine());
            // Create matrix with given size
            matrix = new int[size, size];

            // Fill matrix with numbers
            int roww = 0;
            int coll = 0;
            counter = 1; 
            int num = size;

            while (counter <= size * size)
            {
                // Move down
                for (int i = 0; i < num; i++)
                {
                    matrix[roww++, coll] = counter++;
                }
                roww--;
                coll++;

                // Move right
                for (int i = 0; i < num - 1; i++)
                {
                    matrix[roww, coll++] = counter++;
                }
                coll--;
                roww--;

                // Move up
                for (int i = 0; i < num - 1; i++)
                {
                    matrix[roww--, coll] = counter++;
                }
                roww++;
                coll--;

                // Move left
                for (int i = 0; i < num - 2; i++)
                {
                    matrix[roww, coll--] = counter++;
                }
                coll++;
                roww++;
                num -= 2;
            }

            // Print matrix to console
            for (roww = 0; roww < size; roww++)
            {
                for (coll = 0; coll < size; coll++)
                {
                    Console.Write("{0,4}", matrix[roww, coll]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            #endregion
        }
    }
}
