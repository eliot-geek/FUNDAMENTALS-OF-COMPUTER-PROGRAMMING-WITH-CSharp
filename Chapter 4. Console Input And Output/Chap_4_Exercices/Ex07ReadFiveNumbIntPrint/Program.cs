using System;
using System.Reflection.Metadata;

namespace Ex07ReadFiveNumbIntPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads five integer numbers and prints their sum. 
             * If an invalid number is entered the program should prompt the user to enter another number.
            
            Guide: You can read the numbers in five different variables and finally sum them and print the obtained sum. 
            Note that the sum of 5 int values may not fit in the int type so you should use long. 
            Another approach is using loops. When parsing the consecutive numbers use conditional parsing with TryParse(…). 
            When an invalid number is entered, repeat reading of the number. You can do this through while loop with an appropriate exit condition. 
            To avoid repetitive code you can explore the for-loops from the chapter "Loops".*/

            Console.WriteLine("Solution 1");
            int first, second, third, fourth, five;
            bool tryParseSuccess = false;

            // The do-while loop is used to repeatedly prompt the user for input until they enter a valid integer value that can be parsed into an int.
            // If tryParseSuccess is false (i.e., parsing was unsuccessful), the loop will repeat and prompt the user to enter another value until
            // tryParseSuccess is true (i.e., parsing was successful).
            do
            {
                Console.Write("Enter first : ");
                // TryParse is a method that allows you to attempt to parse a string representation of a value into a numeric type, such as int, double, or decimal.
                // It takes two parameters: the string to parse, and an out parameter that will contain the parsed value if parsing is successful.It returns a Boolean value indicating whether parsing was successful or not.
                tryParseSuccess = Int32.TryParse(Console.ReadLine(), out first);    
                Console.WriteLine(tryParseSuccess);
            } while (!tryParseSuccess); 

            do
            {
                Console.Write("Enter second : ");
                tryParseSuccess = Int32.TryParse(Console.ReadLine(), out second);
                Console.WriteLine(tryParseSuccess);
            } while (!tryParseSuccess);

            do
            {
                Console.Write("Enter third : ");
                tryParseSuccess = Int32.TryParse(Console.ReadLine(), out third);
                Console.WriteLine(tryParseSuccess);
            } while (!tryParseSuccess);

            do
            {
                Console.Write("Enter fourth : ");
                tryParseSuccess = Int32.TryParse(Console.ReadLine(), out fourth);
                Console.WriteLine(tryParseSuccess);
            } while (!tryParseSuccess);

            do
            {
                Console.Write("Enter five : ");
                tryParseSuccess = Int32.TryParse(Console.ReadLine(), out five);
                Console.WriteLine(tryParseSuccess);
            } while (!tryParseSuccess);

            long sum = first + second + third + fourth + five;
            Console.WriteLine("Sum of the five integer numbers is : {0}", sum);
            Console.WriteLine(); Console.ReadKey();



            Console.WriteLine("Solution 2");
            // variable to store the sum of the numbers
            long summa = 0;
            int num = 0;
            // variable to keep track of the number of valid numbers entered
            int count = 0;

            while (count < 5)
            {
                Console.Write("Enter an integer number: ");
                // try to parse user input as an integer
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    // if successful, add the number to the sum
                    summa += num;
                    // increment the count of valid numbers entered
                    count++;
                }
                else
                {
                    // if unsuccessful, display an error message
                    Console.WriteLine("Invalid number. Please enter a valid integer number."); 
                }
            }
            // display the sum of the five numbers using an interpolated string
            Console.WriteLine($"The sum of the five numbers is {summa}.");
            Console.WriteLine(); Console.ReadKey();



            Console.WriteLine("Solution 3");
            // number of integers to read
            const int numCount = 5;
            // variable to store the sum of the numbers
            long summ = 0; 

            // read each integer number and add it to the sum
            for (int i = 0; i < numCount; i++)
            {
                // variable to store the number entered by the user
                int numb = 0;
                // flag to indicate whether the user has entered a valid number
                bool validInput = false; 

                // continue reading numbers until the user enters a valid number
                while (!validInput)
                {
                    Console.Write($"Enter integer number {i + 1}: ");
                    // try to parse user input as an integer
                    if (int.TryParse(Console.ReadLine(), out numb)) 
                    {
                        // set flag to true if successful
                        validInput = true; 
                    }
                    else
                    {
                        // if unsuccessful, display an error message
                        Console.WriteLine("Invalid number. Please enter a valid integer number."); 
                    }
                }
                // add the valid number to the sum
                summ += numb; 
            }
            // display the sum of the five numbers using an interpolated string
            Console.WriteLine($"The sum of the five numbers is {summ}."); 
            Console.ReadLine(); // wait for user to press Enter before exiting
        }
    }
}
