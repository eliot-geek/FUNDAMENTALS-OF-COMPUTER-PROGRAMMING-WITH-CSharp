using System;

namespace Ex05FibonacciSequenceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 5
            // Write a program that reads from the console number N and print the sum  of the first N members of
            // the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,13, 21, 34, 55, 89, 144, 233, 377, …
            // Guide: Fibonacci numbers start from 0 and 1, each additional is obtained as the sum of the previous two. You can find the first n Fibonacci
            // numbers with a for-loop from 1 to n, and at each iteration calculate the next number by using the previous two
            // (which you will keep in two additional variables).
            #endregion

            Console.Write("Enter the value of N: ");            // prompts the user to enter the value of N
            int fibonacci = Int32.Parse(Console.ReadLine());    // reads the value of N from the console and parses it to an integer, then assigns it to the variable fibonacci
            int first = 0;      // initializes the first number of the Fibonacci sequence to 0
            int second = 1;     // initializes the second number of the Fibonacci sequence to 1
            int sum = 0;        // initializes the sum of the previous two numbers to 0
            int summ = first + second;
            Console.Write("0, 1,");     // writes the first two numbers of the Fibonacci sequence
            for (int i = 2; i < fibonacci; i++)     // iterates through the remaining numbers of the Fibonacci sequence
            {
                sum = first + second;           // calculates the sum of the previous two numbers
                summ += sum;
                Console.Write(" {0},", sum);    // writes the sum to the console with a comma and space
                first = second;                 // updates the first number to the previous second number
                second = sum;                   // updates the second number to the previous sum
            }
            Console.Write(" ...."); // writes an ellipsis to indicate that the sequence continues
            Console.WriteLine("\nThe sum of the first " + fibonacci + " Fibonacci numbers is " + summ); // print the sum
            Console.ReadLine();     // waits for the user to press Enter before closing the console



            Console.WriteLine("\nSolution 2");
            Console.Write("Enter the value of N: ");
            int n = int.Parse(Console.ReadLine());      // read N from the console
            int fib1 = 0;               // initialize the first Fibonacci number
            int fib2 = 1;               // initialize the second Fibonacci number
            int summa = fib1 + fib2;    // initialize the sum to the value of the first two numbers
            for (int i = 3; i <= n; i++)
            { 
                // iterate from 3 to n, since we already have the sum of the first two numbers
                int fib3 = fib1 + fib2;     // calculate the next Fibonacci number
                summa += fib3;              // add the next Fibonacci number to the sum
                fib1 = fib2;                // update fib1 to the previous value of fib2
                fib2 = fib3;                // update fib2 to the previous value of fib3
            }
            Console.WriteLine("The sum of the first " + n + " Fibonacci numbers is " + summa); // print the sum
        }
    }
}
