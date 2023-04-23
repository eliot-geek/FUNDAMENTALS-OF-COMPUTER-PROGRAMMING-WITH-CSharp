using Microsoft.VisualBasic;
using System;

namespace Less01CheckIfNumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check If a Number Is Prime - Program to check whether a given number is prime or not
            // A prime number is any positive integer number, which, is not divisible by any other numbers except 1 and itself


            Console.Write("Enter a positive number : ");
            int num = Int32.Parse(Console.ReadLine());
            // The variable 'divider' is initialized to 2, which is the smallest prime number
            int divider = 2;

            // The variable 'maxDivider' is calculated as the square root of the input number, which is the maximum possible value of a divisor
            // If we have a divisor bigger than √num, then num should also have another divisor smaller than √num and that’s why it’s useless to check
            // the numbers bigger than √num.This way we reduce the number of loop iterations.
            int maxDivider = (int)Math.Sqrt(num);
            
            // The variable 'prime' is set to true by default, assuming the number is prime
            bool prime = true;

            // A while loop is used to check the divisibility of the input number by each number from 2 to 'maxDivider'
            while (prime && (divider <= maxDivider))
            {
                // If the input number is divisible by the current divider, it is not prime and 'prime' is set to false
                if (num % divider == 0)
                {
                    prime = false;
                }
                // The 'divider' is incremented by 1 to check the next possible divisor
                divider++;
            }
            // Finally, the maximum possible divisor and the primality of the input number are printed to the console
            Console.WriteLine("MaxDivider : " + maxDivider);
            Console.WriteLine("Prime ? " + prime);
            Console.ReadLine();



            Console.Write("Enter a positive number: ");
            int numb = int.Parse(Console.ReadLine());
            bool isPrime = true;    // Assume the number is prime initially
            if (numb < 2)    // If the number is less than 2, it is not prime
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numb); i++)    // Check divisibility of the number by all numbers from 2 to its square root
                {
                    if (numb % i == 0)    // If the number is divisible by any number other than 1 and itself, it is not prime
                    {
                        isPrime = false;
                        break;    // Exit the loop as soon as the number is found to be composite
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{numb} is a prime number.");    // If the number is prime, print a message indicating so
            }
            else
            {
                Console.WriteLine($"{numb} is not a prime number.");    // If the number is composite, print a message indicating so
            }
            Console.ReadLine();    // Wait for user input before exiting


            // Some test
            int bb = 117;
            for (int a = 1; a < bb; a++)
            {
                if (bb % a == 0)
                {
                    Console.WriteLine($"The number is {a}");
                }
            }

            // Operator "break"
            // The break operator is used for prematurely exiting the loop, before it has completed its execution in a natural way.
            // When the loop reaches the break operator it is terminated and the program’s execution continues from the line immediately after the loop’s body.
            // A loop’s termination with the break operator can only be done from its body, during an iteration of the loop.
            // When break is executed the code in the loop’s body after it is skipped and not executed.
        }
    }
}
