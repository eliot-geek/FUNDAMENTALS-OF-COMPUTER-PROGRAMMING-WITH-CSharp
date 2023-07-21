namespace Ex15IEEE754FloatPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IEEE 745
            // Write a program that prints the value of the mantissa, the sign of the mantissa and exponent in float numbers (32-bit numbers with a floating-point according to the IEEE 754 standard).
            // Example: for the number -27.25 should be printed: sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

            // Guide: Use the special method for conversion of single precision floating-point numbers to a sequence of 4 bytes: System.BitConverter.GetBytes( <float>).
            // Then use bitwise operations (shifting and bit masks) to extract the sign, mantissa and exponent following the IEEE 754 standard.
            #endregion

            float number = -27.25f;
            PrintIEEE754Values(number);
            Console.ReadLine();
        }

        static void PrintIEEE754Values(float number)
        {
            // Get the bytes representation of the float number
            byte[] bytes = BitConverter.GetBytes(number);

            // Extract the sign, exponent, and mantissa from the bytes
            int sign = (bytes[3] >> 7) & 1;
            int exponent = ((bytes[3] & 0x7F) << 1) | ((bytes[2] >> 7) & 1);
            int mantissa = ((bytes[2] & 0x7F) << 16) | (bytes[1] << 8) | bytes[0];

            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Sign: {sign}");
            Console.WriteLine($"Exponent: {Convert.ToString(exponent, 2).PadLeft(8, '0')}"); // converts the exponent integer to an 8-bit binary string representation, ensuring that the binary string has exactly 8 characters by padding with leading zeros if necessary.
            Console.WriteLine($"Mantissa: {Convert.ToString(mantissa, 2).PadLeft(23, '0')}");

            /* Convert.ToString(exponent, 2): This part of the line converts the integer exponent to its binary representation as a string. 
            .PadLeft(8, '0'): After converting exponent to its binary string representation, this part of the line pads the binary string 
            with leading zeros on the left to ensure that the binary representation has a total length of 8 characters.
            The PadLeft method takes two arguments: the first argument (8) is the total length of the resulting string, and the second argument ('0') is the character used for padding.
             */
        }
    }
}