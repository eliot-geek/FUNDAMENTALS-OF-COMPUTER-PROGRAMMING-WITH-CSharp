using System;

namespace Ex07GreatestOfGivenFivNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the greatest of given 5 numbers.
            // Use nested if statements.You could use the loop structure for, which you could read about in the “Loops” chapter of the book or in Internet.

            // Prompt user to enter first number and parse it as an integer
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            // Prompt user to enter second number and parse it as an integer
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            // Prompt user to enter third number and parse it as an integer
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());
            // Prompt user to enter fourth number and parse it as an integer
            Console.Write("Enter fourth number: ");
            int d = Int32.Parse(Console.ReadLine());
            // Prompt user to enter fifth number and parse it as an integer
            Console.Write("Enter fifth number: ");
            int e = Int32.Parse(Console.ReadLine());

            // Nested if statements to compare each number with the current maximum
            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            // Output the maximum value to the console
            Console.WriteLine("\n{0} is the biggest number.", a);
            Console.ReadKey();


            Console.WriteLine("\nAnother Solution");
            // create an integer array of size 5 to hold the user's input.
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            // initialize a variable called max to the first element in the array (numbers[0])
            int max = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("The greatest number is: " + max);
            Console.ReadKey();


            Console.WriteLine("\nAnother Solution");
            int maximum, num;
            // prompt the user to enter the first number,
            Console.Write("Enter the first number: ");
            maximum = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num = int.Parse(Console.ReadLine());
            // We use a nested if statement to compare num with maximum, and if num is greater than maximum, we update maximum to the new value.
            // We repeat the same process for the third, fourth, and fifth numbers
            if (num > maximum)
            {
                maximum = num;
            }

            Console.Write("Enter the third number: ");
            num = int.Parse(Console.ReadLine());
            if (num > maximum)
            {
                maximum = num;
            }

            Console.Write("Enter the fourth number: ");
            num = int.Parse(Console.ReadLine());
            if (num > maximum)
            {
                maximum = num;
            }

            Console.Write("Enter the fifth number: ");
            num = int.Parse(Console.ReadLine());
            if (num > maximum)
            {
                maximum = num;
            }
            Console.WriteLine("The greatest number is: " + maximum);
            Console.ReadKey();
        }
    }
}
