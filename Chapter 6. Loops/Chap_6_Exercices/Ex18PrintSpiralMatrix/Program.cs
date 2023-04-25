using System;

namespace Ex18PrintSpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 18
            // Write a program that for a given number n, outputs a matrix in the form of a spiral:
            // n=4  1  2  3  4
            //      12 13 14 5
            //      11 16 15 6
            //      10 9  8  7
            // Guide: You should use a two-dimensional array (matrix). Search the Internet or see the chapter "Arrays".
            // The algorithm of filling a spiral matrix in not straightforward and may require a bit of thinking.
            // You might find helpful the “Spiral Matrix” problem from chapter “Sample Programming Exam – Topic #3”.
            #endregion

            Console.Write("Enter number n : ");
            int n = Int32.Parse(Console.ReadLine());
            // initialize a 2D array of size n x n to store the spiral matrix
            int[,] matrix = new int[n, n];
            // initialize variables to keep track of the current row and column indices
            int row = 0;
            int col = 0;
            // initialize the direction of movement to be right (0), then clockwise (1, 2, 3)
            int direction = 0;

            // loop through each cell in the matrix
            for (int i = 1; i <= n * n; i++)
            {
                // check the current direction of movement
                switch (direction)
                {
                    case 0:             // moving right
                        if (col > n - 1 || matrix[row, col] != 0)   // check if the next cell is out of bounds or has already been filled
                        {
                            direction = 1;   // change direction to down
                            col--;           // adjust the column index to stay within bounds
                            row++;           // adjust the row index to move down one row
                        }
                        break;
                    case 1:             // moving down
                        if (row > n - 1 || matrix[row, col] != 0)   // check if the next cell is out of bounds or has already been filled
                        {
                            direction = 2;   // change direction to left
                            row--;           // adjust the row index to stay within bounds
                            col--;           // adjust the column index to move left one column
                        }
                        break;
                    case 2:             // moving left
                        if (col < 0 || matrix[row, col] != 0)   // check if the next cell is out of bounds or has already been filled
                        {
                            direction = 3;   // change direction to up
                            col++;           // adjust the column index to stay within bounds
                            row--;           // adjust the row index to move up one row
                        }
                        break;
                    case 3:             // moving up
                        if (row < 0 || matrix[row, col] != 0)   // check if the next cell is out of bounds or has already been filled
                        {
                            direction = 0;   // change direction to right
                            row++;           // adjust the row index to stay within bounds
                            col++;           // adjust the column index to move right one column
                        }
                        break;
                }

                matrix[row, col] = i;       // fill the current cell in the matrix with the current value of the counter

                switch (direction)          // check the current direction of movement
                {
                    case 0:               // moving right
                        col++;            // increment the column index to move right one column
                        break;
                    case 1:               // moving down
                        row++;            // increment the row index to move down one row
                        break;
                    case 2:               // moving left
                        col--;            // decrement the column index to move left one column
                        break;
                    case 3:               // moving up
                        row--;            // decrement the row index to move up one row
                        break;
                }
            }

            for (int i = 0; i < n; i++)      // loop through the rows of the matrix
            {
                for (int j = 0; j < n; j++)  // loop through the columns of the matrix
                {
                    if (matrix[i, j] < 10)   // if the current cell has a value less than 10
                    {
                        Console.Write("{0}  ", matrix[i, j]);   // print the value with two spaces after it
                    }
                    else                     // otherwise, if the current cell has a value greater than or equal to 10
                    {
                        Console.Write("{0} ", matrix[i, j]);    // print the value with one space after it
                    }
                }
                Console.WriteLine();        // print a new line to move to the next row of the matrix
            }
            Console.ReadLine();



            Console.WriteLine("\nSolution 2");
            int N = 4;
            int[,] matrix2D = new int[n, n];
            int count = 1;
            int rows = 0, cols = 0;

            // fill the matrix in a spiral pattern
            while (count <= N * N)
            {
                // fill right
                while (cols < N && matrix2D[rows, cols] == 0)
                {
                    matrix2D[rows, cols++] = count++;
                }
                cols--;
                rows++;

                // fill down
                while (rows < N && matrix2D[rows, cols] == 0)
                {
                    matrix2D[rows++, cols] = count++;
                }
                rows--;
                cols--;

                // fill left
                while (cols >= 0 && matrix2D[rows, cols] == 0)
                {
                    matrix2D[rows, cols--] = count++;
                }
                cols++;
                rows--;

                // fill up
                while (rows >= 0 && matrix2D[rows, cols] == 0)
                {
                    matrix2D[rows--, cols] = count++;
                }
                rows++;
                cols++;
            }

            // print the matrix
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,3}", matrix2D[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
