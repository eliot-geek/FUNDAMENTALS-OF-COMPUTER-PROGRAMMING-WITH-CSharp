using System;

namespace Ex_03_Check_Third_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that looks for a given integer if its third digit (right to left) is 7.
            // Solution : Divide the number by 100 and save it in a new variable, which then divide by 10 and take the remainder.
            // The remainder of the division by 10 is the third digit of the original number. Check if it is equal to 7.

            // Prompt the user to enter an integer
            Console.Write("Enter an integer to check if its third digit is 7: ");
            // Read the user's input from the console and convert it to an integer
            int integer = Convert.ToInt32(Console.ReadLine());
            // Check whether the third digit (right to left) of the integer is 7
            bool thirdDigitIsSeven = (integer / 100) % 10 == 7;
            // Print a message indicating whether the third digit (right to left) of the integer is 7
            if (thirdDigitIsSeven)
            {
                Console.WriteLine("The third digit (right to left) of {0} is 7", integer);
            }
            else
            {
                Console.WriteLine("The third digit (right to left) of {0} is not 7", integer);
            }
            Console.ReadKey(); Console.WriteLine();


            Console.WriteLine("Second Method");
            // Prompt the user to enter an integer
            Console.Write("Enter an integer to check if its third digit is 7: ");
            // Read the user's input from the console and convert it to an integer
            int number = Convert.ToInt32(Console.ReadLine());
            bool isSeven = (number / 100) % 10 == 7 ? true : false;
            Console.WriteLine("The third digit of {0} is 7", number, isSeven);
            Console.ReadKey(); Console.WriteLine();
        }
    }
}
