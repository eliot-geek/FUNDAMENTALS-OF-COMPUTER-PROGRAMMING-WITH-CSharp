namespace Ex01SayHelloName
{
    internal class Program
    {
        /// <summary>
        /// First Method
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
            return name;
        }

        /// <summary>
        /// Second Method
        /// </summary>
        /// <param name="name"></param>
        static void PrintHelloWithName(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        static void Main(string[] args)
        {
            #region Task 01
            /*  Write a code that by given name prints on the console "Hello, <name>!" (for example: "Hello, Peter!").
            Guide: Use a method that takes the name as parameter of type string.*/
            #endregion

            // Get the name from the user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Call the method to print the greeting
            PrintHelloWithName(name);
            PrintName(name);
        }
    }
}