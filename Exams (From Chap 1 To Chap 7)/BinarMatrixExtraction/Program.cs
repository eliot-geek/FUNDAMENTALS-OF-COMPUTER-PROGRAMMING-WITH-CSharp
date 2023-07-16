using System.Text;

namespace BinarMatrixExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task: Extracting Integers from a Binary Matrix
            /* The program receives input in the form of 32-bit binary numbers and stores them in a 2D matrix of size 32x32. The matrix can have up to 32 rows, 
             * and each row represents a 32-bit binary number. The program processes the binary numbers and extracts integers based on specific conditions. 
             * The conditions for extracting integers are as follows:

            For each row in the input matrix:
            If the row contains a '1', remove the first occurrence of '1' from the row, and set the rest of the bits in that row to '0'.
            If a '0' appears after the first '1', set the corresponding bit in the result matrix to '1', and count the number of consecutive zeros following the first '1'.
            If a '1' does not appear in the row, leave the row as it is in the result matrix (all zeros).
            Once all the rows are processed, the program forms new integers from the modified rows in the result matrix. Each row in the result matrix represents a 32-bit binary number, which is converted into an integer.

            Conditions:
            Input:
            The program receives a sequence of 32-bit binary numbers as input, with each number separated by a newline.
            The input ends when the program encounters a "-1" (as a decimal number).
            
            Logic:
            The program processes the binary numbers row by row and modifies them based on the conditions mentioned above.
            If a '1' is found in a row, it removes the first occurrence of '1', sets the rest of the bits to '0', and marks '1's in the result matrix based on the number of consecutive zeros following the first '1'.
            If a row does not contain a '1', it remains unchanged in the result matrix (all zeros).
            
            Output:
            The program prints the modified binary numbers (32-bit) in decimal format, one number per line, after applying the conditions.*/
            #endregion

            int[,] matrix = new int[32, 32];  // Initialize a 32x32 matrix to store the binary numbers
            int countRow = 0;                 // Initialize a counter to keep track of the number of rows in the matrix
            bool isOne = false;               // Initialize a flag to check if a '1' has been encountered in a row
            int countZeros = 0;               // Initialize a counter to count consecutive zeros following a '1'

            // Read and process the input binary numbers until '-1' is encountered
            for (int row = 0; row < 32; row++)
            {
                Console.Write("Enter a 32-bit binary number: ");
                long num = long.Parse(Console.ReadLine()); // Read a 32-bit binary number as a long integer
                if (num == -1) // Check if the input number is -1 (indicating the end of input)
                {
                    break; // If -1 is encountered, break the loop
                }
                string numToString = Convert.ToString(num, 2).PadLeft(32, '0'); // Convert the long number to a 32-bit binary string
                countRow++; // Increment the row counter

                // Store the binary digits in the matrix
                for (int col = 0; col < 32; col++)
                {
                    matrix[row, col] = int.Parse(numToString[col].ToString());
                }
            }

            int[,] result = new int[countRow, 32]; // Initialize a new matrix to store the modified binary numbers

            // Process each row of the matrix to modify the binary numbers
            for (int row = 0; row < countRow; row++)
            {
                countZeros = 0; // Reset the count of consecutive zeros
                isOne = false; // Reset the 'isOne' flag for each row

                // Process each column in the row to apply the conditions
                for (int col = 0; col < 32; col++)
                {
                    if (matrix[row, col] == 1) // If a '1' is encountered in the row
                    {
                        if (countZeros != 0) // If there are consecutive zeros before the '1'
                        {
                            isOne = false; // Set the 'isOne' flag to false
                        }
                        else
                        {
                            matrix[row, col] = 0; // Remove the first '1' encountered and set the rest of the bits to '0'
                            isOne = true; // Set the 'isOne' flag to true
                        }
                    }
                    else if (isOne == true && matrix[row, col] == 0) // If '0' is encountered after the first '1'
                    {
                        result[row, col] = 1; // Set the corresponding bit in the result matrix to '1'
                        countZeros++; // Increment the count of consecutive zeros
                    }
                }

                if (isOne == true) // If a '1' was found in the row
                {
                    for (int col = 0; col < 32; col++)
                    {
                        result[row, col] = 0; // Set all bits to '0' in the result matrix for this row
                    }
                }
            }

            // Convert the modified binary numbers in the result matrix to decimal and print them
            for (int row = 0; row < countRow; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < 32; col++)
                {
                    sb.Append(result[row, col]); // Append each bit of the binary number to a StringBuilder
                }
                int num = Convert.ToInt32(sb.ToString(), 2); // Convert the binary number to an integer
                Console.WriteLine(num); // Print the integer value
            }
        }
    }
}