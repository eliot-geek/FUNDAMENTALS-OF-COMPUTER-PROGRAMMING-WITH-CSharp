using static System.Formats.Asn1.AsnWriter;
using System.Dynamic;

namespace Less05TriangDiffSize
{
    internal class Program
    {
        /// <summary>
        /// Triangle
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            // Printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            // Printing the bottom part of the triangle that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }

        static void Main(string[] args)
        {
            #region Triangles with Different Size 
            /* Let’s assume we want to write a program, which prints triangles on the console, as those shown below:
            n = 5
            1
            1 2
            1 2 3
            1 2 3 4
            1 2 3 4 5
            1 2 3 4
            1 2 3
            1 2
            1
            n = 6
            1
            1 2
            1 2 3
            1 2 3 4
            1 2 3 4 5
            1 2 3 4 5 6
            1 2 3 4 5
            1 2 3 4
            1 2 3
            1 2
            1
            */
            #endregion

            // Entering the value of the variable n
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            // Printing the bottom part of the triangle that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
            Console.ReadLine();


            // Another method - We can improve the program
            Console.Write("n1 = ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            PrintTriangle(n1);
            Console.ReadLine();


            // Returning a Result from a Method - Methods usually do not just execute a simple code sequence, but in addition they often return results
            // Declaring a Method that Returns a Result - static <return_type> <method_name>(<parameters_list>) - 
            // static double CalcSquareSurface(double sideLength) - a method that calculates the area of a square and instead of printing it to the console returns it as a result

            // Assigning to a Variable - We can also assign the result of the method execution to a variable of an appropriate type
            // GetCompanyLogo() returns a string - string companyLogo = GetCompanyLogo();

            // Usage in Expressions - After a method returns a result, it can be used then in expressions too
            // float totalPrice = GetSinglePrice() * quantity;

            // Using the Returned Value as Method Parameter - We can pass the result from the method execution as value in the parameters list from another method
            // Console.WriteLine(GetCompanyLogo());

            // Returned Value Type - the result that a method returns can be of any type – int, string, array and so on
            // When we use the keyword void instead of a type, this mean that method does not return value

            // The Operator "return" - To make a method return value, the keyword return must be placed in the method’s body, followed by an expression that will be returned as a result by the method
            //static long Multiply(int number1, int number2)
            //{
            //    long result = number1 * number2;
            //    return result; - by using the return the method will produce as a result of its execution the integer variable result
            //}

            // Compatibility of the Result and the Retuning Type - The result returned by the method, can be of a type that is compatible
            // (the one that can be implicitly converted) with the type of the returned value <return_type>.
            //static float Multiply(int number1, int number2)
            //{
            //    int result = number1 * number2;
            //    return result;
            //}
            // the result will be of type int. Even though the type of the expression after the return keyword is not of type float, it can be returned,
            // because it can be implicitly converted to float.

            // Using an Expression after the Return Operator - It is allowed to directly put some expression after the keyword return
            //static int Multiply(int number1, int number2)
            //{
            //    return number1 * number2;
            //}


            // Features of the Return Operator
            // The execution of return does two things:
            // -Stops immediately the method execution.
            // -Returns the result of the executed method to the calling method - we should not put any code after the return operation.
            //static int Add(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //    // Let’s try to "clean" the result variable here:
            //    result = 0;
            //}


            // When the method has void for returned value type, then after return, there would be no expression to be returned.
            // In that case return usage is only used to stop the method’s execution
            //static void PrintPositiveNumber(int number)
            //{
            //    if (number <= 0)
            //    {
            //        // If the number is NOT positive, terminate the method
            //        return;
            //    }
            //    Console.WriteLine(number);
            //}


            // Multiple Return Statements - The last thing that must be said about the operator return is that it can be called from several places in the code of our method,
            // but should be guaranteed that at least one of the operators return that we have used, will be reached while executing the method.


            // Why Is the Returned Value Type not a Part of the Method Signature?
            // In C# it is not allowed to have several methods that have equal name and parameters, but different type of returned value.
            // This means that the following code will fail to compile
            //static int Add(int number1, int number2)
            //{
            //    return (number1 + number2);
            //}
            //static double Add(int number1, int number2)
            //{
            //    return (number1 + number2);
            //}
            // The reason for this limitation is that the compiler doesn’t know which of both methods must be invoked.
            // Both methods have the same signature (sequence of parameters along with their types).

        }

        /// <summary>
        /// Multiple Return Statements
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        static int CompareTo(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 == number2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}