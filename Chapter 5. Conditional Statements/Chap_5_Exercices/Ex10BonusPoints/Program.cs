using System;

namespace Ex10BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
            // - If the score is between 1 and 3, the program multiplies it by 10.
            // - If the score is between 4 and 6, the program multiplies it by 100.
            // - If the score is between 7 and 9, the program multiplies it by 1000.
            // - If the score is 0 or more than 9, the program prints an error message.
            // Guide: Use switch statement or a sequence of if-else constructs and at the end print at the console the calculated points.

            // read in the score from the user
            Console.Write("Enter a score between 1 and 9: ");
            int score = int.Parse(Console.ReadLine());

            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Bonus will be multiply by 10 : " + score * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Bonus will be multiply by 100 : " + score * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Bonus will be multiply by 1000 : " + score * 1000);
                    break;
                default:
                    Console.WriteLine("Error message.");
                    break;
            }
            Console.ReadKey();


            // Write a message to the console to indicate that we are using the second method
            Console.WriteLine("\nSecond Method");
            // Prompt the user to enter a number between 1 and 9
            Console.Write("Enter points between 1 and 9: ");
            // Read in the number entered by the user and convert it to an integer
            int points = Convert.ToInt32(Console.ReadLine());

            // Use if-else statements to determine how to calculate the bonus points based on the number entered by the user
            if (points >= 1 && points <= 3)
            {
                // If the number is between 1 and 3, multiply it by 10
                Console.WriteLine("Points multiplied by 10 : {0}", points * 10);
            }
            else if (points >= 4 && points <= 6)
            {
                // If the number is between 4 and 6, multiply it by 100
                Console.WriteLine("Points multiplied by 100 : {0}", points * 100);
            }
            else if (points >= 7 && points <= 9)
            {
                // If the number is between 7 and 9, multiply it by 1000
                Console.WriteLine("Points multiplied by 1000 : {0}", points * 1000);
            }
            else
            {
                // If the number is less than 1 or greater than 9, display an error message
                Console.WriteLine("Error message.");
            }
            // Wait for the user to press enter before closing the console window
            Console.ReadLine();
        }
    }
}
