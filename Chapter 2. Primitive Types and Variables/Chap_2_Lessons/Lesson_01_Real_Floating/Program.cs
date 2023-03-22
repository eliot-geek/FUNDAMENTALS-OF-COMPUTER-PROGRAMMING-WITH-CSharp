using System;

namespace Lesson_01_Float_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            // Real Floating-Point Types (float and double) 
            /* Real Type Float. This type has precision of 7 significant decimal digits
             * - Negative infinity -∞ (Single.NegativeInfinity). dividing -1.0f by 0.0f.
             * - Positive infinity +∞ (Single.PositiveInfinity). dividing 1.0f by 0.0f.
             * - Uncertainty (Single.NaN) 0.0f by 0.0f
             * 
             * Real Type Double. This type has precision of 15 to 16 decimal digits.
             * - Double.PositiveInfinity (+∞)
             * - Double.NegativeInfinity (-∞) 
             * - Double.NaN (invalid number).
            */

            float floatPI = 3.14f;
            Console.WriteLine(floatPI);
            double doublePI = 3.14;
            Console.WriteLine(doublePI);
            double nan = Double.NaN;
            Console.WriteLine(nan);
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity);

            // Declare some variables
            float fPI = 3.141592653589793238f;
            double dPI = 3.141592653589793238;
            decimal decimalPI = 3.14159265358979323846m;  // Real Types with Decimal Precision

            // Print the results on the console
            Console.WriteLine("Float PI is:   " + fPI);
            Console.WriteLine("Double PI is:  " + dPI);
            Console.WriteLine("Decimal PI is: " + decimalPI);  // Real Types with Decimal Precision


            // Errors in Calculations with Real Types
            // In calculations with real floating-point data types it is possible to observe strange behavior, because during the representation of a given real number it often happens to lose accuracy.
            // Examples of numbers that do not have an accurate representation in float and double types are for instance 0.1, 1/3, 2/7 and other.

            float f = 0.1f; Console.WriteLine(f);  // 0.1 (correct due to rounding)
            double d = 0.1f; Console.WriteLine(d); // 0.100000001490116 (incorrect)
                                                   // - The reason for the unexpected result in the first example is the fact that the number 0.1 (i.e. 1/10)
                                                   // has no accurate representation in the real floating-point number format IEEE 754 and its approximate value is recorded.
                                                   // The rounding is done during the conversion of the number to string in order to be printed on the console. When switching from float to double
                                                   // the approximate representation of the number in the IEEE 754 format is more noticeable. Therefore, the rounding does no longer hide the incorrect
                                                   // representation and we can observe the errors in it after the eighth digit.

            float ff = 1.0f / 3; Console.WriteLine(ff); // 0.3333333 (correct due to rounding)
            double dd = ff; Console.WriteLine(dd);      // 0.333333343267441 (incorrect).
                                                        // The number 1/3 has no accurate representation and is rounded to a number very close to 0.3333333.
                                                        // The value of this number is clearly visible when it is written in double type, which preserves more significant digits.
                                                        // Both examples show that floating-point number arithmetic can produce mistakes, and is therefore not appropriate for precise financial calculations.
                                                        // Fortunately, C# supports decimal precision arithmetic where numbers like 0.1 are presented in the memory without rounding.

            // The decimal floating point-arithmetic type in C# does not lose accuracy when storing and processing floating-point numbers.
            // The real numbers of type decimal are extremely convenient for financial calculations – calculation of revenues, duties, taxes, interests, payments, etc.
            // We use it with precision of 21 digits, which fits in the type decimal without being rounded.
            // As all calculations with data of type decimal are done completely by software, rather than directly at a low microprocessor level, the calculations of this type are from several tens
            // to hundreds of times slower than the same calculations with double, so use this type only when it is really necessary.
        }
    }
}
