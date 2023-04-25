using System;

namespace Ex02PrintNumbNotDiviBy3A7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            // Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
            // The number N should be read from the standard input.
            // Guide: Use a for-loop and the operator % for finding the remainder in integer division.
            // A number number is not divisible by 3 and 7 simultaneously exactly when (num % (3*7) == 0).
            #endregion


            Console.Write("Enter a number num : ");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                // check if i is not divisible by 3 and 7 simultaneously
                if (i % (3 * 7) == 0) // OR (i % 3 == 0 && i % 7 == 0) 
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.ReadLine();


            Console.Write("\nEnter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % (3 * 7) != 0)
                { // check if i is not divisible by 3 and 7 simultaneously
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
