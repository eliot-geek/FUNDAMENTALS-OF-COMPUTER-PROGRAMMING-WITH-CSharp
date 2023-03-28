namespace Ex_01_OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks whether an integer is odd or even.
            // Guide : Take the remainder of dividing the number by 2 and check if it is 0 or 1
            // (respectively the number is odd or even). Use % operator to calculate the remainder of integer division.

            // Prompt the user to enter an integer
            Console.Write("Enter an integer: ");
            // Read the user's input from the console and convert it to an integer
            int integer = Convert.ToInt32(Console.ReadLine());
            // Print a message indicating that we are using the first method to check whether the integer is even or odd
            Console.WriteLine("First Method");
            // Use the ternary operator to check whether the integer is even or odd
            bool even = integer % 2 == 0 ? true : false;
            // Print a message indicating whether the integer is even or odd
            Console.WriteLine("{0} is even ? {1}", integer, even);
            Console.ReadKey(); Console.WriteLine();

            // Print a message indicating that we are using the second method to check whether the integer is even or odd
            Console.WriteLine("Second Method");
            // Use the ternary operator to check whether the integer is even or odd
            string evenOdd = integer % 2 == 0 ? "Even" : "Odd";
            // Print a message indicating whether the integer is even or odd. We use string interpolation to insert the value of "integer" and "evenOdd" into the message
            Console.WriteLine("{0} is {1}", integer, evenOdd);
            Console.ReadKey(); Console.WriteLine();

            // Print a message indicating that we are using the third method to check whether the integer is even or odd
            Console.WriteLine("Third Method");
            // Use an if statement to check whether the integer is even or odd
            // If integer % 2 is 0, then integer is even, and we print a message indicating that Otherwise, integer is odd, and we print a message indicating that
            if (integer % 2 == 0)
            {
                Console.WriteLine("{0} is Even", integer);
            }
            else
            {
                Console.WriteLine("{0} is Odd", integer);
            }
            Console.ReadKey(); Console.WriteLine();

        }
    }
}