using System;

namespace Ex13ReadFromConsoleCalcul
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads a, b and c from the console and calculates: ax^2 + bx + c = 0. */

            Console.Write("Enter a: ");
            // read a from console input
            double a = double.Parse(Console.ReadLine()); 
            Console.Write("Enter b: ");
            // read b from console input
            double b = double.Parse(Console.ReadLine()); 
            Console.Write("Enter c: ");
            // read c from console input
            double c = double.Parse(Console.ReadLine()); 

            // calculate the discriminant of the quadratic equation using the formula b^2 - 4ac.
            double discriminant = b * b - 4 * a * c; 

            if (discriminant < 0)
            {
                // output message if there are no real solutions
                Console.WriteLine("No real solutions: Discriminant = {0} ", discriminant);
            }
            else if (discriminant == 0)
            {
                // calculate the only solution if the discriminant is zero
                double x1 = (-b / (2 * a));
                // output the solution
                Console.WriteLine("One solution: X = {0} ", x1);
            }
            else
            {
                // calculate the first solution
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                // calculate the second solution
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                // output the solutions
                Console.WriteLine("Two solutions: X1 = {0}, X2 = {1}", x1, x2);
            }
        }
    }
}
