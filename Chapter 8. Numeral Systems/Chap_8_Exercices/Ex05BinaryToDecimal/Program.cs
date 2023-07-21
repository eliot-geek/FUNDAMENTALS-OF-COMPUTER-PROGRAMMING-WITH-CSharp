using System;

namespace Ex05BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that converts a binary number to decimal one  in csharp
            // Guide: Start with a sum of 0. Multiply the right-most bit with 1 and add it to the sum. Multiply the next bit on the left by 2 and add it to the sum.
            // Multiply the next bit on the left by 4, the next by 8 and so on. You can cheat by invoking Convert.ToInt32(binaryNumAsString, 2).
            #endregion

            Console.Write("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();
            int decimalNumber = BinaryToDecimal(binaryNumber);
            Console.WriteLine($"Decimal representation: {decimalNumber}");
            Console.ReadLine();
        }

        /// <summary>
        /// Method to convert binary to decimal
        /// </summary>
        /// <param name="binaryNumber"></param>
        /// <returns></returns>
        static int BinaryToDecimal(string binaryNumber)
        {
            int decimalNumber = 0;
            int power = 1;

            // Loop through the binary number from right to left
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                // If the current bit is '1', add the corresponding power of 2 to the decimal number
                if (binaryNumber[i] == '1')
                {
                    decimalNumber += power;
                }
                // Multiply the power by 2 for the next iteration
                power *= 2;
            }
            return decimalNumber;
        }
    }
}