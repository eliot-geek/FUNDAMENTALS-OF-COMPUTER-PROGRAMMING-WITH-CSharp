namespace Ex03CompareNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Write a program, which compares correctly two real numbers with accuracy at least 0.000001. 

           Guidelines: Two floating-point variables are considered equal if their difference is less than some predefined precision 
           (e.g. 0.000001): bool equal = Math.Abs(a - b) < 0.000001;
            */

            float numb1 = 14.456729f;                           // Declare and initialize the first float variable
            float numb2 = 14.456729f;                           // Declare and initialize the second float variable
            bool equal = Math.Abs(numb1 - numb2) < 0.000001;    // Compute the absolute difference and compare it with the precision value
            Console.WriteLine(equal);                           // Output whether the two floats are equal or not with the given precision


            float number1 = 14.456729366f;                              // Declare and initialize the first float variable
            float number2 = 14.456729376f;                              // Declare and initialize the second float variable
            bool equal1 = Math.Abs(number1 - number2) < 0.000001;       // Compute the absolute difference and compare it with the precision value
            Console.WriteLine(equal1);                                  // Output whether the two floats are equal or not with the given precision


            Console.WriteLine("\nAnother method");
            double num1 = 1.23456789;   // Declare and initialize the first double variable
            double num2 = 1.23456788;   // Declare and initialize the second double variable
            double epsilon = 0.000001;
            // Compare the absolute difference of the two numbers with the specified epsilon value
            if (Math.Abs(num1 - num2) < epsilon)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }
    }
}