using System;

namespace Ex15HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 15
            // Write a program that converts a given number from hexadecimal to decimal notation.
            #endregion

            Console.WriteLine("Conversion from hexadecimal to decimal notation(numeral system)");
            Console.Write("Enter a hexadecimal number : "); // Prompt the user to enter a hexadecimal number
            string hexadecimal = Convert.ToString(Console.ReadLine());  // Read the user input as a string
            int toDecimalNumber = Convert.ToInt32(hexadecimal, 16); // Convert the hexadecimal string directly to an integer in decimal notation
            Console.WriteLine("The number {0} in hexadecimal notation is {1}", hexadecimal, toDecimalNumber);   // Output the final decimal value using string interpolation
            Console.ReadLine();



            Console.WriteLine("\nSolution 2");
            Console.Write("Enter a hexadecimal number : ");
            hexadecimal = Convert.ToString(Console.ReadLine());
            int decimalNumber = 0;
            // sets up a loop that will iterate over each character in the hexadecimal string.
            for (int i = decimalNumber; i < hexadecimal.Length; i++)
            {
                // checks the current character in the hexadecimal string to determine its value in decimal notation.
                switch (hexadecimal[i])
                {
                    // handle the cases where the current character is a letter A-F. These cases use the Math.Pow() method
                    // to raise 16 to the appropriate power, and then multiply the result by the corresponding decimal value for the letter.
                    case 'A':
                        decimalNumber += 10 * (int)Math.Pow(16, hexadecimal.Length - i - 1);
                        break;
                    case 'B':
                        decimalNumber += 11 * (int)Math.Pow(16, hexadecimal.Length - i - 1);
                        break;
                    case 'C':
                        decimalNumber += 12 * (int)Math.Pow(16, hexadecimal.Length - i - 1);
                        break;
                    case 'D':
                        decimalNumber += 13 * (int)Math.Pow(16, hexadecimal.Length - i - 1);
                        break;
                    case 'E':
                        decimalNumber += 14 * (int)Math.Pow(16, hexadecimal.Length - i - 1);
                        break;
                    case 'F':
                        decimalNumber += 15 * (int)Math.Pow(16, hexadecimal.Length - i - 1);
                        break;
                    // handles the case where the current character is a digit (0-9). It uses the char.GetNumericValue() method to convert the character
                    // to its corresponding numeric value, and then multiplies the result by the appropriate power of 16.
                    default:
                        decimalNumber += (int)char.GetNumericValue(hexadecimal[i]) * (int)Math.Pow(16, hexadecimal.Length - i - 1);
                        break;
                }
            }
            Console.WriteLine("The number {0} in hexadecimal notation is {1}", hexadecimal, decimalNumber);
            Console.WriteLine();




            Console.WriteLine("\nSolution 3");
            // Prompt the user to enter a hexadecimal number
            Console.Write("Enter a hexadecimal number: ");
            // Read the user input as a string
            string hexNum = Console.ReadLine();
            // Initialize a variable to hold the decimal equivalent of the hexadecimal number
            int decNum = 0;

            // Loop through each character in the hexadecimal string
            for (int i = 0; i < hexNum.Length; i++)
            {
                // Determine the power of 16 for the current digit based on its position in the string
                int power = hexNum.Length - 1 - i;
                // If the current character is a digit (0-9), convert it to an integer and multiply by the appropriate power of 16
                if (Char.IsDigit(hexNum[i]))
                {
                    decNum += int.Parse(hexNum[i].ToString()) * (int)Math.Pow(16, power);
                }
                // If the current character is a letter (A-F), convert it to an integer and multiply by the appropriate power of 16
                else
                {
                    decNum += (hexNum[i] - 'A' + 10) * (int)Math.Pow(16, power);
                    // The expression 'hexNum[i] - 'A' + 10' converts the hexadecimal letter to its corresponding decimal value
                    // For example, if hexNum[i] is 'C', the expression evaluates to 12 (the decimal value of C)
                    // We add 10 to the expression because the letters A-F correspond to decimal values 10-15 in hexadecimal
                }
            }
            // Output the final decimal value using string interpolation
            Console.WriteLine($"The decimal equivalent of {hexNum} is {decNum}");
        }
    }
}
