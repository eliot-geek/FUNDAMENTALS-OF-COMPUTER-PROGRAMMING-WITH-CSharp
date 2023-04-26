using System;

namespace Less09PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pascal’s Triangle – Example

            // Declare and initialize the height of the triangle
            const int Height = 12;

            /*The line long[][] triangle = new long[Height + 1][]; declares a 2D jagged array triangle with a height of Height+1 rows, where each row is an 
             * array of long values. The reason why the height is set to Height+1 is that the array is zero-indexed, and the Height variable specifies the 
             * number of rows we want to create, so we need to add an additional row to accommodate for the zero-indexing. The array is initially 
             * declared without columns, because the number of columns in each row will be different.*/
            
            // Declare a jagged array to store the values of the triangle
            long[][] triangle = new long[Height + 1][]; //  the array is zero-indexed

            /* Since the triangle array is jagged, meaning each row can have a different number of elements, we need to initialize each row separately.
            The loop iterates over each row of the triangle array, and for each row row, it initializes the row to an array of row+1 long values. 
            For example, the first row (at index 0) will be initialized to an array of 1 element, the second row (at index 1) will be initialized to an array 
            of 2 elements, the third row (at index 2) will be initialized to an array of 3 elements, and so on, up to the Height-th row. This ensures that 
            each row of the triangle array has enough space to store the Pascal's triangle values that will be calculated in the subsequent code.*/

            // Allocate memory for the jagged array in a triangle form
            for (int row = 0; row < Height; row++)
            {
                triangle[row] = new long[row + 1];
            }
            
            // In Pascal's triangle, the first and last elements of each row are always 1.
            // By setting triangle[0][0] = 1, we ensure that the first element of the first row is 1.
            triangle[0][0] = 1;

            // Calculate the values of the Pascal's triangle
            for (int row = 0; row < Height - 1; row++)  // The first for loop is iterating through each row of the triangle except the last one, which will be calculated in the inner loop.
            {
                for (int col = 0; col <= row; col++)
                {
                    // The value of the current cell in the triangle is updated by adding the values of the two cells above it from the previous row.
                    // The updated value is added to the cell to the left in the current row.
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            // Print the Pascal's triangle
            for (int row = 0; row < Height; row++)
            {
                /* Console.Write( outputs a string to the console without adding a newline character at the end.
                "".PadLeft((Height - row) * 2) creates an empty string of length (Height - row) * 2, which is filled with spaces because the string is empty.
                (Height - row) calculates the number of spaces needed to be printed in the current row.
                * 2 is used to increase the space between the rows. */

                // Print the appropriate number of spaces to make the current row appear in the correct position to form a triangle shape.
                Console.Write("".PadLeft((Height - row) * 2));
                // Print the values of the current row of the triangle
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0, 3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


                //                       1
                //                     1   1
                //                   1   2   1
                //                 1   3   3   1
                //               1   4   6   4   1
                //             1   5  10  10   5   1
                //           1   6  15  20  15   6   1
                //         1   7  21  35  35  21   7   1
                //       1   8  28  56  70  56  28   8   1
                //     1   9  36  84 126 126  84  36   9   1
                //   1  10  45 120 210 252 210 120  45  10   1
                // 1  11  55 165 330 462 462 330 165  55  11   1
        }
    }
}
