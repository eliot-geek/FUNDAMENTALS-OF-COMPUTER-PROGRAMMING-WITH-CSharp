namespace Ex03BiggestOfThreeInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the biggest of three integers, using nested if statements.
            // Guide : Use nested if-statements, first checking the first two numbers then checking the bigger of them with the third.

            // Prompt user to enter three integers
            Console.Write("Enter first integer : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer : ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer : ");
            int third = int.Parse(Console.ReadLine());

            // Check if the first integer is greater than the second integer
            if (first >= second)
            {
                // Check if the first integer is greater than the third integer
                if (first >= third)
                {
                    Console.WriteLine("The biggest of three is : {0}", first);
                }
                else
                {
                    Console.WriteLine("The biggest of three is : {0}", third);
                }
            }
            else
            {
                // Check if the second integer is greater than the third integer
                if (second >= third)
                {
                    Console.WriteLine("The biggest of three is : {0}", second);
                }
                else
                {
                    Console.WriteLine("The biggest of three is : {0}", third);
                }
            }
            Console.ReadKey();


            Console.WriteLine("\n\nSecond Solution");
            // Prompt the user to enter three numbers
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            // Check which of the three numbers is the largest
            if (a > b) // Check if a is greater than b
                if (a > c) Console.WriteLine("A is the biggest");       // Check if a is greater than c
                else if (a < c) Console.WriteLine("C is the biggest");  // Check if c is greater than a
                else Console.WriteLine("A and C are the biggest");      // a and c are equal, and greater than b
            else if (a < b) // a is less than b
                if (b > c) Console.WriteLine("B is the biggest");       // Check if b is greater than c
                else if (b < c) Console.WriteLine("C is the biggest");  // Check if c is greater than b
                else Console.WriteLine("B and C are the biggest");      // b and c are equal, and greater than a
            else if (a == b) // a is equal to b
                if (a == c) Console.WriteLine("All are equal");         // a, b, and c are equal
                else if (a < c) Console.WriteLine("C is the biggest");  // c is greater than a and b
                else Console.WriteLine("A and B are the biggest");      // a and b are equal, and greater than c
        }
    }
}