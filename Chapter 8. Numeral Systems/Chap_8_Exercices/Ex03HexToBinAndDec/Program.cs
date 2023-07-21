namespace Ex03HexToBinAndDec
{
    internal class Program
    {
        /// <summary>
        /// Convert Hexad numbers to Binary and Decimal Numeral Systems
        /// </summary>
        /// <param name="value"></param>
        static void HexadecimalToBinaryAndDecimal(string value)
        {
            Console.WriteLine("{0} to decimal is {1}", value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} to binary is {1}\n", value, Convert.ToString(Convert.ToInt32(value, 16), 2));
        }

        static void Main(string[] args)
        {
            #region Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.
            // The results are: FA(16) = 250(10) = 11111010(2), 2A3E(16) = 10814(10) = 10101000111110(2), FFFF(16) = 65535(10) = 1111111111111111(2) and 5A0E9(16) = 368873(10) = 1011010000011101001(2).
            #endregion

            Console.WriteLine("First Solution");
            HexadecimalToBinaryAndDecimal("FA");
            HexadecimalToBinaryAndDecimal("2A3E");
            HexadecimalToBinaryAndDecimal("FFFF");
            HexadecimalToBinaryAndDecimal("5A0E9");


            Console.WriteLine("\nSecond Solution");
            string[] hexNumbers = { "FA", "2A3E", "FFFF", "5A0E9" };
            foreach (string hexNumber in hexNumbers)
            {
                int decimalNumber = Convert.ToInt32(hexNumber, 16); // Convert hexadecimal to decimal
                string binaryNumber = Convert.ToString(decimalNumber, 2);   // Convert decimal to binary
                Console.WriteLine($"{hexNumber}(16) = {decimalNumber}(10) = {binaryNumber}(2)");
            }


            // Manually
            Console.WriteLine("\nThird Solution");
            string[] hexNumb = { "FA", "2A3E", "FFFF", "5A0E9" };
            foreach (string hexNumber in hexNumb)
            {
                int decimalNumber = HexToDecimal(hexNumber);
                string binaryNumber = DecimalToBinary(decimalNumber);
                Console.WriteLine($"{hexNumber}(16) = {decimalNumber}(10) = {binaryNumber}(2)");
            }
        }

        /// <summary>
        /// Method to convert hexadecimal to decimal manually
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        static int HexToDecimal(string hex)
        {
            int result = 0;
            int power = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                char c = hex[i];
                int value = (c >= '0' && c <= '9') ? c - '0' : char.ToUpper(c) - 'A' + 10;
                result += value * power;
                power *= 16;
            }
            return result;
        }

        /// <summary>
        /// Method to convert decimal to binary manually
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <returns></returns>
        static string DecimalToBinary(int decimalNumber)
        {
            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }
            return binary;
        }
    }
}