using System;
using System.Numerics;

namespace Less04FactorialLargeNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial of a Large Number – If we want to calculate 100! we can use data type BigInteger
            // There is no limit on the size of the numbers recorded in the class BigInteger (as long as you have enough RAM).
            // We need to add "using System.Numerics;"
            // Replace decimal with BigInteger

            // By BigInteger you can calculate 1000!, 10000! and even 100000! It will take some time, but OverflowException will not occur.
            // The BigInteger class is very powerful but it works many times slower than int and long.

            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("n! =  " + factorial);

            // n = 100
            // n! = 93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000
        }
    }
}
