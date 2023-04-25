using System;
using System.Threading;

namespace Ex10PositiveIntegerMatriz
{
    #region Task 10
    // Write a program that reads from the console a positive integer number N(N < 20) and prints a matrix of numbers as on the figures below: 3X3 4X4 5X5
    //         N = 3 →  1 2 3               N = 4 →  1 2 3 4
    //                  2 3 4                        2 3 4 5
    //                  3 4 5                        3 4 5 6
    //                                               4 5 6 7
    // Guide: You should use two nested loops, similar to the problem "Printing a Triangle". The outer loop must run from 1 to N, and the inner –
    // from the value of the outer loop to the value of the outer loop + N - 1.
    #endregion

    class Program
    {
        // Initialize the number to 1
        static int number = 1;

        /* So, 4 * numJ + 1 sets the X coordinate, where numJ represents the column number of the current number being printed and each column is 4 characters 
         * wide (because the table is formatted to have 3 columns with a space of 1 character between them). The +1 is added to adjust for the border 
         * characters of the table.
        Similarly, 2 * numI + 1 sets the Y coordinate, where numI represents the row number of the current number being printed and each row is 2 characters 
        high (because the table is formatted to have 1 row with a space of 1 character between them). The +1 is added to adjust for the border characters of 
        the table. */

        // Function to set the cursor position and display the number in the console
        static void Number(int numJ, int numI, int num)
        {
            // Add a delay of 150ms to simulate animation
            Thread.Sleep(150);
            // Set the cursor position based on the row and column of the number
            Console.SetCursorPosition(4 * numJ + 1, 2 * numI + 1);
            // Set the color of the number to green
            Console.ForegroundColor = ConsoleColor.Green;
            // Display the number in the console
            Console.Write(num);
            // Reset the console color to the default color
            Console.ResetColor();
        }

        // Function to create a row of the table
        static void T(int y, int n, char ch1, char ch2, char ch3, char space)
        {
            // Set the cursor position to the beginning of the row
            Console.SetCursorPosition(3, y);

            // Display the left character of the row
            Console.Write(ch1);

            // Display the space between the left and right characters of the row
            Console.Write(new string(space, 4 * n - 1));

            // Display the right character of the row
            Console.Write(ch2);

            // Loop through the columns in the row and display the character to mark the column
            for (int z = 7; z <= n * 4; z += 4)
            {
                Console.SetCursorPosition(z, y);
                Console.Write(ch3);
            }
        }

        static void Main(string[] args)
        {
            // Display the title of the program
            Console.WriteLine("Second Solution");
            // Prompt the user to enter a number between 1 and 19
            Console.Write("Enter n (n < 20): ");
            // Parse the user's input as an integer
            int n = int.Parse(Console.ReadLine());

            // Loop until the user enters a valid number between 1 and 19
            while (n < 1 || n > 19)
            {
                Console.Clear();
                Console.Write("Enter a positive integer number from 1 to 19: ");
                // Set the console color to yellow to highlight the error message
                Console.ForegroundColor = ConsoleColor.Yellow;
                // Parse the user's input as an integer
                n = int.Parse(Console.ReadLine());
                // Reset the console color to the default color
                Console.ResetColor();
            }

            // Create the table

            // draws the 1st row
            T(2, n, '┌', '┐', '┬', '─');
            // draws the 2nd row
            T(3, n, '│', '│', '│', ' ');

            // loop for remaining rows - loops through all rows if there are more than 2
            for (int z = 3; z < 2 * n; z += 2)                      
            {
                T(z + 1, n, '├', '┤', '┼', '─');     // draws a row separator
                T(z + 2, n, '│', '│', '│', ' ');     // draws a row without numbers
            }

            // draws the last row
            T(4 + 2 * (n - 1), n, '└', '┘', '┴', '─');

            // Suspends the current thread for 500 milliseconds (half a second)
            Thread.Sleep(500);
            // Loop through the rows and columns of the table to display the numbers
            // Loops through each cell in the table, calling the Number() method to print the corresponding number
            // Updates the 'number' variable after each cell is printed
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Number(j, i, number);   // prints the number in the current cell
                    number++;               // increments the number to print in the next cell
                }
                number = i + 1;         // sets the starting number for the next row
                Console.WriteLine();    // moves the cursor to the next line
            }
            // Moves the cursor to the bottom left of the table
            Console.SetCursorPosition(0, 2 * n + 4);
        }
    }
}
