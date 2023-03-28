using System;

namespace Ex_08_Point_Within_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5).
            // Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
            // Solution: Use the Pythagorean Theorem a2 + b2 = c2. The point is inside the circle when (x*x) + (y*y) ≤ 5*5.

            // Prompt the user to enter the x coordinate of a point
            Console.Write("Enter Point X: ");
            decimal pointX = decimal.Parse(Console.ReadLine());
            // Prompt the user to enter the y coordinate of a point
            Console.Write("Enter Point Y: ");
            decimal pointY = decimal.Parse(Console.ReadLine());
            // radius
            decimal radius = 5;
            bool result = (pointX * pointX) + (pointY * pointY) <= radius * radius;
            Console.WriteLine(result ? "The point ({0};{1}) is within the circle." : "The point ({0};{1}) is outside the circle.", pointX, pointY);
            Console.ReadKey(); Console.WriteLine();


            // Prompt the user to enter the x and y coordinates of a point
            Console.Write("\nEnter the x-coordinate of a point: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of a point: ");
            double y = double.Parse(Console.ReadLine());
            // Check if the point is within the circle
            if ((x * x) + (y * y) <= 5 * 5)
            {
                Console.WriteLine("The point ({0}; {1}) is within the circle.", x, y);
            }
            else
            {
                Console.WriteLine("The point ({0}; {1}) is outside the circle.", x, y);
            }
            Console.ReadKey(); Console.WriteLine();
        }
    }
}
