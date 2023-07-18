namespace TrippleDigitRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tripple Digit Rotation
            /*  Task: The task is to rotate the digits of a three-digit integer and print the result.
            Conditions:
            The program takes an integer 'num' as input, which represents a three-digit number (100 to 999).
            The program rotates the digits of 'num' and removes any leading zeros in the resulting number.
            If 'num' is between 10 and 99 (inclusive), the program should print the digits in reverse order.
            If 'num' is between 100 and 999 (inclusive), the program should remove leading zeros and print the digits in the order of the non-zero digits.
            The program should handle leading zeros correctly and print each digit on a new line if there are more than one non-zero digit.  */
            #endregion

            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine()); // Read the input integer from the user

            int n = num;
            int[] array = new int[3];

            // Extract the individual digits of the number and store them in an array
            for (int i = 0; i < 3; i++)
            {
                int lastdigit = num % 10;
                num /= 10;

                if (lastdigit == 0)
                {
                    continue; // Skip leading zeros and store non-zero digits in the array
                }
                array[i] = lastdigit;
            }

            if (n > 9 && n < 100)
            {
                // If the number is between 10 and 99 (inclusive), print the digits in reverse order
                for (int i = 0; i <= 1; i++)
                {
                    Console.Write(array[i]);
                }
            }
            else
            {
                // If the number is between 100 and 999 (inclusive)
                for (int i = 2; i >= 0; i--)
                {
                    if (array[i] == 0)
                    {
                        continue; // Skip leading zeros in the reversed order
                    }
                    Console.Write(array[i]);
                    if (i == 0 && num == 0)
                    {
                        Console.WriteLine(); // Print a new line if the last digit is printed and there is no leading zero left
                    }
                }

                if (num != 0)
                {
                    Console.WriteLine(num); // Print the remaining leading zero or non-zero digit
                }
            }
        }
    }
}