namespace BinaryDetection
{
    public static class IntExtensions
    {
        // Extension method to set a specific bit of an unsigned integer (uint) to the given value
        public static uint SetBit(this uint target, int field, bool value)
        {
            field = 31 - field; // Convert the bit index to 0-based index (reverse order)
            if (value == true)
            {
                return (uint)(target | (1 << field)); // Set the bit to 1
            }
            else
            {
                return (uint)(target & ~(1 << field)); // Set the bit to 0
            }
        }

        // Extension method to get the value of a specific bit in an unsigned integer (uint)
        public static bool GetBit(this uint target, int field)
        {
            field = 31 - field; // Convert the bit index to 0-based index (reverse order)
            return (target & (1 << field)) != 0; // Check if the bit is 1 or 0 and return the result
        }
    }

    internal class Program
    {
        static List<uint> input = new List<uint>(); // List to store the input binary numbers
        static List<uint> output = new List<uint>(); // List to store the output binary numbers

        // Function to check if a specific binary digit is inside the border in the binary matrix
        static bool IsInside(int x, int y)
        {
            bool[] bBorder = { false, false, false, false }; // Array to track if the digit is inside the border

            int temp;

            // Check for the border conditions in all four directions (left, right, up, down)
            temp = x - 1;
            while (temp >= 0)
            {
                if ((input[temp].GetBit(y)) == true)
                {
                    bBorder[0] = true;
                    break;
                }
                temp--;
            }

            temp = x + 1;
            while (temp < input.Count)
            {
                if ((input[temp].GetBit(y)) == true)
                {
                    bBorder[1] = true;
                    break;
                }
                temp++;
            }

            temp = y - 1;
            while (temp >= 0)
            {
                if ((input[x].GetBit(temp)) == true)
                {
                    bBorder[2] = true;
                    break;
                }
                temp--;
            }

            temp = y + 1;
            while (temp < 32)
            {
                if ((input[x].GetBit(temp)) == true)
                {
                    bBorder[3] = true;
                    break;
                }
                temp++;
            }

            // If the binary digit is inside the border (surrounded by '0's on all four sides), return true; otherwise, return false
            if ((bBorder[0] == true) && (bBorder[1] == true) && (bBorder[2] == true) && (bBorder[3] == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            #region Task: Binary Border Detection
            /* The program performs binary border detection for a given set of binary numbers. It reads a sequence of 32-bit binary numbers as input and processes them to 
             * detect the border elements in the binary matrix. Border elements are defined as binary digits '1' that are surrounded by '0's on all four sides 
             * (top, bottom, left, and right). The program converts the border elements to '1's in the output binary matrix, and all other elements remain '0's.

            Conditions:
            Input:
            The program reads a sequence of 32-bit binary numbers as input, with each number separated by a newline.
            The input ends when the program encounters a negative number (less than 0).
            
            Logic:
            The program processes the binary numbers one by one and detects border elements by checking each binary digit in the binary matrix.
            For each digit in the input binary number, the program checks if the digit is '1' and whether it is surrounded by '0's on all four sides.
            If the digit is '1' and satisfies the border condition, it is set to '1' in the output binary number. Otherwise, it is set to '0'.
            
            Output:
            The program prints the modified binary numbers (32-bit) as decimal integers, one number per line, after applying the binary border detection logic.
            
            The code uses two extension methods (SetBit and GetBit) for the uint data type, which are defined in the IntExtensions class. These methods enable easy manipulation of individual bits in the binary numbers.*/
            #endregion

            // Read input binary numbers until a negative number (less than 0) is encountered
            while (true)
            {
                Console.Write("Enter a random binary number: ");
                long x = long.Parse(Console.ReadLine());

                if (x >= 0)
                {
                    input.Add((uint)x); // Convert the long number to an unsigned integer (uint) and add it to the input list
                }
                else
                {
                    break; // If a negative number is encountered, break the loop to end input reading
                }
            }

            // Process each input binary number and perform binary border detection
            for (int i = 0; i < input.Count; i++)
            {
                uint temp = 0; // Temporary variable to store the modified binary number

                // Iterate through each bit (digit) of the binary number
                for (int k = 0; k < 32; k++)
                {
                    if (input[i].GetBit(k) == true)
                    {
                        temp = temp.SetBit(k, false); // If the current bit is '1', set it to '0' in the temporary variable
                    }
                    else
                    {
                        // Check if the binary digit is inside the border, and set it accordingly in the temporary variable
                        bool res = IsInside(i, k);
                        if (res == true)
                        {
                            temp = temp.SetBit(k, true); // Set the digit to '1' if it is inside the border
                        }
                        else
                        {
                            temp = temp.SetBit(k, false); // Set the digit to '0' if it is not inside the border
                        }
                    }
                }
                output.Add(temp); // Add the modified binary number to the output list
            }

            Console.WriteLine();

            // Print the modified binary numbers as decimal integers, one number per line
            foreach (var i in output)
            {
                Console.WriteLine(i);
            }
        }
    }
}