using System;

namespace Ex14LongestSeqOfEqualStri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 14
            /* Write a program, which finds the longest sequence of equal string elements in a matrix. 
            A sequence in a matrix we define as a set of neighbor elements on the same row, column or diagonal.
            
            Guide: Check every element in a diagonal line, a row and a column until you get a sequence. If you get a sequence, 
            check whether this sequence is longer than the currently longest sequence. */

            // ha  fifi ho hi                       s  qq  s
            // fo  ha   hi xx                       pp pp  s
            // xxx ho   ha xx ===> ha ha ha         pp qq  s ===> s s s

            #endregion

            
            Console.WriteLine("Write a program, which finds the longest sequence of equal string elements in a matrix");
            // Read the matrix dimensions from the console
            Console.Write("Enter size n : ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter size m : ");
            int m = Int32.Parse(Console.ReadLine());

            int tempSeq = 1;        // Initialize temporary sequence counter to 1
            int seq = 1;            // Initialize sequence counter to 1
            string element = "e";   // Initialize the element that we are currently counting the sequence of

            // Declare and initialize the matrix
            string[,] arr = new string[n, m];
            for (int i = 0; i < n; i++)             // Loop over each row of the matrix
            {
                for (int j = 0; j < m; j++)         // Loop over each column of the matrix
                {
                    Console.Write("Arr [{0}][{1}] = ", i, j);
                    arr[i, j] = Convert.ToString(Console.ReadLine()); // Read the element from the console and add it to the matrix
                }
            }

            // Find the longest sequence of equal string elements
            // Check rows
            // Iterate through each row in the matrix
            for (int rowws = 0; rowws < arr.GetLength(0); rowws++)
            {
                // Iterate through each column in the matrix, except the last one
                for (int colums = 0; colums < arr.GetLength(1) - 1; colums++)
                {
                    // Check if the current element is the same as the next element
                    if (arr[rowws, colums] == arr[rowws, colums + 1])
                    {
                        // If it is, increment the temporary sequence counter
                        tempSeq++;
                    }
                    else
                    {
                        // If it's not, reset the temporary sequence counter to 1
                        tempSeq = 1;
                    }
                    // Check if the current temporary sequence is longer than the current longest sequence
                    if (seq < tempSeq)
                    {
                        // If it is, update the current longest sequence and the element that the sequence is made of
                        seq = tempSeq;
                        element = arr[rowws, colums];
                    }
                }
                // Reset the temporary sequence counter for the next row
                tempSeq = 1;
            }

            // Check columns
            // Iterate through each column of the matrix
            for (int colums = 0; colums < arr.GetLength(1); colums++)
            {
                // Iterate through each row of the matrix except the last one
                for (int rowws = 0; rowws < arr.GetLength(0) - 1; rowws++)
                {
                    // Check if the current element is equal to the element below it
                    if (arr[rowws, colums] == arr[rowws + 1, colums])
                    {
                        tempSeq++; // Increase the length of the sequence by 1
                    }
                    else
                    {
                        tempSeq = 1; // Reset the sequence length if the current element is not equal to the element below it
                    }
                    // Update the longest sequence if the current sequence is longer than the previous one
                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr[rowws, colums]; // Set the element of the longest sequence to the current element
                    }
                }
                tempSeq = 1; // Reset the sequence length for the next column
            }

            // Check diagonals
            // Loop through each element in the matrix
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Check the diagonal starting from the current element
                    for (int rowws = i, colums = j; rowws < arr.GetLength(0) - 1 && colums < arr.GetLength(1) - 1; rowws++, colums++)
                    {
                        // If the diagonal element is equal to the next element, increase the sequence count
                        if (arr[rowws, colums] == arr[rowws + 1, colums + 1])
                        {
                            tempSeq++;
                        }
                        else // If not, reset the sequence count to 1
                        {
                            tempSeq = 1;
                        }
                        // If the current sequence count is larger than the previous sequence, update the max sequence and element
                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr[rowws, colums];
                        }
                    }
                }
                // Reset the sequence count after each row
                tempSeq = 1;
            }

            // Iterate over the rows of the matrix
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Iterate over the columns of the matrix
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    // Iterate over the diagonal line of elements starting from the current element
                    for (int rowws = i, colums = j; rowws < arr.GetLength(0) - 1 && colums > 0; rowws++, colums--)
                    {
                        // Check if the current element is equal to the next element on the diagonal line
                        if (arr[rowws, colums] == arr[rowws + 1, colums - 1])
                        {
                            tempSeq++;
                        }
                        else
                        {
                            tempSeq = 1;
                        }
                        // Check if the current sequence is longer than the previous longest sequence
                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr[rowws, colums];
                        }
                    }
                }
                // Reset the temporary sequence count for the next row
                tempSeq = 1;
            }

            // Output the longest sequence of elements found in the matrix
            // by printing the element 'seq' number of times
            for (int i = 0; i < seq; i++)
            {
                Console.Write("{0}, ", element);
            }
            // Wait for user input before closing the console window
            Console.ReadLine();




            Console.WriteLine("\nSolution 2");
            // Read the matrix dimensions from the console
            Console.Write("\nEnter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());
            // Declare and initialize the matrix
            string[,] matrix = new string[rows, cols];

            Console.WriteLine("Enter the matrix elements:");
            // Read each row of the matrix from the console, split the input string into an array of strings and assign them to the matrix
            for (int row = 0; row < rows; row++)
            {
                // The input string is split based on whitespace characters
                string[] input = Console.ReadLine().Split();
                // Iterate over each row and column in the matrix and assign the corresponding input value to that element of the matrix
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            // Find the longest sequence of equal string elements
            int maxLength = 0;   // initialize the maximum length of sequence to zero
            string elemen = null;   // initialize the string element to null

            // Check rows
            for (int row = 0; row < rows; row++)        // loop through each row of the matrix
            {
                int length = 1;                             // initialize the length of the current sequence to 1
                for (int col = 1; col < cols; col++)   // loop through each column of the current row
                {
                    if (matrix[row, col] == matrix[row, col - 1])   // if current element is equal to the previous element in the row
                    {
                        length++;   // increment the length of current sequence
                    }
                    else   // if current element is not equal to the previous element in the row
                    {
                        if (length > maxLength)   // if length of current sequence is greater than maximum length found so far
                        {
                            maxLength = length;   // update the maximum length
                            elemen = matrix[row, col - 1];   // update the string element with the last element of the previous sequence
                        }
                        length = 1;   // reset the length of current sequence to 1
                    }
                }
                if (length > maxLength)   // check if the length of the last sequence is greater than maximum length found so far
                {
                    maxLength = length;   // update the maximum length
                    elemen = matrix[row, cols - 1];   // update the string element with the last element of the current sequence
                }
            }

            // Check columns
            for (int col = 0; col < cols; col++)
            {
                int length = 1;
                for (int row = 1; row < rows; row++)
                {
                    // If the current element is equal to the one above it
                    if (matrix[row, col] == matrix[row - 1, col])
                    {
                        // Increase the length of the sequence
                        length++;
                    }
                    else
                    {
                        // If the sequence ended, check its length
                        if (length > maxLength)
                        {
                            // Update the maximum length and element of the sequence
                            maxLength = length;
                            elemen = matrix[row - 1, col];
                        }
                        // Reset the length of the sequence
                        length = 1;
                    }
                }
                // Check if the last sequence in the column is the longest
                if (length > maxLength)
                {
                    maxLength = length;
                    elemen = matrix[rows - 1, col];
                }
            }


            // Check diagonals
            for (int row = 0; row < rows - 1; row++) // loop through rows
            {
                for (int col = 0; col < cols - 1; col++) // loop through columns
                {
                    int length = 1; // length of current sequence
                    int diagonalLength = Math.Min(rows - row, cols - col); // length of diagonal

                    for (int i = 1; i < diagonalLength; i++) // check diagonal sequence
                    {
                        if (matrix[row + i, col + i] == matrix[row + i - 1, col + i - 1]) // if current element equals previous element in sequence
                        {
                            length++; // increase length of sequence
                        }
                        else
                        {
                            break; // if not, break out of loop
                        }
                    }

                    if (length > maxLength) // if length of sequence is greater than previous max length
                    {
                        maxLength = length; // set new max length
                        elemen = matrix[row, col]; // set element at start of sequence as the current element
                    }
                }
            }

            // Print the result
            Console.Write("The longest sequence of equal string elements is: ");
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(elemen + " ");
            }
            Console.WriteLine();
        }
    }
}
