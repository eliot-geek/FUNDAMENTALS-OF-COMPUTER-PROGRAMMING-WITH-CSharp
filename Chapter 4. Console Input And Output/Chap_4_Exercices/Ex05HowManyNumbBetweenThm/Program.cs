using System;

namespace Ex05HowManyNumbBetweenThm
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that 
            the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
            Guide : There are two approaches for solving the problem:
            First approach: Use mathematical tricks for optimized calculation based on the fact that every fifth number is divisible by 5. 
            Think how to implement this correctly and about the borderline cases.
            The second approach is easier but it works slower. With a for-loop each number within the given range can be checked. 
            You should read in Internet or in the chapter "Loops" how to use for-loops.*/


            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            // Read the user input as a string, parse it to an integer, and store it in the variable firstNum
            int firstNum = Int32.Parse(Console.ReadLine());
            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            // Read the user input as a string, parse it to an integer, and store it in the variable secondNum
            int secondNum = Int32.Parse(Console.ReadLine());
            
            // Declare and initialize a variable named count to 0
            int count = 0;
            // Use a for loop to iterate over all the numbers between firstNum and secondNum, inclusive
            for (int i = firstNum; i <= secondNum; i++)
            {
                // Check whether the current number is divisible by 5 using the modulus operator %
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    // If the current number is divisible by 5, increment the count variable by 1
                    count++;
                }
            }
            // Print the result by using Console.WriteLine() to display a message that includes firstNum, secondNum, and count
            Console.WriteLine("\nThere are {0} numbers between {1} and {2}.", count, firstNum, secondNum);
        }
    }
}
