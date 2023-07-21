namespace Ex02BinaryToDecHex
{
    internal class Program
    {
        /// <summary>
        /// Binary To Decimal
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns>
        static int BinaryToDecimal(string binary)
        {
            int decimalNumber = Convert.ToInt32(binary, 2);
            return decimalNumber;
        }

        /// <summary>
        /// Binary To Hexadecimal
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns>
        static string BinaryToHexadecimal(string binary)
        {
            long decimalNumber = Convert.ToInt64(binary, 2);
            string hexadecimalNumber = decimalNumber.ToString("X");
            return hexadecimalNumber;
        }
        
        static void Main(string[] args)
        {
            #region Task 02 : Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.
            // Guide: Like the previous exercise. Result: F59E(16) and 62878(10).
            #endregion

            Console.WriteLine("First Method");
            Console.WriteLine("1111010110011110 to Hexadecimal is {0}", Convert.ToInt64("1111010110011110", 2).ToString("X"));
            Console.WriteLine("1111010110011110 to Decimal is {0}", Convert.ToInt64("1111010110011110", 2));

            Console.WriteLine("\nSecond Method");
            string binaryNumber = "1111010110011110";
            int decimalNumber = BinaryToDecimal(binaryNumber); // Convert binary to decimal
            string hexadecimalNumber = BinaryToHexadecimal(binaryNumber); // Convert binary to hexadecimal
            Console.WriteLine($"Binary: {binaryNumber}");
            Console.WriteLine($"Hexadecimal: {hexadecimalNumber}");
            Console.WriteLine($"Decimal: {decimalNumber}");


            Console.WriteLine("\nThird Method");
            string binaryNumb = "1111010110011110";
            int decimalNumb = BinaryToDec(binaryNumb);  // Convert binary to decimal
            string hexadecimalNumb = BinaryToHexadec(binaryNumb);   // Convert binary to hexadecimal
            Console.WriteLine($"Binary: {binaryNumb}");
            Console.WriteLine($"Decimal: {decimalNumb}");
            Console.WriteLine($"Hexadecimal: {hexadecimalNumb}");

        }

        static int BinaryToDec(string binary)
        {
            int decimalNumber = 0;
            int power = 0;

            // Iterate through the binary string from right to left
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                // Check if the current bit is 1
                if (binary[i] == '1')
                {
                    // Add the value of the bit position to the decimalNumber
                    decimalNumber += (int)Math.Pow(2, power);
                }
                power++; // Move to the next bit position (increase the power of 2)
            }
            return decimalNumber;
        }

        static string BinaryToHexadec(string binary)
        {
            // Convert binary to decimal using the BinaryToDecimal method
            int decimalNumber = BinaryToDec(binary);
            // Convert decimal to hexadecimal using the ToString("X") method
            string hexadecimalNumber = decimalNumber.ToString("X");
            return hexadecimalNumber;
        }
    }
}