using System;

namespace Ex14DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 14
            // Write a program that converts a given number from decimal to hexadecimal notation.
            #endregion


            Console.WriteLine("\nSolution 1");
            Console.WriteLine("Conversion from decimal to hexadecimal notation(numeral system)");
            Console.Write("Enter a decimal number : ");
            int decimalNumber = Int32.Parse(Console.ReadLine());
            string toHexadecimalNumber = Convert.ToString(decimalNumber, 16);
            Console.WriteLine("The number {0} in hexadecimal notation is {1}", decimalNumber, toHexadecimalNumber.ToUpper());
            Console.ReadLine();



            Console.WriteLine("\nSolution 2");
            // Prompt the user to enter a decimal number
            Console.Write("Enter a decimal number : ");
            // Parse the user input to an integer
            decimalNumber = Int32.Parse(Console.ReadLine());
            // Initialize an empty string for the hexadecimal value
            string hexadecimal = " ";
            // Declare a variable to store the remainder
            int value = 0;

            // Iterate through the decimal number in base 16 (hexadecimal)
            for (int i = decimalNumber; i > 0; i /= 16)
            {
                // Calculate the remainder of the division by 16
                value = i % 16;
                // Convert the remainder to a hexadecimal digit using a switch statement
                switch (value)
                {
                    case 10:
                        hexadecimal = "A";
                        break;
                    case 11:
                        hexadecimal = "B";
                        break;
                    case 12:
                        hexadecimal = "C";
                        break;
                    case 13:
                        hexadecimal = "D";
                        break;
                    case 14:
                        hexadecimal = "E";
                        break;
                    case 15:
                        hexadecimal = "F";
                        break;
                    default:
                        hexadecimal = value.ToString() + hexadecimal;
                        break;
                }
            }
            // Remove any leading or trailing spaces from the hexadecimal string
            hexadecimal = hexadecimal.Trim(' ');
            // Output the result to the console
            Console.WriteLine("The number {0} in hexadecimal notation is {1}", decimalNumber, hexadecimal);
            Console.ReadLine();
        }
    }
}
