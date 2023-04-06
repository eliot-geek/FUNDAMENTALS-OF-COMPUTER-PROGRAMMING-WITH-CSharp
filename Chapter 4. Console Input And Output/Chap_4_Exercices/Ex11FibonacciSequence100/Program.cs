using System;

namespace Ex11FibonacciSequence100
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            Guide : More about the Fibonacci sequence can be found in Wikipedia at: http://en.wikipedia.org/wiki/Fibonacci_sequence. 
            For the solution of the problem use 2 temporary variables in which store the last 2 calculated values and with a loop calculate the rest 
            (each subsequent number in the sequence is a sum of the last two). Use a for-loop to implement the repeating logic (see the chapter "Loops").*/

            Console.Write("The first 100 numbers in the Fibonacci sequence are : ");
            // initialize the first two Fibonacci numbers
            decimal firstNumb = 0;
            decimal secondNumb = 1;
            // print the first two Fibonacci numbers to the console
            Console.Write("{0}, {1}, ", firstNumb, secondNumb);

            //  initializes a variable 'count' to 0
            int count = 0;
            // Calculate and print the remaining numbers
            for (int i = 0; count < 100; i++)
            {
                // calculate the next Fibonacci number
                decimal sum = firstNumb + secondNumb;
                // print the next Fibonacci number
                Console.Write("{0}, ", sum);
                // shift the variables to prepare for the next iteration 
                firstNumb = secondNumb;
                secondNumb = sum;
                // 'count' is incremented by 1 at the end of each iteration of the loop
                count++;
            }
            // display the value of the variable 'count'
            Console.WriteLine($"\nCount : {count}");
            Console.ReadKey();

        }
    }
}
