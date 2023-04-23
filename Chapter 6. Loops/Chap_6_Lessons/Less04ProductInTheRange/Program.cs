using System;

namespace Less04ProductInTheRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Product in the Range [N…M] – Example
            // The goal is to find the product of all numbers in the range [n…m].

            // We consecutively assign to num at each iteration the values n, n+1, …, m and in the variable product we accumulate the product of these values.
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m : ");
            int m = int.Parse(Console.ReadLine());
            int num = n;
            long product = 1; // The product grows very fast, so you may need to use BigInteger
            do
            {
                product *= num;
                num++;
            } while (num <= m);
            Console.WriteLine("Product[n...m] = " + product);

            // Enter n : 2
            // Enter m : 6
            // Product[n...m] = 720


            // Be careful: the product grows very fast, so you may need to use BigInteger instead of long for the calculated result.
            // Also beware of hidden integer overflow. Unchecked code will silently overflow and the code above will produce incorrect output
            // instead of showing an error.
        }
    }
}
