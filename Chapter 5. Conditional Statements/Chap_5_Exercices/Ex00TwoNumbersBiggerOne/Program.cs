using System;

namespace Ex01TwoNumbersBiggerOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.

            // Prompt the user to enter the first number
            Console.Write("Enter first number : ");
            // Read the first number entered by the user and store it in the 'first' variable
            int first = int.Parse(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Enter second number : ");
            // Read the second number entered by the user and store it in the 'second' variable
            int second = int.Parse(Console.ReadLine());

            // Check if the value of the 'first' variable is greater than the value of the 'second' variable
            if (first > second)
            {
                // If the above condition is true, then swap the values of 'first' and 'second'. Swap logic using arithmetic operations
                first = first + second;     // Add the value of 'first' and 'second' and store the result in 'first'
                second = first - second;    // Subtract the value of 'second' from the updated value of 'first' and store the result in 'second'
                first = first - second;     // Subtract the updated value of 'second' from the updated value of 'first' and store the result in 'first'
            }
            // Print the values of 'first' and 'second' to the console
            Console.WriteLine("First : {0} \nSecond : {1}", first, second);
            Console.ReadKey();




            Console.WriteLine("\nSecond Solution");
            // initialize the first integer variable with a value
            int num1 = 15;
            // initialize the second integer variable with a value
            int num2 = 10;
            Console.WriteLine("Num1: " + num1); // print the value of num1 to the console
            Console.WriteLine("Num2: " + num2); // print the value of num2 to the console

            // check if the first variable is greater than the second
            if (num1 > num2) 
            {
                int temp = num1;    // temporary variable to hold the value of num1
                num1 = num2;        // set num1 to num2
                num2 = temp;        // set num2 to the original value of num1 stored in temp
            }
            Console.WriteLine("\nNum1: " + num1); // print the value of num1 to the console
            Console.WriteLine("Num2: " + num2); // print the value of num2 to the console

            // At this point, if num1 was greater than num2, their values have been exchanged.
            // If num1 was not greater than num2, then nothing was changed and they retain their original values.
        }
    }
}
