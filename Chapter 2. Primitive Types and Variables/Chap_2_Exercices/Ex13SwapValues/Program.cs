namespace Ex13SwapValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.*/

            // Declare two variables of type int
            int firstNumber = 5;
            int secondNumber = 10;
            // Print the initial values of the variables
            Console.WriteLine($"{firstNumber} {secondNumber}");
            // Swap the values of the variables using a temporary variable
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            // Print the swapped values of the variables
            Console.WriteLine($"{firstNumber} {secondNumber}");


            // declare and assign the first variable
            int num1 = 5;
            // declare and assign the second variable
            int num2 = 10;
            // Print the original values
            Console.WriteLine("\nSecond Method \nOriginal values:");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
            // Swap the values
            int temp = num1;
            num1 = num2;
            num2 = temp;
            // Print the new values
            Console.WriteLine("\nSwapped values:");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

            // https://en.wikipedia.org/wiki/XOR_swap_algorithm
        }
    }
}