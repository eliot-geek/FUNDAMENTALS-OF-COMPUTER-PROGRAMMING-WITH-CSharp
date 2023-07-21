namespace Ex04DecimalToBinary
{
    internal class Program
    {
        /// <summary>
        /// Method to convert decimal to binary
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <returns></returns>
        static string DecimalToBinary(int decimalNumber)
        {
            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder.ToString() + binary;
                decimalNumber /= 2;
            }
            return binary;
        }
        static void Main(string[] args)
        {
            #region Write a program that converts a decimal number to binary one.
            // Guide: The rule is "divide by 2 and concatenate the remainders in reversed order". For division with a remainder we use the % operator.
            // You can cheat by invoking Convert.ToString(numDecimal, 2).
            #endregion

            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            string binaryNumber = DecimalToBinary(decimalNumber);
            Console.WriteLine($"Binary representation: {binaryNumber}");
            Console.ReadLine();
        }
    }
}