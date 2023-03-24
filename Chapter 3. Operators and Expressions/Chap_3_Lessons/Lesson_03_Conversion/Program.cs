using Microsoft.VisualBasic;
using System;

namespace Lesson_03_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Conversion and Casting - To perform an operation on variables of two different data types we need to convert both to the same data type.
            // Type conversion (typecasting) can be explicit and implicit. 
            // In C# not all types can be converted to all other types, but only to some of them.

            // Implicit Type Conversion (hidden) is possible only when there is no risk of data loss during the conversion, i.e. when converting from a lower range type to a larger range
            // The implicit conversion is done automatically by the compiler when you assign a value with lower range to a variable with larger range
            
            int myInt = 5; Console.WriteLine(myInt);        // 5
            long myLong = myInt; Console.WriteLine(myLong); // 5
            Console.WriteLine(myLong + myInt);              // 10
            Console.ReadKey();  Console.WriteLine();

            // Possible Implicit Conversions
            /* Here are some possible implicit conversions of primitive data types in C#:
                - sbyte → short, int, long, float, double, decimal;
                - byte → short, ushort, int, uint, long, ulong, float, double, decimal;
                - short → int, long, float, double, decimal;
                - ushort → int, uint, long, ulong, float, double, decimal;
                - char → ushort, int, uint, long, ulong, float, double, decimal (although char is a character type in some cases it may be regarded as a number and have a numeric type of behavior, it can even participate in numeric expressions);
                - uint → long, ulong, float, double, decimal;
                - int → long, float, double, decimal;
                - long → float, double, decimal;
                - ulong → float, double, decimal;
                - float → double. */

            // There is no data loss when converting types of smaller range to types with a larger range.
            // There are a few exceptions. When you convert type int to type float (32-bit values), the difference is that int uses all bits for a whole number,
            // whereas float has a part of bits used for representation of a fractional part. Hence, loss of precision is possible because of rounding when conversion
            // from int to float is made. The same applies for the conversion of 64-bit long to 64-bit double.

            // Explicit Type Conversion - is used whenever there is a possibility of data loss. it is necessary to use the operator for data conversion (type).
            // There may also be data loss when converting a type with a wider range to type with a narrower one (double to float or long to int).
            double myDouble = 5.1d; Console.WriteLine(myDouble);        // 5.1
            long mLong = (long)myDouble; Console.WriteLine(mLong);      // 5 - we see that the variable has lost its fractional part, because long is an integer.
            Console.ReadKey(); Console.WriteLine();

            myDouble = 5e9d;                        // 5 * 10 ^ 9
            Console.WriteLine(myDouble);            // 5 000 000 000
            int myIt = (int)myDouble;
            Console.WriteLine(myIt);                // -2147483648 - The result is like int.MinValue because myDouble contains a value bigger than the range of int.
            Console.WriteLine(int.MinValue);        // -2147483648 - Be careful when switching to a "smaller" type.
            Console.ReadKey(); Console.WriteLine();

            // Data Loss during type Conversation
            long myLon = long.MaxValue;
            int myInte = (int)myLon;
            Console.WriteLine(myLon);               // 9223372036854775807
            Console.WriteLine(myInte);              // -1   // It's impossible
            Console.ReadKey(); Console.WriteLine();

            float heightInMeters = 1.74f;               Console.WriteLine(heightInMeters);      // 1,74                     // Explicit conversion
            double maxHeight = heightInMeters;          Console.WriteLine(maxHeight);           // 1,7400000095367432       // Implicit conversion
            double minHeight = (double)heightInMeters;  Console.WriteLine(minHeight);           // 1,7400000095367432       // Explicit conversion
            float actualHeight = (float)maxHeight;      Console.WriteLine(actualHeight);        // 1,74                     // Explicit conversion
            // float maxHeightFloat = maxHeight; // Compilation error!
            Console.ReadKey(); Console.WriteLine();

            // Forcing Overflow by keyword checked - Instead of getting the wrong result, let's get notification of the problem. This is done by the keyword checked
            double d = 5e9d;            // 5 * 10 ^ 9
            Console.WriteLine(d);       // 5 000 000 000
            // int i = checked((int)d);    // System.OverflowException: "Arithmetic operation resulted in an overflow."
            // Console.WriteLine(i);
            Console.ReadKey(); Console.WriteLine();

            // Possible Explicit Conversions - The explicit conversions between numeral types in C# are possible between any couple among the following types:
            // sbyte, byte, short, ushort, char, int, uint, long, ulong, float, double, decimal
            // Notice that conversion to or from string is not possible through typecasting.

            // Conversion to String - If it is necessary we can convert any type of data, including the value null, to string.
            // The conversion of strings is done automatically whenever you use the concatenation operator (+) and one of the arguments is not of type string.
            // Another way to convert different objects to type string is to call the method ToString() of the variable or the value. It is valid for all data types in .NET Framework.
            
            int m = 5;
            int n = 7;
            string sum = "Sum = " + (m + n);
            Console.WriteLine(sum);
            String incorrect = "Sum = " + m + n; // Incorrect because of the ( )
            Console.WriteLine(incorrect);
            Console.WriteLine("Perimeter = " + 2 * (m + n) + ". Area = " + (m * n) + ".");

            // The "+" for concatenating strings can cause unpleasant effects on the addition of numbers, because it has equal priority with the operator "+" for mathematical
            // addition. Unless the priorities of the operations are changed by placing the brackets, they will always be executed from left to right.
        }
    }
}
