using System;

namespace Less06ForLoopSeveralVaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // For-Loop with Several Variables
            // In the construct of a for-loop we can use multiple variables at the same time. Here is an example in which we have two counters.
            // One of the counters moves up from 1 and the other moves down from 10:

            Console.WriteLine("Several Variables");
            for (int small = 1, large = 10; small < large; small++, large--)
            {
                Console.WriteLine("Small : {0}  Large : {1}", small, large);
            }
            Console.ReadLine();

            // Several Variables
            // Small: 1  Large: 10
            // Small: 2  Large: 9
            // Small: 3  Large: 8
            // Small: 4  Large: 7
            // Small: 5  Large: 6


            // Operator "Continue" - stops the current iteration of the inner loop, without terminating the loop.
            // We will calculate the sum of all odd integers in the range [1…n], which are not divisible by 7 by using the for-loop

            Console.Write("\nContinue Operator\nEnter n : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2) // we increase it by 2 in order to pass only through the odd numbers
            {
                if (i % 7 == 0)
                {
                    continue; // skips the rest of the loop’s body (it skips adding the current number to the sum)
                }
                sum += i;
            }
            Console.WriteLine("Sum = " + sum);

            // Enter n : 11
            // Sum = 29
        }
    }
}
