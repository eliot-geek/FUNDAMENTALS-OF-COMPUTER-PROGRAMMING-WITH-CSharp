using System;

namespace Lesson_02_Boolean_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean Types - Boolean type is declared with the keyword bool. It has two possible values: true and false. Its default value is false.

            // Define two integer variables a and b, and initialize them to 1 and 2 respectively
            int a = 1, b = 2;
            // Define a boolean variable greaterAB and set it to true if a is greater than b, and false otherwise
            bool greaterAB = (a > b);
            // Define a boolean variable equalA1 and set it to true if a is equal to 1, and false otherwise
            bool equalA1 = (a == 1);

            // Use an if statement to check if a is greater than b
            if (greaterAB)
            {
                // If a is greater than b, print "A > B" to the console
                Console.WriteLine("A > B");
            }
            else
            {
                // If a is not greater than b, print "A <= B" to the console
                Console.WriteLine("A <= B");
            }

            // Print the boolean value of the greaterAB variable to the console
            Console.WriteLine("greaterAB = " + greaterAB);
            // Print the vboolean alue of the equalA1 variable to the console
            Console.WriteLine("equalA1 = " + equalA1);
        }
    }
}
