namespace Ex06DecimalToHexadec
{
    internal class Program
    {
        /// <summary>
        /// Method to convert decimal to hexadecimal
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <returns></returns>
        static string DecimalToHexadecimal(int decimalNumber)
        {
            // Special case for zero
            if (decimalNumber == 0)
                return "0";
            
            string hexadecimal = "";
            // Loop until the decimal number becomes zero
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 16; // Get the remainder when dividing by 16 (base of the hexadecimal system)
                char hexDigit = GetHexDigit(remainder); // Get the hexadecimal digit from the remainder and append it to the result
                hexadecimal = hexDigit + hexadecimal;
                decimalNumber /= 16;    // Divide the decimal number by 16 for the next iteration
            }
            return hexadecimal;
        }

        /// <summary>
        /// Helper method to get a hexadecimal digit from a decimal number (0 to 15)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static char GetHexDigit(int num)
        {
            if (num >= 0 && num <= 9)
                return (char)(num + '0'); // Convert digit to character (0-9)
            else
                return (char)(num - 10 + 'A'); // Convert 10 to 15 to 'A' to 'F'
        }

        static void Main(string[] args)
        {
            #region Write a program that converts a decimal number to hexadecimal one
            // The rule is "divide by the base of the system (16) and concatenate the remainders in reversed order".
            // A logic that gets a hexadecimal digit (0…F) by decimal number (0…15) should also be implemented.
            // You can cheat by invoking num.ToString("X").
            #endregion

            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexadecimalNumber = DecimalToHexadecimal(decimalNumber);
            Console.WriteLine($"Hexadecimal representation: {hexadecimalNumber}");
            Console.ReadLine();
        }
    }
}