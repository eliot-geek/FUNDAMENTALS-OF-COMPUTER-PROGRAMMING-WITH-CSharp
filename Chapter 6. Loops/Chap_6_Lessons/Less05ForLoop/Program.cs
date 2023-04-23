using Microsoft.VisualBasic;
using System;

namespace Less05ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loops - For-loops are a slightly more complicated than while and do-while loops but on the other hand they can solve more complicated tasks with less code.
            // They contain an initialization block (A), condition (B), body (D) and updating commands for the loop variables (C).

            // for (initialization; condition; update)
            // {
            //     loop's body;
            // }  

            // It consists of an initialization part for the counter (in the pattern int i = 0), a Boolean condition (i < 10),
            // an expression for updating the counter (i++, it might be i-- or for instance, i = i + 3) and body of the loop.

            // Since none of the listed elements of the for-loops is mandatory, we can skip them all and we will get an infinite loop
            // for (; ; )
            // {
            //     // Loop body
            // }

            // Initialization - Condition - Update

            Console.WriteLine("For Loop");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            // Result
            // 0 1 2 3 4 5 6 7 8 9 10

            // We have two variables i and sum, that initially have the value of 1, but we update them consecutively at each iteration of the loop
            Console.WriteLine("\n\nAnother For Loop");
            for (int i = 1, sum = 1; i <= 128; i *= 2, sum += i)
            {
                Console.WriteLine("i = {0},  sum = {1}", i, sum);
            }
            // Result
            // i = 1,    sum = 1
            // i = 2,    sum = 3
            // i = 4,    sum = 7
            // i = 8,    sum = 15
            // i = 16,   sum = 31
            // i = 32,   sum = 63
            // i = 64,   sum = 127
            // i = 128,  sum = 255


            // Calculating N ^ M – Example
            // Write a program that raises the number n to a power of m
            Console.Write("\nEnter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m : ");
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;

            for (int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine("n ^ m = " + result);
            Console.ReadLine();

            // Enter n : 2
            // Enter m : 10
            // n ^ m = 1024
        }
    }
}
