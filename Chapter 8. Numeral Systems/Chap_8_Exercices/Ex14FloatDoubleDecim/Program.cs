using System.Diagnostics;

namespace Ex14FloatDoubleDecim
{
    internal class Program
    {
        /// <summary>
        /// PerformCalculationFloat
        /// </summary>
        /// <param name="iterations"></param>
        /// <param name="number"></param>
        static void PerformCalculationFloat(int iterations, float number)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            float result = 0f;

            // Perform the addition loop
            for (int i = 0; i < iterations; i++)
            {
                result += number;
            }

            sw.Stop();

            // Output the result and elapsed time
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Elapsed Time: {sw.Elapsed.TotalMilliseconds} ms");
        }

        /// <summary>
        /// PerformCalculationDouble
        /// </summary>
        /// <param name="iterations"></param>
        /// <param name="number"></param>
        static void PerformCalculationDouble(int iterations, double number)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double result = 0.0;

            // Perform the addition loop
            for (int i = 0; i < iterations; i++)
            {
                result += number;
            }

            sw.Stop();

            // Output the result and elapsed time
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Elapsed Time: {sw.Elapsed.TotalMilliseconds} ms");
        }

        /// <summary>
        /// PerformCalculationDecimal
        /// </summary>
        /// <param name="iterations"></param>
        /// <param name="number"></param>
        static void PerformCalculationDecimal(int iterations, decimal number)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            decimal result = 0.0m;

            // Perform the addition loop
            for (int i = 0; i < iterations; i++)
            {
                result += number;
            }

            sw.Stop();

            // Output the result and elapsed time
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Elapsed Time: {sw.Elapsed.TotalMilliseconds} ms");
        }


        static void Main(string[] args)
        {
            #region Task 14
            // Try adding up 50,000,000 times the number 0.000001. Use a loop and addition (not direct multiplication). Try it with float and double and after that with decimal.
            // Do you notice the huge difference in the results and speed of calculation? Explain what happens.

            // Guide: If you execute the calculations correctly, you will get 32.00 (for float), 49.9999999657788 (for double) and 50.00 (for decimal) respectively.
            // The differences come from the fact that 0.000001 has no exact representation as float and double.
            // You may notice also that adding decimal values is at least 10 times slower than adding double values.
            #endregion

            int iterations = 50000000;
            float floatNumber = 0.000001f;
            double doubleNumber = 0.000001;
            decimal decimalNumber = 0.000001m;

            // Calculate and compare using float
            Console.WriteLine("Calculating using float...");
            PerformCalculationFloat(iterations, floatNumber);

            // Calculate and compare using double
            Console.WriteLine("\nCalculating using double...");
            PerformCalculationDouble(iterations, doubleNumber);

            // Calculate and compare using decimal
            Console.WriteLine("\nCalculating using decimal...");
            PerformCalculationDecimal(iterations, decimalNumber);
            Console.ReadLine();

            /*  Explanation 
            Float: The float data type has limited precision, approximately 7 decimal places, which causes a loss of precision when repeatedly adding small values. 
            This leads to noticeable rounding errors, and the result will not be accurate.
            Double: The double data type provides more precision than float, approximately 15-16 decimal places. 
            Although it is more accurate than float, there can still be some rounding errors when repeatedly adding very small values.
            Decimal: The decimal data type provides the highest precision, approximately 28-29 decimal places. 
            It is ideal for financial and monetary calculations that require high accuracy and avoids the rounding errors that occur in float and double.
            


            Float: The result will not be accurate due to precision limitations, and you will notice some rounding errors in the output. 
            The calculation speed will be relatively fast.
            Double: The result will be more accurate than float but still may have some rounding errors due to the precision limitations of double. 
            The calculation speed will be faster than decimal but slower than float.
            Decimal: The result will be the most accurate since the decimal data type offers higher precision. 
            You will not notice any rounding errors, and the calculation speed will be slower compared to float and double due to its higher precision and larger size.
            */
        }
    }
}