using System;

namespace Less00WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* While Loops
            while (condition) // the input condition is checked and if it is true, all this is repeated again and again until its returns value false.
            {
                loop body; // is the programming code executed at each iteration of the loop
            } */

            // Usage of While Loops - The purpose of the loop is to print on the console the numbers in the range from 0 to 9 in ascending order
            // Initialize the counter
            int counter = 0;
            // Execute the loop body while the loop condition holds
            while (counter <= 9)
            {
                // Print the counter value
                Console.WriteLine("Number : " + counter);
                // Increment the counter
                counter++;
            }
            Console.ReadLine();

            // Summing the Numbers from 1 to N
            // How by using the while loop we can find the sum of the numbers from 1 to n. The number n is read from the console
            Console.WriteLine("\nSumming the Numbers from 1 to N");
            Console.Write("Enter  n = ");
            int n = Int32.Parse(Console.ReadLine());
            // Initialize the variables num and sum with the value of 1
            int num = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);
            Console.ReadLine();

            // N = 17
            // The sum 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 16 + 17 = 153


            // Read the value of n from the console
            Console.Write("\nEnter a positive integer n: ");
            int number = int.Parse(Console.ReadLine());

            int summa = 0;  // Initialize the sum variable to zero
            int i = 1;      // Initialize the loop counter variable to one

            while (i <= number) // While the loop counter is less than or equal to number
            {
                summa += i;     // Add the loop counter value to the sum
                i++;            // Increment the loop counter
            }
            Console.WriteLine("The sum of the numbers from 1 to {0} is {1}.", number, summa);
        }
    }
}
