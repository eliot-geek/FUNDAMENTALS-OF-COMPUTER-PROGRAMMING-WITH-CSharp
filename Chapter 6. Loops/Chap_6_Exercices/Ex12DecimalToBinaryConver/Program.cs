using System;

namespace Ex12DecimalToBinaryConver
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 12
            // Write a program that converts a given number from decimal to binary notation(numeral system).
            // Guide: Read in Wikipedia what numeral systems are: http://en.wikipedia.org/ wiki/Numeral_system. After that consider how you can convert numbers
            // from decimal numeral system to another. Think about the opposite – moving from another numeral system to decimal. If you have difficulty,
            // see the chapter "Numeral Systems".
            #endregion


            Console.WriteLine("Solution 1");
            Console.WriteLine("Conversion from decimal to binary notation(numeral system)");
            // Prompt the user to enter a number in decimal notation
            Console.Write("Enter a number in decimal notation : ");
            // Read the user's input as a string and parse it as an integer
            int number = Int32.Parse(Console.ReadLine());
            // Use the built-in Convert.ToString() method to convert the decimal number to binary and store it in a string variable
            string toBinary = Convert.ToString(number, 2);
            // Print the original decimal number and its binary representation to the console
            Console.WriteLine("The number {0} in binary notation is {1}", number, toBinary);
            // Wait for the user to press Enter before closing the console window
            Console.ReadLine();


            Console.WriteLine("\nSolution 2");
            Console.WriteLine("Conversion from decimal to binary notation(numeral system)");
            // Prompt the user to enter a decimal number
            Console.Write("Enter a number in decimal notation: ");
            // Read the user's input as a string and parse it as an integer
            int decimalNum = int.Parse(Console.ReadLine());
            // Initialize an empty string variable to store the binary representation
            string binaryNum = "";

            // Use a while loop to repeatedly divide the decimal number by 2 and concatenate the remainder (either 0 or 1)
            // to the left of the binary representation string
            while (decimalNum > 0)
            {
                binaryNum = (decimalNum % 2) + binaryNum;
                decimalNum /= 2;
            }
            // Print the binary representation of the decimal number to the console
            Console.WriteLine("Binary representation: {0}", binaryNum);
            // Wait for the user to press Enter before closing the console window
            Console.ReadLine();


            Console.WriteLine("\nSolution 3");
            Console.WriteLine("Conversion from decimal to binary notation(numeral system)");
            Console.Write("Enter a number in decimal notation : ");
            int numb = Int32.Parse(Console.ReadLine());
            string binaire = " ";

            // checks if the input number is 0
            if (numb == 0)
            {
                Console.WriteLine(numb);
            }
            else
            {
                //  loop iterates over the decimal number and divides it by 2 in each iteration.
                //  If the remainder is 1, it adds a '1' to the binary string; otherwise, it adds a '0'.
                for (int i = numb; i > 0; i/=2)
                {
                    if (i % 2 != 0)
                    {
                        binaire = '1' + binaire;
                    }
                    else
                    {
                        binaire = '0' + binaire;
                    }
                }
                // Remove whitespace characters from the beginning and/or end of a string but
                // indicates only spaces (not tabs or other whitespace characters) should be removed.
                binaire = binaire.Trim(' ');
                Console.WriteLine("The number {0} in binary notation is {1}", numb, binaire);
            }
        }
    }
}
