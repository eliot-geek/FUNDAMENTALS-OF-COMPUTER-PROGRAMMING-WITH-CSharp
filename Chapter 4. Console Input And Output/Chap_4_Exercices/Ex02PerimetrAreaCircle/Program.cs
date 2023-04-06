using System;

namespace Ex02PerimetrAreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
             Guide: Use Math.PI constant and the well-known geometric formulas.*/

            // Prompt the user to enter the radius of the circle and read in the input as a string
            Console.Write("Enter the radius of the circle: ");
            // Convert the input string to an integer
            int radius = Int32.Parse(Console.ReadLine());
            // Calculate the perimeter and area of the circle using the formulas for circle geometry
            Console.WriteLine("Perimeter is {0} \nArea is {1}", 2 * Math.PI * radius, Math.PI * radius * radius);



            Console.WriteLine(); Console.ReadKey();
            // Prompt the user to enter the radius of the circle and read in the input as a string
            Console.WriteLine("Please enter the radius of the circle:");
            // read input from user
            string input = Console.ReadLine();
            // convert string to double
            double radius1 = double.Parse(input);
            // calculate perimeter and area using the formulas for circle geometry
            double perimeter = 2 * Math.PI * radius1;
            double area = Math.PI * radius1 * radius1;
            // print perimeter and area to console
            Console.WriteLine("Perimeter of the circle: " + perimeter);
            Console.WriteLine("Area of the circle: " + area);
        }
    }
}
