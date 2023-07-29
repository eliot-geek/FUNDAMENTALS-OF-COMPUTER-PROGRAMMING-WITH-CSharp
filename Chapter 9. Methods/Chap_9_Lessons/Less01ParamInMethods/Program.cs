namespace Less01ParamInMethods
{
    internal class Program
    {
        /// <summary>
        /// Method to Calculate the Sum of Prices of Books – Example
        /// </summary>
        /// <param name="prices"></param>
        static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }

            Console.WriteLine("Total amount for books: " + totalAmount);
        }

        /// <summary>
        /// Method to Show whether a Number is Positive – Example
        /// </summary>
        /// <param name="number"></param>
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        /// <summary>
        /// Method with Multiple Parameters
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            if (number2 > max)
            {
                max = number2;
            }
            Console.WriteLine("Maximal Number: " + max);
        }


        static void Main(string[] args)
        {
            // Calling Method to Calculate the Sum of Prices of Books 
            decimal[] bookPrices = { 10.99m, 5.49m, 15.25m };
            PrintTotalAmountForBooks(bookPrices); Console.ReadLine();

            // When a method has parameters, its behavior depends upon parameters values.

            // Calling Method to Show whether a Number is Positive
            PrintSign(14); Console.ReadLine();

            // Method with Multiple Parameters
            PrintMax(34f,11f); Console.ReadLine();

            // Difference in Declaration of Methods with Multiple Parameters
            // usage of short way of variable declaration is not allowed - float var1, var2; - static void PrintMax(float var1, var2) - Invalid
            // Correct way - static void PrintMax(float var1, float var2)

            // Invoking Methods with Parameters - Invocation of a method with one or several parameters is done in the same way as invocation of methods without parameters.
            // The difference is that between the brackets following the method name, we place values.
            // These values (called arguments) will be assigned to the appropriate parameters form the declaration

            PrintSign(-5);
            PrintMax(100.0f, 200.0f); Console.ReadLine();

            // Difference between Parameters and Arguments of a Method
            // We call parameters (formal parameters), any of the elements from the parameters list (var1 and varr2) - static void PrintMax(float var1, float var2)
            // When we call a method the values we use to assign to its parameters are named as arguments (-23.5 and 100) - PrintMax(100.0f, -23.5f)

        }
    }
}