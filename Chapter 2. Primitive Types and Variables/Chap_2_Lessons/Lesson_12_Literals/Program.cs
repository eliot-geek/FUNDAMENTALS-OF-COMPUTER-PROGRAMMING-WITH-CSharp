namespace Lesson_12_Literals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Literals - Primitive types, which we already met, are special data types built into the C# language. Their values specified in the source code of the program are called literals.

            bool result = true;
            char capitalC = 'C';
            byte b = 100;
            short s = 20000;
            int i = 3000000;

            // literals are true, 'C', 100, 20000 and 300000. They are variable values set directly in the source code of the program.
            // Types of Literals (Boolean, Integer, Real, Character, String, Object literal null)
            // Boolean Literals (true and false)

                // Integer Literals
            // In the integer literals the following prefixes and suffixes may take part: 
            //  -"0x" and "0X" as prefix indicates hexadecimal values, for example 0xA8F1;
            //  -'l' and 'L' as suffix indicates long type data, for example 357L.
            //  - 'u' and 'U' as suffix indicates uint or ulong data type, for example 112u.
            //  By default(if no suffix is used) the integer literals are of type int.

                // Integers Literals - Examples
            // The following variables are initialized with the same value
            int numberInDec = 16;  
            int numberInHex = 0x10;  
            Console.WriteLine(numberInDec + " " + numberInHex); // 16
                                                                // int longInt = 234L; // This will cause an error, because the value 234L is not int 

                // Real Literals 
            // Real literals are a sequence of digits, a sign (+, -), suffixes and the decimal point character. We use them for values of type float, double and decimal.
            //  -'f' and 'F' as suffixes mean data of type float;
            //  -'d' and 'D' as suffixes mean data of type double;
            //  -'m' and 'm' as suffixes mean data of type decimal;
            //  -'e' is an exponent, for example, "e-5" means the integer part multiplied by 10 - 5.
            //  By default(if there is no suffix), the real numbers are of type double.

                // Real Literals – Examples
            // The following is the correct way of assigning a value:
            float realNumber = 12.5f;
            // This is the same value in exponential format:
            realNumber = 1.25e+1f;
            // The following causes an error, because by defaut 12.5 is double
            // float realNumber2 = 12.5;

            // Character Literals
            // Character literals are single characters enclosed in apostrophes(single quotes). The value of a character literal can be:
            //  -a character, for example 'A';
            //  -a character code, for example '\u0065';
            //  -an escaping sequence
        }
    }
}