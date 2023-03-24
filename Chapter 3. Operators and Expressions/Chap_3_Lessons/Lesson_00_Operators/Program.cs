using System;

namespace Lesson_00_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operators in C# are special characters (such as "+", ".", "^", etc.) and they perform transformations on one, two or three operands.
            // Operator Categories and Types of Operators by Number of Arguments (picture) 
            // All binary operators in C# are left-associative, i.e. the expressions are calculated from left to right, except for the assignment operators.
            // All assignment operators and conditional operators ?: and ?? are right-associative, i.e. the expressions are calculated from right to left. The unary operators are not associative.

            int a0 = 7 + 9;
            Console.WriteLine(a0); // 16
            string firstName = "Andres";
            string lastName = "Hejlsberg";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);  // Andres Hejlsberg
            Console.ReadKey();

            // Operator Precedence in C# - Some operators have precedence (priority) over others. The operator () is used to change the precedence and like in math, it is calculated first.
            // When we write expressions that are more complex or have many operators, it is recommended to use brackets to avoid difficulties in reading and understanding the code.
            // Ambiguous                        x + y / 100
            // Unambiguous, recommended         x + (y / 100)

            // Arithmetical Operators - integer division (like int, long and sbyte) and real division (e.g. float, double, etc.) 
            // Integer division by 0 is not allowed and causes a runtime exception DivideByZeroException. 
            // In the division of real numbers it is allowed to divide by 0.0 and respectively the result is +∞ (Infinity), -∞ (-Infinity) or NaN (invalid value).
            // ++ (increment) and -- (decrement) as a prefix the new value is calculated first and then the result is returned.
            // as post-fix the original value of the operand is returned first, then the addition or subtraction is performed.

            int squarePermimeter = 17;
            double squareSide = squarePermimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide);      // 4.25
            Console.WriteLine(squareArea);      // 18.0625
            Console.ReadKey();

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b);       // 9
            Console.WriteLine(a + (b++));   // 9
            Console.WriteLine(a + b);       // 10
            Console.WriteLine(a + (++b));   // 11
            Console.WriteLine(a + b);       // 11
            Console.WriteLine(14 / a);      // 2
            Console.WriteLine(14 % a);      // 4

            int one = 1;
            int zero = 0;
            // System.DivideByZeroException: "Attempted to divide by zero."
            // Console.WriteLine(one / zero);

            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero); // -Infinity
            Console.WriteLine(one / dZero); // +Infinity

            // можно подтвердить, что результат действительно является отрицательной или положительной бесконечностью, используя методы Double.IsNegativeInfinity() и Double.IsPositiveInfinity() в C#
            Console.WriteLine(Double.IsNegativeInfinity(dMinusOne / zero)); // True
            Console.WriteLine(Double.IsPositiveInfinity(one / dZero));      // True
        }
    }
}
