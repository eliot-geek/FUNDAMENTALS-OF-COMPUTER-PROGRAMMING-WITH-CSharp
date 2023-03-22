namespace Ex_08_CurrentDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercice 8 - Write a program that prints on the console the current date and time.

            // Get the current date and time
            DateTime now = DateTime.Now;
            // Print the current date and time to the console
            Console.WriteLine($"The current date and time is: {now}");
        }
    }
}