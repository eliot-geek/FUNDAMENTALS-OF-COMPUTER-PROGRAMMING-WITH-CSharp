using System;

namespace Ex_04_Check_Third_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks whether the third bit in a given integer is 1 or 0.
            // Solution: Use bitwise "AND" on the current number and the number that has 1 only in the third bit
            // (i.e. number 8, if bits start counting from 0). If the returned result is different from 0 the third bit is 1:
            // int num = 25; bool bit3 = (num & 8) != 0;

            // Prompt the user to enter an integer
            Console.Write("Enter an integer to check if its third bit is 1 or 0: ");
            // Read the user's input from the console and convert it to an integer
            int number = Convert.ToInt32(Console.ReadLine());

            // Use bitwise AND to check the value of the third bit (starting from the rightmost bit) of the integer
            // The binary representation of the number 4 (100 in binary) has a 1 in the third bit and 0s in all other bits
            bool thirdBitIsOne = (number & 8) != 0; // 25 - (i.e. number 8, if bits start counting from 0).
            // Print a message indicating whether the third bit (starting from the rightmost bit) of the integer is 1 or 0
            if (thirdBitIsOne)
            {
                Console.WriteLine("The third bit (starting from the rightmost bit) of {0} is 1.", number);
            }
            else
            {
                Console.WriteLine("The third bit (starting from the rightmost bit) of {0} is 0.", number);
            }
            Console.ReadKey(); Console.WriteLine();

            /* You can try with those binary numbers
            Here are 8-bit binary representations of ten numbers that have 1 only in the third bit:
            00001000 (8 in decimal)
            00011000 (24 in decimal)
            00101000 (40 in decimal)
            00111000 (56 in decimal)
            01001000 (72 in decimal)
            01011000 (88 in decimal)
            01101000 (104 in decimal)
            01111000 (120 in decimal)
            10001000 (136 in decimal)
            10011000 (152 in decimal)
            */

            Console.WriteLine("Second Method");
            // Prompt the user to enter an integer
            Console.Write("Enter an integer to check if its third bit is 1 or 0: ");
            // Read the user's input from the console and convert it to an integer
            int number1 = Convert.ToInt32(Console.ReadLine());
            // Right-shift the number by 3 bits and use a bitwise AND operator to check if the third bit is 1
            Console.WriteLine("The third bit of {0} is 1? {1}", number1, ((number1 >> 3) & 1) == 1);
        }
    }
}
