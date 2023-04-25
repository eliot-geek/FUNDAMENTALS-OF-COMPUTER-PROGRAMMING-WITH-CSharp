namespace Ex17GCDandLCM
{
    internal class Program
    {
        // Define the GCD method that takes two integer arguments and returns an integer
        static int GCD(int a, int b)
        { 
            if (b == 0)
            { 
                // If b is zero, then a is the GCD
                return a;
            }
            else
            {
                // Otherwise, recursively call GCD with b and the remainder of a divided by b
                return GCD(b, a % b); 
            }
        }

        // Define the LCM method that takes two integer arguments and returns an integer
        static int LCM(int a, int b)
        {
            // Calculate the LCM using the formula LCM(a, b) = |a*b| / GCD(a, b)
            return Math.Abs(a * b) / GCD(a, b); 
        }

        static void Main(string[] args)
        {
            #region Task 17
            // Write a program that given two numbers finds their greatest common divisor(GCD) and their least common multiple(LCM).
            // You may use the formula LCM(a, b) = | a * b | / GCD(a, b).
            // Guide: Search the Internet for the Euclidean algorithm for calculation the greatest common divisor (CGD) or read about it in Wikipedia:
            // http://en.wikipedia.org/wiki/Euclidean_algorithm.
            #endregion


            Console.Write("Enter the first number: "); // Prompt the user to enter the first number
            int num1 = int.Parse(Console.ReadLine()); // Read the first number as an integer from the console input

            Console.Write("Enter the second number: "); // Prompt the user to enter the second number
            int num2 = int.Parse(Console.ReadLine()); // Read the second number as an integer from the console input

            int gcd = GCD(num1, num2); // Calculate the GCD of the two numbers using the GCD method
            int lcm = LCM(num1, num2); // Calculate the LCM of the two numbers using the LCM method

            Console.WriteLine("GCD({0}, {1}) = {2}", num1, num2, gcd); // Print the GCD of the two numbers to the console output
            Console.WriteLine("LCM({0}, {1}) = {2}", num1, num2, lcm); // Print the LCM of the two numbers to the console output

            Console.ReadLine();
        }
    }
}