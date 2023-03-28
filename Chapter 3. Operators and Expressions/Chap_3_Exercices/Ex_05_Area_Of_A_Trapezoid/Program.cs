using System;

namespace Ex_05_Area_Of_A_Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
            // The formula for trapezoid surface is: S = (a + b) * h / 2.

            Console.WriteLine("First Method");
            // Declare variables for the lengths of the parallel sides and the height
            double a = 5.4;     // Length of first parallel side
            double b = 10.0;    // Length of second parallel side
            double h = 8.0;     // Height between the parallel sides
            // Calculate the area of the trapezoid using the formula: (a + b) * h / 2
            double area = (a + b) * h / 2.0;
            // Print the result to the console
            Console.WriteLine("The area of the trapezoid is: " + area);
            Console.ReadKey(); Console.WriteLine();

            Console.WriteLine("Second Method");
            Console.Write("Enter side A : ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side B : ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height H : ");
            double heightH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is: {0}", ((sideA + sideB) * heightH) / 2.0);
        }
    }
}
