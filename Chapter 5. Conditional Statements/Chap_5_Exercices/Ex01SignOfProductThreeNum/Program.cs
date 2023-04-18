using System;

namespace Ex02SignOfProductThreeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
            // Guide : A multiple of non-zero numbers has a positive product, if the negative multiples are even number.
            // If the count of the negative numbers is odd, the product is negative. If at least one of the numbers
            // is zero, the product is also zero. Use a counter negativeNumbersCount to keep the number of negative
            // numbers. Check each number whether it is negative and change the counter accordingly. If some of the
            // numbers is 0, print “0” as result (the zero has no sign). Otherwise print “+” or “-” depending on the
            // condition (negativeNumbersCount % 2 == 0).

            // Promt user to enter three real numbers
            Console.WriteLine("Main Method");
            Console.WriteLine("Enter three real numbers: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            int negativeNumbersCount = 0;

            // Check each number whether it is negative and increment the counter accordingly
            if (num1 < 0) negativeNumbersCount++;
            if (num2 < 0) negativeNumbersCount++;
            if (num3 < 0) negativeNumbersCount++;

            // If at least one of the numbers is zero, the product is also zero
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                // A multiple of non-zero numbers has a positive product, if the negative multiples are even number
                if (negativeNumbersCount % 2 == 0) 
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            Console.ReadKey();


            // First Method
            // Prompt the user to input three real numbers and store them in variables
            Console.WriteLine("\nFirst Method");
            Console.Write("Enter first real number : ");
            double first = Double.Parse(Console.ReadLine());
            Console.Write("Enter second real number : ");
            double second = Double.Parse(Console.ReadLine());
            Console.Write("Enter third real number : ");
            double third = Double.Parse(Console.ReadLine());

            // Check the signs of the three numbers and output the result accordingly
            if ((first < 0 && second > 0 && third > 0) || (second < 0 && first > 0 && third > 0) || (third < 0 && first > 0 && second > 0) || (first < 0 && second < 0 && third < 0))
            {
                Console.WriteLine("The sign is -");
            }
            else if ((first < 0 && second < 0 && third > 0) || (first < 0 && third < 0 && second > 0) || (second < 0 && third < 0 && first > 0) || (first > 0 && second > 0 && third > 0))
            {
                Console.WriteLine("The sign +");
            }
            else if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("It's 0");
            }
            // Wait for the user to press a key before closing the console window
            Console.ReadKey();


            // Second Method 
            // Prompt the user to enter three real numbers and store them in variables a, b, and c
            Console.WriteLine("\nSecond Method");
            Console.Write("Enter a real number : ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Enter b real number : ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Enter c real number : ");
            double c = Double.Parse(Console.ReadLine());

            // Check the signs of the input numbers and print a corresponding string
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadKey();


            // Third Method
            // Prompt user to enter three decimal numbers
            Console.WriteLine("\nThird Method");
            Console.Write("Enter the first number : ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the third number : ");
            decimal thirdNum = decimal.Parse(Console.ReadLine());

            // Check if any of the entered numbers is zero
            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                Console.WriteLine("At least one of the entered numbers is zero so the product of the numbers will be 0!");
            }
            else if ((firstNum > 0 && secondNum > 0 && thirdNum > 0) || (firstNum > 0 && secondNum < 0 && thirdNum < 0) || (firstNum < 0 && secondNum < 0 && thirdNum > 0) || (firstNum < 0 && secondNum > 0 && thirdNum < 0))
            {
                // If none of the entered numbers is zero, check the sign of the product based on the number of negative numbers entered
                Console.WriteLine("The sign of the product of the three numbers: ({0}) * ({1}) * ({2}) is PLUS (+)!", firstNum, secondNum, thirdNum);
            }
            else
            {
                // If none of the entered numbers is zero, check the sign of the product based on the number of negative numbers entered
                Console.WriteLine("The sign of the product of the three numbers: ({0}) * ({1}) * ({2}) is MINUS (-)!", firstNum, secondNum, thirdNum);
            }
        }
    }
}
