using System;

namespace Less03VariableNumbArg
{
    internal class Program
    {
        /// <summary>
        /// PrintTotalAmountForBooks
        /// </summary>
        /// <param name="prices"></param>
        static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("The total amount of all books is: " + totalAmount);
        }

        /// <summary>
        /// Params PrintTotalAmountForBooks
        /// </summary>
        /// <param name="prices"></param>
        static void PrintTotalAmountForBooksParams(params decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("The total amount of all books is: " + totalAmount);
        }

        /// <summary>
        /// CalcSum
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        static long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // Variable Number of Arguments (var-args)
            decimal[] prices = new decimal[] { 3m, 2.5m };
            PrintTotalAmountForBooks(prices);

            // How to Declare Method with Variable Number of Arguments
            long sum = CalcSum(2, 5);             Console.WriteLine(sum);
            long sum2 = CalcSum(4, 0, -2, 12);    Console.WriteLine(sum2);
            long sum3 = CalcSum();                Console.WriteLine(sum3);
            Console.ReadLine();

            // Variable Number of Arguments: Arrays vs. "params"
            // Now we can invoke our method, with no need to declare in advance an array of number and pass it as an argument
            PrintTotalAmountForBooksParams(3m, 2.5m);
            PrintTotalAmountForBooksParams(1m, 2m, 3.5m, 7.5m);
            Console.ReadLine();

            decimal[] pricesArr = new decimal[] { 3m, 2.5m };
            PrintTotalAmountForBooksParams(pricesArr); // Passing initialized array as var-arg

            // Position and Declaration of a Method with Variable Arguments
            // A method, that has a variable number of its arguments, can also have other parameters in its parameters list.


            // Limitations on the Count for the Variable Arguments - Another limitation, for the methods with variable number of arguments, is that
            // the method cannot have in its declaration more than one parameter that allows passing of variable numbers of arguments.

            // Specifics of Empty Parameter List - 
            PrintTotalAmountForBooksParams(); // The total amount of all books is: 0 - the array decimal[] prices is created, but it is empty.
            Console.ReadLine();

            // Optional Parameters and Named Arguments
            // Optional parameters allow some parameters to be skipped when a method is invoked.
            // Named arguments on their side, allow method parameter values to be set by their name, instead of their exact position in the parameters list.
            // Normal call of SomeMethod
            SomeMethod(1, 2, 3);
            // Omitting z - equivalent to SomeMethod(1, 2, 7)
            SomeMethod(1, 2);
            // Omitting both y and z – equivalent to SomeMethod(1, 5, 7)
            SomeMethod(1); Console.ReadLine();

            // We can pass a value by a particular parameter name, by setting the parameter’s name, followed by a colon and the value of the parameter.
            // Passing z by name and x by position
            SomeMethod(1, z: 3);
            // Passing both x and z by name
            SomeMethod(x: 1, z: 3);
            // Reversing the order of the arguments passed by name
            SomeMethod(z: 3, x: 1); Console.ReadLine();
        }

        /// <summary>
        /// Optional Parameters and Named Arguments
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        static void SomeMethod(int x, int y = 5, int z = 7)
        {
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
        }

        /// <summary>
        /// The element of the parameters list, that allows passing of variable number of arguments by invocation of a method, 
        /// must always be declared at the end of the method’s parameters list.
        /// </summary>
        /// <param name="strParam"></param>
        /// <param name="x"></param>
        static void DoSomething(string strParam, params int[] x)
        {
        }
    }
}