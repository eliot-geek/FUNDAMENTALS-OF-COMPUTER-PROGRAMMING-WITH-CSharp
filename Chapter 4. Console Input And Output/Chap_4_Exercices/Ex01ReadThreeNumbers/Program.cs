using System;

namespace Ex01ReadThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads from the console three numbers of type int and prints their sum.
             Guide: Use the methods Console.ReadLine() and Int32.Parse(). */

            // // Prompt the user to enter the first number and read in the input as a string
            Console.Write("Enter the first number: ");
            // Convert the first input string to an integer
            int first = Int32.Parse(Console.ReadLine());
            // Prompt the user to enter the second number and read in the input as a string
            Console.Write("Enter the second number: ");
            // Convert the second input string to an integer
            int second = Int32.Parse(Console.ReadLine());
            // Prompt the user to enter the third number and read in the input as a string
            Console.Write("Enter the third number: ");
            // Convert the third input string to an integer
            int third = Int32.Parse(Console.ReadLine());
            // Calculate the sum of the three numbers and print the sum of the three numbers to the console
            Console.WriteLine("Sum of the three numbers is : {0}", first + second + third);

            Console.ReadKey();
            Console.WriteLine("Please enter three numbers:");
            // read input from user
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            // convert strings to integers
            int num1 = Int32.Parse(input1);
            int num2 = Int32.Parse(input2);
            int num3 = Int32.Parse(input3);
            // calculate sum
            int sum = num1 + num2 + num3;
            // print sum to console
            Console.WriteLine("The sum of the three numbers is: " + sum);
        }
    }
}
