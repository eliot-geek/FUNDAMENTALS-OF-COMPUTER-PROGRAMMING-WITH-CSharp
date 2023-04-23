using System;

namespace Less03DoWhileLoopFactoria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do-While Loops - The do-while loop is similar to the while loop, but it checks the condition after each execution of its loop body.
            // do
            // {
            //     executable code;
            // } while (condition);

            // Initially the loop body is executed. Then its condition is checked. If it is true, the loop’s body is repeated, otherwise the loop ends.
            // This logic is repeated until the condition of the loop is broken. The body of the loop is executed at least once.
            // If the loop’s condition is constantly true, the loop never ends.

            // Calculating Factorial – Example
            // At the beginning we start with a result of 1 and multiply consecutively the result at each iteration by n, and reduce n by one unit, until n reaches 0.
            // This gives us the product n*(n-1)*…*1. 
            // This algorithm always performs at least one multiplication and that’s why it will not work properly when n ≤ 0.

            Console.Write("Enter n : ");
            int n = Int32.Parse(Console.ReadLine());
            decimal factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("n! = " + factorial);
            Console.ReadLine();

            // Enter n : 7
            // n! = 5040
        }
    }
}
