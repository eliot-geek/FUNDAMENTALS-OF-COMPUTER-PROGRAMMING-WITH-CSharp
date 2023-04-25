using System;

namespace Ex13BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 13
            // Write a program that converts a given number from binary to decimal notation.
            #endregion


            Console.WriteLine("Conversion from binary to decimal notation(numeral system)");
            Console.Write("Enter a number in binary notation : ");
            string number = Console.ReadLine();
            int toDecimal = Convert.ToInt32(number, 2);
            Console.WriteLine("The number {0} in decimal notation is {1}", number, toDecimal);
            Console.ReadLine();



            Console.WriteLine("\nSolution 2");
            Console.Write("Enter a number in binary notation : ");
            string binaryNumber = Console.ReadLine();
            // declare and initialize two integer variables "sum" and "power" to 0.
            int sum = 0;
            int power = 0;
            //  iterates through each character in the binaryNumber string
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                // If the current character is '1', the program calculates the corresponding power of 2
                // (based on the position of the '1' in the string), and adds it to the sum variable.
                if (binaryNumber[i] == '1')
                {
                    power = binaryNumber.Length - 1 - i;
                    sum += (int)Math.Pow(2, power);
                }
            }
            Console.WriteLine("The number {0} in decimal notation is {1}", binaryNumber, sum);
            Console.ReadLine();



            Console.WriteLine("\nSolution 3");
            // Display a prompt to enter a binary number on the console
            Console.Write("Enter the Binary Number : ");
            // Read the input binary number as a string and parse it as an integer
            int binaryNumb = int.Parse(Console.ReadLine());
            // Initialize the decimal value to 0
            int decimalValue = 0;
            // Initialize the base1 value to 1 (i.e., 2^0)
            int base1 = 1;
            // Loop through each digit of the binary number until it becomes zero
            while (binaryNumb > 0)
            {
                // Get the rightmost digit of the binary number
                int reminder = binaryNumb % 10;
                // Divide the binary number by 10 to remove the rightmost digit
                binaryNumb = binaryNumb / 10;
                // Multiply the rightmost digit by the current base1 value and add it to the decimal value
                decimalValue += reminder * base1;
                // Multiply the current base1 value by 2 to get the next power of 2
                base1 = base1 * 2;
            }
            // Display the decimal value of the binary number on the console
            Console.Write($"Decimal Value : {decimalValue} ");

        }
    }
}
