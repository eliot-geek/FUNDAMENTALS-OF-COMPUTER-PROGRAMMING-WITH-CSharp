namespace Ex10HornerSchemeConv
{
    internal class Program
    {
        static int ConvertBinaryToDecimal(string binaryString)
        {
            int decimalValue = 0;
            int len = binaryString.Length;

            for (int i = 0; i < len; i++)
            {
                // Get the current digit as an integer value (0 or 1)
                int digit = binaryString[i] - '0';

                // Apply the Horner scheme:
                // Multiply the current decimal value by 2 and add the current binary digit
                decimalValue = decimalValue * 2 + digit;
            }

            return decimalValue;
        }
        static void Main(string[] args)
        {
            #region Write a program that converts a binary number to decimal using the Horner scheme
            // Directly apply the Horner scheme
            // we multiply the left most digit by 2 and add it to the one to its right. We multiply this result by two and the neighboring digit (one to the right) is added.
            // This is repeated until all the digits in the number have been exhausted and we add the last digit without multiplying it.
            // Here is an example: 1001(2) = ((1 × 2 + 0) × 2 + 0) × 2 + 1 = 2 × 2 × 2 + 1 = 9
            #endregion

            Console.Write("Enter a binary number: ");
            string binaryString = Console.ReadLine();
            int decimalValue = ConvertBinaryToDecimal(binaryString);
            Console.WriteLine($"Decimal value: {decimalValue}");
            Console.ReadLine();
        }
    }
}