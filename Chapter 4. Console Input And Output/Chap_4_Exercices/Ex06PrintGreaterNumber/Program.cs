using System;

namespace Ex06PrintGreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
            Guide: Since the problem requires a solution, which does not use conditional statements, you should use a different approach. 
            Two possible solutions of the problem include the use of functions of class Math. The greater of the two numbers you can find 
            with the function Math.Max(a, b) and the smaller with Math.Min(a, b).
            Another solution to the problem includes usage of the function for taking the absolute value of a number Math.Abs(a):
            int a = 2011;
            int b = 1990;
            Console.WriteLine("Greater: {0}", (a + b + Math.Abs(a-b)) / 2);
            Console.WriteLine("Smaller: {0}", (a + b - Math.Abs(a-b)) / 2); */

            // The greater of the two numbers you can find with the function Math.Max(a, b) and the smaller with Math.Min(a, b).
            Console.WriteLine("Solution");
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            // Read the user input as a string, parse it to a double, and store it in the variable firstNum
            double firstNum = double.Parse(Console.ReadLine());
            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            // Read the user input as a string, parse it to a double, and store it in the variable secondNum
            double secondNum = double.Parse(Console.ReadLine());
            // Use the Math.Max function to find the greater of the two numbers and store it in the variable result
            double resultMax = Math.Max(firstNum, secondNum);
            double resultMin = Math.Min(firstNum, secondNum);
            // Print the result by using Console.WriteLine() to display a message that includes the greater number
            Console.WriteLine("The greater number is {0}.", resultMax); 
            Console.WriteLine("The smaller number is {0}.", resultMin); 
            Console.WriteLine(); Console.ReadKey();

            // Usage of the function for taking the absolute value of a number Math.Abs(a)
            Console.WriteLine("Solution");
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            // Read the user input as a string, parse it to a double, and store it in the variable secondNum
            double a = double.Parse(Console.ReadLine());
            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            // Read the user input as a string, parse it to a double, and store it in the variable firstNum
            double b = double.Parse(Console.ReadLine());
            // Use the formula (a + b + abs(a - b)) / 2 to find the greater of the two numbers and store it in the variable result
            Console.WriteLine("Greater: {0}", (a + b + Math.Abs(a - b)) / 2);
            Console.WriteLine("Smaller: {0}", (a + b - Math.Abs(a - b)) / 2); Console.ReadKey();

            /* The formula (a + b + Math.Abs(a - b)) / 2 is a way to find the maximum value between two numbers a and b, without using any conditional statements. Here's how it works:
            The expression Math.Abs(a - b) calculates the absolute difference between a and b. This ensures that the result is always positive, regardless of which number is larger.
            The expression (a + b + Math.Abs(a - b)) calculates the sum of a, b, and the absolute difference between a and b. This sum will always be twice the value of the greater number, 
            since the absolute difference between a and b is equal to the difference between the greater number and the smaller number.
            The expression (a + b + Math.Abs(a - b)) / 2 divides the sum by 2 to get the greater number.
            For example, if a = 5 and b = 3, then Math.Abs(a - b) = Math.Abs(5 - 3) = 2. The sum (a + b + Math.Abs(a - b)) is equal to 5 + 3 + 2 = 10, which is twice the value of a. 
            Dividing the sum by 2 gives 10 / 2 = 5, which is the greater number.
            Note that this formula only works for finding the maximum of two numbers, and cannot be used to find the maximum of more than two numbers. */

            // The third solution uses bitwise operations
            Console.WriteLine("\nSolution");
            Console.Write("Enter first : ");
            int first = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second : ");
            int second = Int32.Parse(Console.ReadLine());
            int max = first - ((first - second) & ((first - second) >> 31));
            Console.WriteLine("Greater is : " + max); Console.ReadKey();

            /* The formula int max = first - ((first - second) & ((first - second) >> 31)); is a bitwise manipulation technique to find the maximum value between two integers first and second, 
             * without using any conditional statements. Here's how it works:
            The expression first - second calculates the difference between first and second.
            The expression ((first - second) >> 31) shifts the result of the subtraction 31 bits to the right, which moves the sign bit to the least significant bit. If first is greater than or equal 
            to second, the sign bit is 0 and the result is 0; otherwise, the sign bit is 1 and the result is -1 (represented by all 1's in binary).
            The expression ((first - second) & ((first - second) >> 31)) performs a bitwise AND operation between the difference and the shifted result. If first is greater than or equal to second, 
            the result is equal to the difference (since the shifted result is 0); otherwise, the result is equal to 0 (since the shifted result is -1 and the AND operation with the difference yields 0).
            Finally, subtracting the result of step 3 from first gives the maximum value between first and second.
            For example, if first = 5 and second = 3, then first - second = 2 and (first - second) >> 31 = 0. Performing the bitwise AND operation between the difference and the shifted result gives 2 & 0 = 0, which is the same as the value of the difference. Subtracting the result from first gives 5 - 0 = 5, which is the maximum value.
            Note that this formula only works for finding the maximum of two integers, and cannot be used to find the maximum of more than two integers. Also note that this method 
            may not necessarily be more efficient than using conditional statements, as bitwise operations can sometimes be slower than logical operations.*/

            // Hidden conditional statement (the ternary ?: operator):
            Console.WriteLine("\nSolution");
            Console.Write("Enter one : ");
            int one = Int32.Parse(Console.ReadLine());
            Console.Write("Enter two : ");
            int two = Int32.Parse(Console.ReadLine());
            int maxNumb = one > two ? one : two; 
            Console.WriteLine("Greater is : " + maxNumb); Console.ReadKey();

            /* This formula is a shorthand way of writing an if-else statement. It first checks if one is greater than two using the ternary operator ?, which acts as a shorthand if-else statement. 
            If one is indeed greater than two, then the expression one is returned as the value of maxNumb, since the condition before the ? is true. If one is not greater than two, 
            then the expression two is returned as the value of maxNumb, since the condition before the ? is false and the expression after the : is evaluated instead. This formula effectively 
            selects the greater of the two numbers and assigns it to maxNumb. */
        }
    }
}
