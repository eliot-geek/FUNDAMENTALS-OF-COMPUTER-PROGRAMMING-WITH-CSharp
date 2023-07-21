namespace Ex09BinaryToHexadec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that converts a binary number to hexadecimal one
            // Use the fast method for transitioning from binary to hexadecimal numeral system (each 4 binary bits correspond to a hexadecimal digit).
            #endregion

            Console.Write("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();
            string hexadecimalNumber = BinaryToHexadecimal(binaryNumber);
            Console.WriteLine($"Hexadecimal representation: {hexadecimalNumber}");
            Console.ReadLine();
        }

        /// <summary>
        /// Method to convert binary to hexadecimal using the fast method (4 bits per hexadecimal digit)
        /// </summary>
        /// <param name="binaryNumber"></param>
        /// <returns></returns>
        static string BinaryToHexadecimal(string binaryNumber)
        {
            // Pad the binary number with leading zeroes to make its length a multiple of 4
            int padLength = (4 - (binaryNumber.Length % 4)) % 4;
            binaryNumber = binaryNumber.PadLeft(binaryNumber.Length + padLength, '0');

            string hexadecimalNumber = "";
            // Convert every 4 binary bits to a hexadecimal digit
            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                string binaryDigit = binaryNumber.Substring(i, 4); // It extracts a substring of length 4 starting from the index i.
                char hexDigit = GetHexDigit(binaryDigit);
                hexadecimalNumber += hexDigit;
            }
            return hexadecimalNumber;
        }

        /// <summary>
        /// Helper method to get the hexadecimal digit from a 4-bit binary representation
        /// </summary>
        /// <param name="binaryDigit"></param>
        /// <returns></returns>
        static char GetHexDigit(string binaryDigit)
        {
            int decimalValue = Convert.ToInt32(binaryDigit, 2);

            if (decimalValue >= 0 && decimalValue <= 9)
                return (char)(decimalValue + '0'); // Convert digit to character (0-9)
            else
                return (char)(decimalValue - 10 + 'A'); // Convert 10 to 15 to 'A' to 'F'
        }
    }
}