namespace Ex_11_PrintAgeConsole
{
    internal class Program
    {
        // Exercice 11 - Write a program that reads your age from the console and prints your age after 10 years.
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            // Read the user's age from the console and convert it to an integer
            int age = int.Parse(Console.ReadLine());
            // Calculate the user's age after 10 years
            int ageAfter10Years = age + 10;
            // Print the user's age after 10 years
            Console.WriteLine("Your age after 10 years: {0}", ageAfter10Years);


            /* The difference between Parse and Convert.To
             * 
            int.Parse() is a static method of the int class, 
            while Convert.ToInt32() is a method of the Convert class.
            int.Parse() only accepts a string as an argument, 
            while Convert.ToInt32() can accept several different types of arguments, including string, double, float, decimal, long, and object.
            int.Parse() throws a FormatException if the input string is not a valid integer, 
            while Convert.ToInt32() throws a FormatException if the input value is not a valid integer, and a NullReferenceException if the input value is null.
            int.Parse() is slightly faster than Convert.ToInt32() for converting strings to integers.

            In general, if you need to convert a string to a specific data type, it is usually better to use the Parse() method for that data type (for example, int.Parse() 
            or double.Parse()). However, if you need to convert a string to a data type that doesn't have a corresponding Parse() method, or if you need to handle conversion 
            errors more gracefully, then you can use the Convert.ToX() method.
            *
            */

        }
    }
}