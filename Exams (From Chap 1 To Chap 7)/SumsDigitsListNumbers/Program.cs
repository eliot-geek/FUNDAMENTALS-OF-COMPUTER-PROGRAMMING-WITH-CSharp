using System.Security.AccessControl;

namespace SumsDigitsListNumbers
{
    internal class Program
    {
        // Static variables are shared across all instances of the class, meaning there is only one copy of the variable in memory.
        // The code ensures that their values are retained across multiple method calls
        // If they were not declared as static, their values would reset to zero each time the Main method is called
        // Variables to store the sums of the first and last halves of the digits
        static int right, left;

        // Function to calculate the sums of the first and last halves of the digits of a number
        static void SumOfDigits(int n)
        {
            string str = n.ToString(); // Convert the number to a string for digit extraction
            str = str.TrimStart('0'); // Remove any leading zeroes from the string representation

            int digits = str.Length; // Calculate the number of digits in the number
            if (digits > 9) 
                digits = 9; // Limit the number of digits to 9 (maximum allowed)

            // Calculate the number of digits in each half (round up if odd number of digits)
            if ((digits % 2) == 0)
            {
                digits = digits / 2; // Even number of digits, so each half has an equal number of digits
            }
            else
            {
                digits = digits / 2 + 1; // Odd number of digits, so round up to ensure the first half has one more digit
            }

            // Calculate the sum of the first half of the digits (rounded up if odd number of digits)
            for (int i = 0; i < digits; i++)
            {
                left += str[i] - '0'; // Convert the character to its integer value and add it to left
            }

            // Calculate the sum of the last half of the digits (rounded down if odd number of digits)
            for (int i = str.Length - 1; i > str.Length - digits - 1; i--)
            {
                right += str[i] - '0'; // Convert the character to its integer value and add it to right
            }
        }

        static void Main(string[] args)
        {
            #region  Sums of Digits for a List of Numbers
            /* The program is designed to calculate the sums of digits for a list of numbers. The input includes the number of rounds (representing the number of numbers 
             * to process), followed by the list of numbers to be processed. For each number, the program calculates the sum of the first half of its digits 
             * (rounded up if the number of digits is odd) and the sum of the last half of its digits (rounded down if the number of digits is odd). 
             * Then, it compares the two sums and determines the winner, or if there is a tie.
             
            Conditions:
            Input:
            rounds: The number of rounds (int type). This represents the number of numbers to be processed.
            n: An integer representing each number to be processed.
            
            Number Calculation:
            The program takes each number and converts it to a string representation (str = n.ToString()).
            It then removes any leading zeroes from the string representation of the number (str = str.TrimStart('0')).
            It calculates the number of digits in the number (digits = str.Length).
            If the number of digits is greater than 9, it limits the number of digits to 9 (if (digits > 9) digits = 9).
            It calculates the sum of the first half of the digits (rounded up if the number of digits is odd) and stores it in the variable left.
            It calculates the sum of the last half of the digits (rounded down if the number of digits is odd) and stores it in the variable right.
            
            Output:
            After processing all the numbers, the program compares the sums left and right.
            If right is greater than left, it prints "right" followed by the difference between right and left.
            If left is greater than right, it prints "left" followed by the difference between left and right.
            If right and left are equal (a tie), it prints "No" followed by the sum of right and left.*/
            #endregion


            // Read the number of rounds (number of numbers to process)
            Console.Write("Enter the number of rounds (number of numbers to process): ");
            int rounds;
            if (!int.TryParse(Console.ReadLine(), out rounds))
            {
                Console.WriteLine("Invalid input for rounds. Please enter a valid integer.");
                return;
            }

            // Process each number and calculate the sums of the first and last halves of the digits
            for (int i = 0; i < rounds; i++)
            {
                int n;
                Console.Write("Enter the integers representing each number to be processed: ");
                if (!int.TryParse(Console.ReadLine(),out n))
                {
                    Console.WriteLine("Invalid input for rounds. Please enter a valid integer.");
                    return;
                }
                SumOfDigits(n);
            }

            // Compare the sums and determine the winner or if there's a tie and Print followed by the difference between them
            if (right > left)
            {
                Console.WriteLine("Right " + (right - left));
            }
            else if (left > right)
            {
                Console.WriteLine("Left " + (left - right));
            }
            else
            {
                Console.WriteLine("No " + (right + left));
            }
        }
    }
}