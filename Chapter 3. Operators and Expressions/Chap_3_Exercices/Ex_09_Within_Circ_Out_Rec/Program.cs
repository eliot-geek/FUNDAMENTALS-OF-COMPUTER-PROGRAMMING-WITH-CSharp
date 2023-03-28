using System;

namespace Ex_09_Within_Circ_Out_Rec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}].
            // Clarification: for the rectangle the lower left and the upper right corners are given.
            // Solution: Use the code from the previous task and add a check for the rectangle.
            // A point is inside a rectangle with walls parallel to the axes, when in the same time it
            // is right of the left wall,
            // left of the right wall,
            // down from the top wall and
            // above the bottom wall.

            // Prompt the user to enter the x and y coordinates of a point
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            // Check if the point is inside the circle K((0,0), R=5)
            bool isInsideCircle = ((x * x) + (y * y)) <= 5 * 5 ? true : false;
            // Check if the point is outside the rectangle ((-1, 1), (5, 5))
            bool isOutsideRectangle = (x > -1 && x < 5 && y > 1 && y < 5) ? true : false;
            // Print the result of the circle and rectangle checks
            Console.WriteLine("The point O({0};{1}) is within the circle K((0,0), R=5) ?: {2}", x, y, isInsideCircle);
            Console.WriteLine("The point O({0};{1}) is outside the rectangle ((-1, 1), (5, 5)?: {2}", x, y, isOutsideRectangle);
            // Wait for user to press a key and add a new line
            Console.ReadKey(); Console.WriteLine();
        }
    }
}
