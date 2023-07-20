namespace Less02IntegerTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer Types in C# - The most commonly used integer type is int. It is represented as a 32-bit number with two’s complement and takes a value in the range [-231, 231-1].

            int integerValue = 25; Console.WriteLine(integerValue);
            int integerHexValue = 0x002A; Console.WriteLine(integerHexValue); // 42
            int ybin = Convert.ToInt32("1001", 2); Console.WriteLine(ybin); // Converts binary to int - 9

            // The type long is the largest signed integer type in C#. It has a size of 64 bits (8 bytes).
            long longValue = 9223372036854775807L; Console.WriteLine(longValue);
            long newLongValue = 932145699054323689l; Console.WriteLine(newLongValue);
            byte count = 50; Console.WriteLine(count);
            ushort pixels = 62872; Console.WriteLine(pixels);
            uint points = 4139276850; Console.WriteLine(points); // or 4139276850u, 4139276850U
            ulong y = 18446744073709551615; Console.WriteLine(y); // or UL, ul, Ul, uL, Lu, lU

            // Big-Endian and Little-Endian Representation
            // Little-Endian (LE) and Big-Endian (BE) 

            // Representing Real Floating-Point Numbers - https://en.wikipedia.org/wiki/IEEE_754
            // Representing Floating-Point Numbers – Example

            //The Float and Double Types in C# - In C#, floating-point numbers literals by default are of the double type.
            float total = 5.0f; Console.WriteLine(total);
            float result = 5.0f; Console.WriteLine(result);
            double sum = 10.0; Console.WriteLine(sum);
            double div = 35.4 / 3.0; Console.WriteLine(div);
            double x = 5d; Console.WriteLine(x);

            double d = 0;
            Console.WriteLine(d);           // 0.0
            Console.WriteLine(1 / d);       // Infinity
            Console.WriteLine(-1 / d);      // -Infinity
            Console.WriteLine(d / d);       // NaN

            // Errors When Using Floating-Point Numbers
            // For example when adding up 1000 items with a unit price of 0.1 EUR each, we should get a sum of 100 EUR but if we use a 32-bit floating-point numbers for the
            // calculations the result will be 99.99905. Here is C# example in action, which proves the errors caused by the inaccurate presentation of decimal real numbers in the binary numeral system
            float summ = 0f;
            for (int i = 0; i < 1000; i++)
            {
                summ += 0.1f;
            }
            Console.WriteLine("Sum = {0}", summ); // Summ = 99.99905

            // Precision of Floating-Point Numbers
            double summa = 0.0;
            for (int i = 1; i <= 10; i++)
            {
                summa += 0.1;
            }
            Console.WriteLine("{0:r}", summa); // we use the round-trip format specifier "{0:r}" to print the exact (not rounded) value contained in the variable,
            Console.WriteLine(summa);
            // Let’s replace double with float: If we execute the code above, we will get an entirely different sum 

            // Double and Float types have a field called Epsilon, which is a constant, and it contains the smallest value larger than zero, which can be represented by an instance
            // of System.Single or System.Double respectively. Each value smaller than Epsilon is considered to be equal to 0. For example, if we compare two numbers, which are different after all,
            // but their difference is smaller than Epsilon, they will be considered equal.
        }
    }
}