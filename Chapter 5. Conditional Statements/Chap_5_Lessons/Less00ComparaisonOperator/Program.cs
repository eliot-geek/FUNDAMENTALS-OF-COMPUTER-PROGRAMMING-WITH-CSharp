using System;

namespace Less00ComparaisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Operator Action
                == Equal to
                != Not equal to
                >  Greater than
                >= Greater than or equal to
                <  Less than
                <= Less than or equal to 

            In C# several types of data that can be compared:
            - numbers (int, long, float, double, ushort, decimal, …)
            - characters (char)
            - Booleans (bool)
            - References to objects, also known as object pointers (string, object, arrays and others)      */

            int weight = 700;                               // True
            Console.WriteLine(weight >= 500);               // False
            char gender = 'm';                              
            Console.WriteLine(gender <= 'f');               // True
            double colorWaveLength = 1.630;                 
            Console.WriteLine(colorWaveLength > 1.621);     // True
            int a = 5;
            int b = 7;
            bool condition = (b > a) && (a + b < a * b); 
            Console.WriteLine(condition);                   // True
            // characters are compared by their lexicographical order (the operation uses the Unicode numbers for the corresponding characters)
            Console.WriteLine('B' == 'A' + 1);              // True

            // Comparaison of Integers and Characters
            // When comparing integers and characters, we directly compare their binary representation in memory i.e. we compare their values
            
            Console.WriteLine("\nchar 'a' == 'a'? " + ('a' == 'a'));  // True
            Console.WriteLine("char 'a' == 'b'? " + ('a' == 'b'));    // False
            Console.WriteLine("5 != 6? " + (5 != 6));                 // True
            Console.WriteLine("5.0 == 5L? " + (5.0 == 5L));           // True
            Console.WriteLine("true == false? " + (true == false));   // False

            /* Comparaison of References to Objects
            There are reference data types that do not contain their value(unlike the value types), but contain the address of the memory in the heap where their value is located.
            Strings, arrays and classes are such types. They behave like a pointer to some value and can have the value null, i.e.no value.
            When comparing reference type variables, we compare the addresses they hold, i.e.we check whether they point to the same location in the memory, i.e.to the same object.*/
            string str = "beer";
            string anotherStr = str; 

            // == does not compare the content of the objects but rather checks if they point at the same location in memory, i.e. if they are one and the same object.
            // The size comparisons (<, >, <= and >=) are not applicable for object type variables.
            string thirdStr = "bee";
            thirdStr = thirdStr + 'r';
            Console.WriteLine("\nstr = {0}", str);
            Console.WriteLine("anotherStr = {0}", anotherStr);
            Console.WriteLine("thirdStr = {0}", thirdStr);
            Console.WriteLine(str == anotherStr);                   // True - same object
            Console.WriteLine(str == thirdStr);                     // True - equal objects
            Console.WriteLine((object)str == (object)anotherStr);   // True  // The variable anotherStr is also reference type and gets the address (the reference) of str, i.e. points to the existing object str.
            Console.WriteLine((object)str == (object)thirdStr);     // False // The two objects str and thirdStr have equal values, but are different objects, located at separate addresses in the memory.
            Console.ReadKey();
            // The operator == compares the strings by value and not by address. However, if we convert the three variables to objects and then compare them,
            // we will get a comparison of the addresses in the heap where their values are located and the result will be different.
            // Operator == has a special behavior when comparing strings, but for the rest of the reference types (like arrays or classes) it applies comparison by address.

            // Logical Operators are: &&, ||, ! and ^
            // The logical operators && (logical AND) and || (logical OR) are only used on Boolean expressions (values of type bool).
            // && is also called short-circuit logical operator "and" because it does not lose time in additional unnecessary calculations 
            // if the first operand is false, it does not lose time for evaluating the second operand it’s not possible the end result to be "true" when the first operand is not "true".
            // || also called short-circuit logical operator "or" for the same reason
            bool result = (2 < 3) && (3 < 4);
            bool resul = (2 < 3) || (1 == 2);
            Console.WriteLine(result);          // True
            Console.WriteLine(resul);           // True

            // Logical Operators & and | - both operands are calculated one after the other, although the final result is known in advance.
            // That’s why these comparison operators are also known as full-circuit logical operators and are used very rarely.

            // Logical Operators ^ and ! - The ^ operator, also known as exclusive OR (XOR), belongs to the full-circuit operators, because both operands are
            // calculated one after the other. The result of applying the operator is true if exactly one of the operands is true, but not both simultaneously.
            Console.WriteLine("Exclusive OR: " + ((2 < 3) ^ (4 > 3)));      // False
            // The operator ! returns the reversed value of the Boolean expression to which it is attached
            bool value = !(7 == 5);
            Console.WriteLine(value);           // True
            Console.ReadKey();
        }
    }
}
