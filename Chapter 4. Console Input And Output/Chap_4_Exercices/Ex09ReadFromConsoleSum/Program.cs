using System;

namespace Ex09ReadFromConsoleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
            Guide: You should use a for-loop (see the chapter "Loops"). Read the numbers one after another and 
            accumulate their sum in a variable, which then display on the console at the end.*/

            Console.WriteLine("Solution 1");
            Console.Write("Enter the length : ");
            // read from the console
            int length = Int32.Parse(Console.ReadLine());
            // initialize the sum to 0
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number {0} : ", i + 1);
                // read each number from the console and add the number to the sum
                sum += Int32.Parse(Console.ReadLine());
            }
            // print the sum to the console
            Console.WriteLine("Sum of all numbers is {0} : ", sum);
            Console.WriteLine(); Console.ReadKey();


            Console.WriteLine("Solution 2");
            Console.Write("Enter the number of intergers you want to sum: ");
            // read from the console
            int n = int.Parse(Console.ReadLine()); 
            // initialize the summ to 0
            int summ = 0;

            for(int i = 0;i < n; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                // read each number from the console
                int number = int.Parse(Console.ReadLine());
                // add the number to the summ
                summ += number; 
            }
            // print the summ to the console
            Console.WriteLine("The summ of the numbers is: {0}", summ);
        }
    }
}
