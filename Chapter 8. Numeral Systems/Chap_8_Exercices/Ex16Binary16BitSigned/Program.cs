using System;

namespace Ex16Binary16BitSigned
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that shows the binary representation of given 16 - bit signed integer number(the C# type short).
            // Write a program that shows the binary representation of given 16 - bit signed integer number(the C# type short).
            #endregion

            Console.Write("Enter a 16-bit signed integer (short): ");
            short number = short.Parse(Console.ReadLine());
            string binaryRepresentation = GetBinaryRepresentation(number);
            Console.WriteLine($"Binary representation: {binaryRepresentation}");
            Console.ReadLine();


            Console.WriteLine("\nSecond Solution");
            string binaryRepresentation1 = ConvertToBinaryLongWay(number);
            Console.WriteLine($"Binary representation: {binaryRepresentation1}");
            Console.ReadLine();
        }

        /// <summary>
        /// GetBinaryRepresentation
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static string GetBinaryRepresentation(short number)
        {
            // Use bitwise AND with 1 to extract the least significant bit (LSB)
            // Append the LSB to the binary representation
            string binary = "";
            for (int i = 0; i < 16; i++)
            {
                binary = (number & 1) + binary;
                number >>= 1; // Right shift to move to the next bit
            }
            return binary;
        }

        /// <summary>
        /// ConvertToBinaryLongWay
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static string ConvertToBinaryLongWay(short number)
        {
            number = Math.Abs(number);
            int carry = 0;
            string negativeInBinary = string.Empty;
            string numTo2Base = string.Empty;

            int digit;

            // ~number in binary
            while (number > 0)
            {
                digit = number % 2;

                if (digit == 1)
                {
                    numTo2Base = 0 + numTo2Base;
                }
                else
                {
                    numTo2Base = 1 + numTo2Base;
                }
                number /= 2;
            }

            numTo2Base = numTo2Base.PadLeft(16, '1');
            string numOne = "1".PadLeft(16, '0');
            //sum numTo2Base + numOne
            for (int i = numTo2Base.Length - 1; i >= 0; i--)
            {
                int sum = (numTo2Base[i] - 48) + (numOne[i] - 48);

                if (sum + carry == 2)
                {
                    negativeInBinary = 0 + negativeInBinary;
                    carry = 1;
                }
                else if (sum + carry == 3)
                {
                    negativeInBinary = 1 + negativeInBinary;
                    carry = 1;
                }
                else
                {
                    negativeInBinary = (sum + carry) + negativeInBinary;
                    carry = 0;
                }
            }
            return negativeInBinary;
        }
    }
}