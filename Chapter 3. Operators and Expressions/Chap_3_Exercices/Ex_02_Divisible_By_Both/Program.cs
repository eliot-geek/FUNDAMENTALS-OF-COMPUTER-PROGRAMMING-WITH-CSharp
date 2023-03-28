using System;

namespace Ex_02_Divisible_By_Both
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
            // Solution : Use a logical "AND" (&& operator) and the remainder operation % in division. You can also solve the problem by
            // only one test: the division of 35 (think why).

            // Prompt the user to enter an integer
            Console.Write("Enter an integer to check if it is divisible by both 5 and 7: ");
            // Read the user's input from the console and convert it to an integer
            int integer = Convert.ToInt32(Console.ReadLine());
            // Check whether the integer is divisible by both 5 and 7, without a remainder
            bool divisibleByFiveAndSeven = (integer % 5 == 0) && (integer % 7 == 0);
            // Print a message indicating whether the integer is divisible by both 5 and 7, without a remainder
            if (divisibleByFiveAndSeven)
            {
                Console.WriteLine("{0} is divisible by both 5 and 7, without a remainder", integer);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by both 5 and 7, without a remainder", integer);
            }
            Console.ReadKey(); Console.WriteLine();


            Console.WriteLine("Second Method");
            // Prompt the user to enter an integer
            Console.Write("Enter an integer to check if it is divisible by both 5 and 7: ");
            // Read the user's input from the console and convert it to an integer
            int number = Convert.ToInt32(Console.ReadLine());
            bool divisible = number % 35 == 0 ? true : false;
            Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number, divisible);
            Console.ReadKey(); Console.WriteLine();


            // You can also solve the problem by only one test: the division of 35 (think why).
            // Check whether the integer is divisible by both 5 and 7, without a remainder, using one test
            // bool divisibleByFiveAndSeven = integer % 35 == 0;
        }
    }
}
