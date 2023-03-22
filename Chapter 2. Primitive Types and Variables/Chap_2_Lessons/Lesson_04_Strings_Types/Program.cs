using System;

namespace Lesson_04_Strings_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings - Strings are sequences of characters. In C# they are declared by the keyword string. Their default value is null. Strings are enclosed in quotation marks.

            // Declare some variables
            string firstName = "Anders";
            string lastName = "Hejlsberg";
            string fullName = firstName + " " + lastName;

            // Print the results on the console
            Console.WriteLine("Hello, " + firstName + "!");
            Console.WriteLine("Your full name is " + fullName + ".");
        }
    }
}
