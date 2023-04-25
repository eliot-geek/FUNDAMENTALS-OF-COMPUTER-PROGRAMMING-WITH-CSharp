using System;

namespace Ex17GreatComDivLeaComMult
{
    class Program
    {
        /// <summary>
        /// Use Euclid's algorithm to calculate the greatest common divisor (GCD) of two numbers. The algorithm involves dividing the larger number by the 
        /// smaller number and using the remainder as the new divisor until the remainder is zero, at which point the last non-zero remainder is the GCD. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static long GCD1(long a, long b)
        {
            // Take the absolute value of a and b using the Math.Abs method
            a = Math.Abs(a);
            b = Math.Abs(b);

            // Loop indefinitely until the method returns a value
            for (; ; )
            {
                // Calculate the remainder of a divided by b using the modulus operator
                long remainder = a % b;
                // If the remainder is zero, then b is the GCD
                if (remainder == 0)
                    return b;
                // Otherwise, set a to b and b to the remainder
                a = b;
                b = remainder;
            };
        }
        /// <summary>
        /// Use Euclid's algorithm to calculate the greatest common divisor (GCD) of two numbers. Recursive Euclidean algorithm for finding the GCD of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static long GCD(long a, long b)
        {
            // Take the absolute value of a and b using the Math.Abs method
            a = Math.Abs(a);
            b = Math.Abs(b);
            // If b evenly divides a, then b is the GCD
            if (a % b == 0) 
                return b;
            // Otherwise, recursively call the GCD method with b and the remainder of a divided by b
            return GCD(b, a % b);
        }

        /// <summary>
        /// Return the least common multiple (LCM) of two numbers. The formula for finding the LCM of two numbers using their GCD. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static long LCM(long a, long b)
        {
            // Calculate the product of a and b, then divide by their GCD to get the LCM
            return a * b / GCD(a, b);

            // Alternatively, you could use the Math.Abs method to ensure that the LCM is positive
            // return Math.Abs(a * b) / GCD(a, b);
        }
        static void Main(string[] args)
        {
            #region Task 17
            // Write a program that given two numbers finds their greatest common divisor(GCD) and their least common multiple(LCM).
            // You may use the formula LCM(a, b) = | a * b | / GCD(a, b).
            // Guide: Search the Internet for the Euclidean algorithm for calculation the greatest common divisor (CGD) or read about it in Wikipedia:
            // http://en.wikipedia.org/wiki/Euclidean_algorithm.
            #endregion

            // Prompt the user to enter the first number and store it in a
            Console.Write("Enter first number a : ");
            int a = Int32.Parse(Console.ReadLine());
            // Prompt the user to enter the second number and store it in b
            Console.Write("Enter second number b : ");
            int b = Int32.Parse(Console.ReadLine());
            // Calculate the GCD of a and b using the GCD method and print it to the console
            Console.WriteLine("The greatest common divisor(GCD) is : " + GCD(a, b));
            // Calculate the LCM of a and b using the LCM method and print it to the console
            Console.WriteLine("The least common multiple (LCM) is : " + LCM(a, b));
            // Wait for the user to press Enter before exiting the program
            Console.ReadLine();



            // Print a message to the console to indicate that the second method is being used
            Console.WriteLine("\nSolution 2 - Finds only the GCD");
            // Use a while loop to repeatedly calculate the remainder of a and b until one of them is zero, or they are equal
            while (a != 0 && b != 0 && a != b)
            {
                // If a is greater than b, update a to be the remainder of a divided by b
                if (a > b)
                {
                    a %= b;

                    // Alternatively, you could update a by subtracting b from it
                    // a -= b; 
                }
                // Otherwise, update b to be the remainder of b divided by a
                else
                {
                    b %= a;

                    // Alternatively, you could update b by subtracting a from it
                    // b -= a; 
                }
            }
            // If a is zero, b is the GCD; otherwise, a is the GCD
            if (a == 0)
            {
                Console.WriteLine("The greatest common divisor(GCD) is : " + b);
            }
            else
            {
                Console.WriteLine("The greatest common divisor(GCD) is : " + a);
            }
            // Wait for the user to press Enter before exiting the program
            Console.ReadLine();

        }
    }
}
