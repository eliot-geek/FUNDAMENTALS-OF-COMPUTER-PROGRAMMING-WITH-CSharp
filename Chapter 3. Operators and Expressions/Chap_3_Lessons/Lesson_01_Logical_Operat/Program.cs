using System;

namespace Lesson_01_Logical_Operat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical Operators - The basic Boolean operators are "AND" (&&), "OR" (||), "exclusive OR" (^) and logical negation (!) - Boolean result (true or false). 
            // Logical Operators Table (picture) 

            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);                  // False
            Console.WriteLine(a || b);                  // True
            Console.WriteLine(!b);                      // True
            Console.WriteLine(b || true);               // True
            Console.WriteLine((5 > 7) ^ (a == b));      // False
            Console.ReadKey();

            // Laws of De Morgan -
            // The first law states that the negation of the conjunction (logical AND) of two propositions is equal to the disjunction (logical OR) of their negations.
            // The second law states that the negation of the disjunction of both statements is equivalent to the conjunction of their negations.
            // !(a && b) == (!a || !b)
            // !(a || b) == (!a && !b)

            // Operator for Concatenation of Strings 
            string csharp = "C#";
            string dotnet = ".NET";
            string csharpDotNet = csharp + dotnet;
            Console.WriteLine(csharpDotNet);                    // C#.NET
            string csharpDotNet4 = csharpDotNet + " " + 5;
            Console.WriteLine(csharpDotNet4);                   // C#.NET 5
            Console.ReadKey();

            // Bitwise Operators - A bitwise operator is an operator that acts on the binary representation of numeric types.
            // In computers all the data and particularly numerical data is represented as a series of ones and zeros. Bitwise operators are used to analyze and change those ones to zeros and vice versa.
            // number 55 in the binary numeral system is represented as 00110111.
            // Bitwise operators are very similar to the logical ones. Logical operators work with the values true and false (Boolean values). 
            // Bitwise operators work with numerical values with the bits of the number (the digits 0 and 1 of which it consists).
            // there are bitwise operators "AND" (&), bitwise "OR" (|), bitwise negation (~) and excluding "OR" (^).
            // there are two bitwise operators that have no analogue in logical operators. These are the bit shift left (<<) and bit shift right (>>).
            // they move all the bits of the value to the left or right. The bits that fall outside the number are lost and replaced with 0.

            // The bit shifting operators are used in the following way : on the left side of the operator we place the variable (operand) with which we want to use the operator,
            // on the right side we put a numerical value, indicating how many bits we want to offset.

            // For example, 3 << 2 means that we want to move the bits of the number three, twice to the left.
            // The number 3 in bits looks like this: "0000 0011". When you move twice left,
            // The binary value will look like this: "0000 1100", and this sequence of bits is the number 12. 
            // Bit shifting itself can be represented as multiplication (bitwise shifting left) or division (bitwise shifting right) by a power of 2.

            // Example of moving to the right is 6 >> 2, which means to move the binary number "0000 0110" with two positions to the right. This means that we will lose two
            // right-most digits and feed them with zeros on the left.  The end result will be "0000 0001" which is 1.

            // Bitwise Operators – Example
            Console.WriteLine("\nBitwise Operators (Binary)");
            byte x = 3; Console.WriteLine(x + "\t\"0000 0011 = 3\"");        // 0000 0011 = 3
            byte y = 5; Console.WriteLine(y + "\t\"0000 0101 = 5\"");        // 0000 0101 = 5                

            Console.WriteLine($"{x | y}  {"\t\"0000 0111 = 7\""}");           // 0000 0111 = 7
            Console.WriteLine($"{x & y}  {"\t\"0000 0001 = 1\""}");           // 0000 0001 = 1
            Console.WriteLine($"{x ^ y}  {"\t\"0000 0110 = 6\""}");           // 0000 0110 = 6
            Console.WriteLine($"{~x & y} {"\t\"0000 0100 = 4\""}");           // 0000 0100 = 4
            Console.WriteLine($"{x << 1} {"\t\"0000 0110 = 6\""}");           // 0000 0110 = 6
            Console.WriteLine($"{x << 2} {"\t\"0000 1100 = 12\""}");          // 0000 1100 = 12
            Console.WriteLine($"{x >> 1} {"\t\"0000 0001 = 1\""}");           // 0000 0001 = 1
            Console.ReadKey();

            // Comparison Operators - are used to compare two or more operands (< > <= >= == !=) 
            // All comparison operators in C# are binary (take two operands) and the returned result is a Boolean value (true or false).
            // Comparison operators have lower priority than arithmetical operators but higher than the assignment operators.

            // Comparison Operators – Example
            int p = 10, q = 5;
            Console.WriteLine("x > y  : " + (p > q));       // True
            Console.WriteLine("x < y  : " + (p < q));       // False
            Console.WriteLine("x >= y : " + (p >= q));      // True
            Console.WriteLine("x <= y : " + (p <= q));      // False
            Console.WriteLine("x == y : " + (p == q));      // False
            Console.WriteLine("x != y : " + (p != q));      // True
            Console.WriteLine();
        }
    }
}
