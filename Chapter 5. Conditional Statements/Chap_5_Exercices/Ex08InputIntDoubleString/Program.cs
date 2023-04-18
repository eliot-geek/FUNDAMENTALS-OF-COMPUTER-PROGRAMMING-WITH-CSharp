using System;

namespace Ex08InputIntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1.
            // If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.
            // Guide: First input a variable, which indicates what type will be the input, i.e. by entering 0 the type is int, by 1 is double and by 2 is string

            // Prompt the user to enter the type of input they want to provide
            Console.WriteLine("Enter the type of input you would like to provide:");
            Console.WriteLine("0 for int, 1 for double, 2 for string.");
            // Read the user's choice of input type from the console
            int choice = int.Parse(Console.ReadLine());

            // Use a switch statement to handle the different cases based on the user's choice
            switch (choice)
            {
                case 0:
                    // If the user chose int, prompt them to enter an integer
                    Console.WriteLine("Enter an integer:");
                    int i = int.Parse(Console.ReadLine());
                    // Increases by 1 to the integer and print the result
                    Console.WriteLine("Result: " + (i + 1)); // or i++
                    break;
                case 1:
                    // If the user chose double, prompt them to enter a double
                    Console.WriteLine("Enter a double:");
                    double d = double.Parse(Console.ReadLine());
                    // Increases by 1 to the double and print the result
                    Console.WriteLine("Result: " + (d + 1)); // or d++
                    break;
                case 2:
                    // If the user chose string, prompt them to enter a string
                    Console.WriteLine("Enter a string:");
                    string s = Console.ReadLine();
                    // Append "*" to the string and print the result
                    Console.WriteLine("Result: " + s + "*");
                    break;
                default:
                    // If the user entered an invalid choice, print an error message
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
