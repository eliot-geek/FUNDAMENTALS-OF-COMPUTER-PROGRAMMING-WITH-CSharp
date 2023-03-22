namespace Ex_09_SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercice 9 - Write a program that prints the square root of 12345.

            // Define the number to take the square root of
            int number = 12345;
            // Calculate the square root of the number
            double squareRoot = Math.Sqrt(number);
            // Print the square root to the console with a message
            Console.WriteLine($"The square root of {number} is: {squareRoot}");
            Console.WriteLine(Math.Sqrt(12345));
        }
    }
}