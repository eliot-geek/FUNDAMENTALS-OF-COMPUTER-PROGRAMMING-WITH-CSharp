using System;

namespace Ex12SumOfPrecision
{
    class Program
    {
        static double AddSum()
        {
            //  initializes the currentValue variable to 0. This variable will be used to store the running total of the sum of fractions.
            double currentValue = 0;
            // declares the oldValue variable without initializing it. This variable will be used to store the previous value of currentValue.
            double oldValue;
            //  initializes the i variable to 1. This variable will be used as a counter in the loop to keep track of the current index in the sum of fractions.
            int i = 1;

            do
            {
                // assigns the current value of currentValue to oldValue. 
                oldValue = currentValue;
                // the code adds the next fraction to the running total of currentValue. The next fraction is determined by the expression (i % 2 == 0) ? (double)-1 / (i + 1) : (double)1 / (i + 1),
                // which uses a ternary operator to determine whether to add or subtract the next fraction based on the parity of i. If i is even, it subtracts 1 divided by i+1.
                // Otherwise, it adds 1 divided by i+1.
                currentValue += (i % 2 == 0) ? (double)-1 / (i + 1) : (double)1 / (i + 1);
                // increments i to move on to the next index in the sum
                i++;
            // the condition !(i != 1 && Math.Abs(currentValue - oldValue) < 0.0001), which uses a logical NOT operator (!) to invert the result of the logical AND operation (&&).The loop continues
            // as long as either i is 1 (so that it calculates at least one term) or the difference between the current and previous values of currentValue is greater than or equal to 0.0001.
            } while (!(i != 1 && Math.Abs(currentValue - oldValue) < 0.0001));

            return currentValue;
        }

        static void Main(string[] args)
        {
            /* Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
            Guide: Accumulate the sum of the sequence in a variable inside a while-loop (see the chapter "Loops"). At each step compare the old sum with the new sum. If the difference between the two 
            sums Math.Abs(current_sum – old_sum) is less than the required precision (0.001), the calculation should finish because the difference is constantly decreasing and the precision 
            is constantly increasing at each step of the loop. The expected result is 1.307. */

            // This is because the AddSum() method calculates the sum of alternating positive and negative fractions starting from i = 1. However, the sequence that needs to be summed actually starts with 1.
            // Therefore, adding 1 to the sum calculated by the AddSum() method adjusts the final result to account for the initial 1 that was not included in the sum of alternating fractions.
            
            double sum = 1 + AddSum(); // calculate infinite sum 
            Console.WriteLine("The Sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …  is {0:N3}", sum);
        }
    }
}
