using System;

namespace Ex06QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates
            // and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.

            // Guide: From math it is known, that a quadratic equation may have one or two real roots or no real roots at all.
            // In order to calculate the real roots of a given quadratic equation, we first calculate the discriminant (D) by the formula: D = b2 - 4ac.
            // If the discriminant is zero, then the quadratic equation has one double real root and it is calculated by the formula: x1,2=-b/2a.
            // If the value of the discriminant is positive, then the equation has two distinct real roots, which are calculated by the formula: x1,2=-b+-sqrt(b2-4ac)/2a.
            // If the discriminant is negative, the quadratic equation has no real roots.

            //Prompt user to input coefficients a, b, and c
            Console.WriteLine("Enter coefficients a, b, and c of a quadratic equation ax^2 + bx + c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //Calculate discriminant
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine("The discriminant (D) is : {0}", discriminant);

            //Check discriminant value and calculate roots accordingly
            if (discriminant < 0)
            {
                Console.WriteLine("The quadratic equation has no real roots.\nD = {0}", discriminant);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("The quadratic equation has one double real root.\nX = {0}", root);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The quadratic equation has two distinct real roots.\nX1 = {0}\nX2 = {1}", root1, root2);
            }
            Console.WriteLine();
        }
    }
}
