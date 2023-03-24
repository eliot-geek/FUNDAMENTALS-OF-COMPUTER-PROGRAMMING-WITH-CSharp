using System;

namespace Lesson_04_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expressions are sequences of operators, literals and variables that are calculated to a value of some type (number, string, object or other type).

            int rayon = (150 - 20) / 2 + 5;
            Console.WriteLine(rayon);
            // Expression for calculating the surface of the circle
            double surfaceCircle = Math.PI * rayon * rayon; 
            Console.WriteLine(surfaceCircle);
            // Expression for calculating the perimeter of the circle
            double perimeterCircle = 2 * Math.PI * rayon;
            Console.WriteLine(perimeterCircle);
            Console.ReadKey(); Console.WriteLine();

            // Side Effects of Expressions - the expression can contain embedded assignment operators, can cause increasing or decreasing of the value and calling methods.
            int a = 5;
            int b = ++a;
            Console.WriteLine(a);       // 6
            Console.WriteLine(b);       // 6
            Console.ReadKey(); Console.WriteLine();

            // Expression, Data Types and Operator Priorities
            double d = 1 / 2;
            Console.WriteLine(d);           // 0, not 0.5
            double half = (double)1 / 2;
            Console.WriteLine(half);        // 0.5
            Console.ReadKey(); Console.WriteLine();

            // Divided by Zero
            int num = 1;
            double denum = 0;                       // The value is 0.0 (real number)
            //int zeroInt = (int)denum;               // The value is 0 (integer number)
            Console.WriteLine(num / denum);         // Infinity
            Console.WriteLine(denum / denum);       // NaN
            //Console.WriteLine(zeroInt / zeroInt);   // DivideByZeroException -  System.DivideByZeroException: "Attempted to divide by zero."
            Console.ReadKey(); Console.WriteLine();


            // Use Brackets to Make the Code Clear
            // When working with expressions it is important to use brackets whenever there is the slightest doubt about the priorities of the operations.

            double incorrect = (double)((1 + 2) / 4);
            Console.WriteLine(incorrect);                   // 0
            double correct = ((double)(1 + 2)) / 4;
            Console.WriteLine(correct);                     // 0.75
            Console.WriteLine("2 + 3 = " + 2 + 3);          // 2 + 3 = 23
            Console.WriteLine("2 + 3 = " + (2 + 3));        // 2 + 3 = 5
        }
    }
}
