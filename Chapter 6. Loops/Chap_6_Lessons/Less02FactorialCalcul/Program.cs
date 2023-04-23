using System;

namespace Less02FactorialCalcul
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculating Factorial - The calculation is performed by using an infinite while loop and the operator break.

            // -N! = 1 * 2 * 3 … (n-1) * n, for n > 1;
            // -2! = 1 * 2;
            // -1! = 1;
            // -0! = 1.
            // in the first iteration of the loop the variable factorial has a value n,
            // in the second – n*(n-1) and so on.
            // In the last iteration of the loop the value of factorial is the product n*(n-1)*(n-2)*…*3*2, which is the desired value of n!.

            Console.Write("Enter n : ");
            int n = Int32.Parse(Console.ReadLine());
            // decimal is the biggest C# type that can hold integer values
            decimal factorial = 1;
            // Perform an "infinite loop"
            Console.Write(n);
            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
                Console.Write(" * " + n + "(" + factorial + ")");
            }
            Console.WriteLine(" => n! = " + factorial);
            Console.ReadLine();

            // Enter n : 10
            // 10 * 9(10) * 8(90) * 7(720) * 6(5040) * 5(30240) * 4(151200) * 3(604800) * 2(1814400) * 1(3628800) => n! = 3628800
        }
    }
}
