using System;

namespace Ex_06_Perimet_Area_Rectan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
            // Search the Internet for how to read integers from the console and use the formula for rectangle area calculation.
            // If you have difficulties see instructions on the next problem.

            // Prompt the user to enter the side length and height of the rectangle
            Console.Write("Enter the side length of the rectangle: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            // Calculate the perimeter and area of the rectangle
            double perimeter = 2 * (side + height);
            double area = side * height;
            // Print the results to the console
            Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
            Console.WriteLine("The area of the rectangle is: {0}", area);

            /*
            double.Parse is a static method of the double type, whereas Convert.ToDouble is a static method of the Convert class.
            double.Parse throws an exception if the input string is not in a valid format for a double-precision floating-point number, 
            whereas Convert.ToDouble returns zero if the input string is null or not in a valid format. This means that double.Parse is more strict in its input validation.
             */
        }
    }
}
