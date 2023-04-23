using System;

namespace Less09PrimeNumberInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prime Numbers in an Interval
            // We set a goal to print on the console all prime number in the interval [n…m]

            Console.Write("Enter n : ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter m : ");
            int m = Int32.Parse(Console.ReadLine());

            // Starts a for loop that will iterate through all integers from 'n' to 'm', inclusive
            for (int num = n; num <= m; num++)
            {
                // Initializes the boolean variable 'prime' to true
                bool prime = true;
                // Initializes the integer variable 'divider' to 2, the first possible divisor of the current number being checked
                int divider = 2;
                // Initializes the integer variable 'maxDivider' to the square root of the current number being checked
                int maxDivider = (int)Math.Sqrt(num);
                // Starts a while loop that will check if the current number is prime by checking if it is divisible by any integers between 2 and its square root
                while (divider <= maxDivider)
                {
                    // This line checks if the current number is divisible by the current divider, and if it is, sets the boolean variable 'prime' to false and exits the loop
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    // This line increments the 'divider' variable to check the next possible divisor
                    divider++;
                }
                // This line checks if the 'prime' variable is still true, indicating that no divisors were found and that the number is prime, and if it is, prints the number to the console
                if (prime)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();

            // Enter n : 2
            // Enter m : 100
            // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97
        }
    }
}
