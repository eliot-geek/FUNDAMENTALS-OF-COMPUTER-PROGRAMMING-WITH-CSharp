using System;

namespace Lesson_02_Assignment_Oper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Operators - "=" - The syntax is operand1 = literal, expression or operand2;
            // Assignment Operators – Example
            int x = 6;
            string hellostring = "Hello string";
            int y = x;
            Console.WriteLine(x); Console.WriteLine(hellostring); Console.WriteLine(y); Console.ReadKey(); Console.WriteLine();

            // Cascade Assignment
            int a, b, c;
            a = b = c = 25;
            Console.WriteLine(a); Console.WriteLine(b); Console.WriteLine(c); Console.ReadKey(); Console.WriteLine();
            // The assignment operator in C# is "=", while the comparison operator is "==".

            // Compound Assignment Operators - The syntax is operand1 operator = operand2; They help to reduce the volume of the code by typing two operations together with an operator
            x *= y; // same x = x * y; 6 * 6 = 36
            Console.WriteLine(x); Console.ReadKey(); Console.WriteLine();

            // The most commonly used compound assignment operators are
            // += (adds value of operand2 to operand1),
            // -= (subtracts the value of the right operand from the value of the left one).
            // Other compound assignment operators are *=, /= and %=.
            int xx = 6;
            int yy = 4;
            Console.WriteLine(yy *= 2);         // 8
            int zz = yy = 3;                    // yy = 3 and zz = 3
            Console.WriteLine(zz);              // 3
            Console.WriteLine(xx |= 1);         // 7
            Console.WriteLine(xx += 3);         // 10
            Console.WriteLine(xx /= 2);         // 5
            Console.ReadKey(); Console.WriteLine();

            // Conditional ?: - The conditional operator ?: uses the Boolean value of an expression to determine which of two other expressions must be calculated and returned as a result.
            // The operator works on three operands and that is why it is called ternary operator.
            // The character "?" is placed between the first and second operand, and ":" is placed between the second and third operand.
            // The first operand (or expression) must be Boolean, and the next two operands must be of the same type, such as numbers or strings.
            // The syntax is operand1 ? operand2 : operand3 - if operand1 is set to true, the operator returns as a result operand2. Otherwise (if operand1 is set to false), the operator returns as a result operand3.

            // Conditional Operator "?:" – Example
            int p = 6;
            int q = 4;
            Console.WriteLine(p > q ? "p > q" : "p < q");   // p > q
            Console.WriteLine(p == q ? 1 : -1);             // -1
            Console.ReadKey(); Console.WriteLine();

            // The access operator "." (dot) is used to access the member fields or methods of a class or object.
            Console.WriteLine(DateTime.Now);        // // Prints the date + time
            Console.ReadKey(); Console.WriteLine();

            // Square Brackets [] Operator are used to access elements of an array by index, they are the so-called indexer. Indexers are also used for accessing characters in a string.
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]); // 1
            string str = "CSharp";
            Console.WriteLine(str[1]); // S
            Console.ReadKey(); Console.WriteLine();

            // The operator for type conversion (type) is used to convert a variable from one type to another.
            // The operator as also is used for type conversion but invalid conversion returns null, not an exception.
            // The new operator is used to create and initialize new objects.

            // Operator ?? - The operator ?? is similar to the conditional operator ?:.
            // The difference is that it is placed between two operands and returns the left operand only if its value is not null, otherwise it returns the right operand.
            int? s = 5;
            Console.WriteLine(s ?? -2); // 5
            string name = null;
            Console.WriteLine(name ?? "CSharp"); // CSharp
            Console.ReadKey(); Console.WriteLine();

            // Other Operators – Examples
            // Brackets () are used to override the priority of execution of expressions and operators.
            int e = 6;
            int f = 3;
            Console.WriteLine(e + f / 2);       // 7
            Console.WriteLine((e + f) / 2);     // 4
            Console.ReadKey(); Console.WriteLine();

            // The is operator is used to check whether an object is compatible with a given type (check object's type).
            string st = "Food";
            Console.WriteLine(st is string);
            Console.ReadKey(); Console.WriteLine();

            // Operator ?? - The operator ?? is similar to the conditional operator ?:.
            string notNullString = st;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspecified");     // Unspecified
            Console.WriteLine(notNullString ?? "Specified");    // Food
            Console.ReadKey(); Console.WriteLine();
        }
    }
}
