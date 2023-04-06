using System;

namespace Ex08PrintTheGreatestNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads five numbers from the console and prints the greatest of them.
            Guide: You can use the comparison statement "if" (you can read about it on the Internet or from the chapter "Conditional Statements"). 
            To avoid repeating code you can use the looping construct "for" (you could read about it online or in the chapter "Loops"). */

            Console.WriteLine("Solution 2");
            Console.Write("Enter first : ");
            int first = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second : ");
            int second = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third : ");
            int third = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth : ");
            int fourth = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth : ");
            int fifth = Int32.Parse(Console.ReadLine());

            if (first > second && first > third && first > fourth && first > fifth) Console.WriteLine("The number {0} is the biggest.", first);
            else if (second > first && second > third && first > fourth && second > fifth) Console.WriteLine("The number {0} is the biggest.", second);
            else if (third > first && third > second && third > fourth && third > fifth) Console.WriteLine("The number {0} is the biggest.", third);
            else if (fourth > first && fourth > second && fourth > third && fourth > fifth) Console.WriteLine("The number {0} is the biggest.", fourth);
            else if (fifth > first && fifth > second && fifth > third && fifth > fourth) Console.WriteLine("The number {0} is the biggest.", fifth);
            else Console.WriteLine("There is not a biggest number.");
            Console.WriteLine(); Console.ReadKey();


            Console.WriteLine("Solution 2");
            // create an integer array to store the five numbers
            int[] numbers = new int[5];
            // create a variable to store the greatest number, initialized to 0
            int maxNumber = 0;
            // use a for loop to read in the five numbers from the console
            for (int i = 0; i < numbers.Length; i++)
            {
                // prompt the user to enter the i-th number
                Console.Write("Enter number {0}: ", i + 1);
                // read in the number as a string and convert it to an integer
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            // use a foreach loop to iterate through the numbers array
            foreach (int number in numbers)
            {
                // compare each number with the current maxNumber
                if (number > maxNumber)
                {
                    // if the current number is greater, update maxNumber
                    maxNumber = number;
                }
            }
            // print out the maxNumber as the greatest number
            Console.WriteLine("The greatest number is: {0}", maxNumber);
        }
    }
}
