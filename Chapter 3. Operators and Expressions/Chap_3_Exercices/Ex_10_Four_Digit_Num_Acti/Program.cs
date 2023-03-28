using System;

namespace Ex_10_Four_Digit_Num_Acti
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
            - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            - Prints on the console the number in reversed order: dcba (in our example 1102).
            - Puts the last digit in the first position: dabc (in our example 1201).
            - Exchanges the second and the third digits: acbd (in our example 2101).
            
            Solution: To get the individual digits of the number you can divide by 10 and take the remainder of the division by 10:
            int a = num % 10; 
            int b = (num / 10) % 10; 
            int c = (num / 100) % 10; 
            int d = (num / 1000) % 10;*/

            // Ask the user to enter a four-digit number
            Console.Write("Enter a four digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Check if the input is a valid four-digit number
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Invalid input. The number must be a four-digit number.");
                return;
            }
            // Extract each digit from the input number
            int first = (number / 1000) % 10;
            int second = (number / 100) % 10;
            int third = (number / 10) % 10;
            int fourth = number % 10;
            // Print the extracted digits and the sum of the digits
            Console.WriteLine("First digit: {0}, Second digit: {1}, Third digit: {2}, Fourth digit: {3}", first, second, third, fourth);
            Console.WriteLine($"Sum of the digits: {first} + {second} + {third} + {fourth} = {first + second + third + fourth}");
            // Print the number in reversed order, with the last digit in the first position, and with the second and third digits swapped
            Console.WriteLine("Number in reversed order: {3}{2}{1}{0}", first, second, third, fourth);
            Console.WriteLine("Last digit in the first position: {3}{0}{1}{2}", first, second, third, fourth);
            Console.WriteLine("Second and third digits swapped: {0}{2}{1}{3}", first, second, third, fourth);
            Console.ReadKey();
        } 
    }
}
