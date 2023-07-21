namespace Ex08HexadecToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that converts a hexadecimal number to binary one
            // Use the fast method for transitioning between hexadecimal and binary numeral system (each hexadecimal digit turns to 4 binary bits).
            #endregion

            Console.Write("Enter a hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine().ToUpper(); // Convert to uppercase to handle both uppercase and lowercase letters
            string binaryNumber = HexadecimalToBinary(hexadecimalNumber);
            Console.WriteLine($"Binary representation: {binaryNumber}");
            Console.ReadLine();
        }

        /// <summary>
        /// Method to convert hexadecimal to binary using the fast method (4 bits per hexadecimal digit)
        /// </summary>
        /// <param name="hexadecimalNumber"></param>
        /// <returns></returns>
        static string HexadecimalToBinary(string hexadecimalNumber)
        {
            string binaryNumber = "";

            // Convert each hexadecimal digit to 4 binary bits
            foreach (char c in hexadecimalNumber)
            {
                string binaryDigit = GetBinaryDigit(c);
                binaryNumber += binaryDigit;
            }
            return binaryNumber;
        }

        /// <summary>
        /// Helper method to get the 4-bit binary representation of a hexadecimal digit
        /// </summary>
        /// <param name="hexDigit"></param>
        /// <returns></returns>
        static string GetBinaryDigit(char hexDigit)
        {
            string binaryDigit = "";

            switch (hexDigit)
            {
                case '0':
                    binaryDigit = "0000";
                    break;
                case '1':
                    binaryDigit = "0001";
                    break;
                case '2':
                    binaryDigit = "0010";
                    break;
                case '3':
                    binaryDigit = "0011";
                    break;
                case '4':
                    binaryDigit = "0100";
                    break;
                case '5':
                    binaryDigit = "0101";
                    break;
                case '6':
                    binaryDigit = "0110";
                    break;
                case '7':
                    binaryDigit = "0111";
                    break;
                case '8':
                    binaryDigit = "1000";
                    break;
                case '9':
                    binaryDigit = "1001";
                    break;
                case 'A':
                    binaryDigit = "1010";
                    break;
                case 'B':
                    binaryDigit = "1011";
                    break;
                case 'C':
                    binaryDigit = "1100";
                    break;
                case 'D':
                    binaryDigit = "1101";
                    break;
                case 'E':
                    binaryDigit = "1110";
                    break;
                case 'F':
                    binaryDigit = "1111";
                    break;
                default:
                    Console.WriteLine($"Invalid hexadecimal digit: {hexDigit}");
                    break;
            }
            return binaryDigit;
        }
    }
}