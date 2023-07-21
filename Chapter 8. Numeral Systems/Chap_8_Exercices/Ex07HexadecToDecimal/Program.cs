namespace Ex07HexadecToDecimal
{
    internal class Program
    {
        /// <summary>
        /// Method to convert hexadecimal to decimal
        /// </summary>
        /// <param name="hexadecimalNumber"></param>
        /// <returns></returns>
        static int HexadecimalToDecimal(string hexadecimalNumber)
        {
            int decimalNumber = 0;

            // Loop through the hexadecimal number from right to left
            for (int i = hexadecimalNumber.Length - 1, power = 1; i >= 0; i--, power *= 16)
            {
                char c = hexadecimalNumber[i];
                int digitValue;

                if (c >= '0' && c <= '9')
                    digitValue = c - '0'; // Convert digit character to its numeric value (0-9)
                else
                    digitValue = c - 'A' + 10; // Convert letter character to its numeric value (10-15)

                decimalNumber += digitValue * power;
            }
            return decimalNumber;
        }

        static void Main(string[] args)
        {
            #region Write a program that converts a hexadecimal number to decimal one
            // Start with a sum of 0. Multiply the right-most digit with 1 and add it to the sum. Multiply the next digit to the left by 16 and add it to the sum.
            // Multiply the next digit by 16*16, the next by 16*16*16 and so on. You can cheat by invoking Convert.ToInt32(hexNumAsString, 16).
            #endregion

            Console.Write("Enter a hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine().ToUpper(); // Convert to uppercase to handle both uppercase and lowercase letters
            int decimalNumber = HexadecimalToDecimal(hexadecimalNumber);
            Console.WriteLine($"Decimal representation: {decimalNumber}");
            Console.ReadLine();
        }
    }
}