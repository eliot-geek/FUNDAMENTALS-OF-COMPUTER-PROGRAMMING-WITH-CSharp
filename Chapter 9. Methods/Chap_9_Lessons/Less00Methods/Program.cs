namespace Less00Methods
{
    internal class Program
    {
        /// <summary>
        /// method that calculates rectangle’s area - it can be accessed directly through the class without creating an instance of the class.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        /// <summary>
        /// PrintLogo
        /// </summary>
        static void PrintLogo()
        { 
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
        }

        static void Main(string[] args)
        {
            /* A method is a basic part of a program. It can solve a certain problem, eventually take parameters and return a result. 
            To solve a certain task, especially if it is a complex one, the problem we solve must be divided into small subproblems.
            Taken separately they are well defined and easy to be resolved compared to the original problem. At the end by finding solutions for all the small problems we solve the complex one */

            double area = GetRectangleArea(5.0, 10.0);
            Console.WriteLine(area);
            Console.ReadLine();

            /*
             Why to Use Methods?
             - Better Structured Program and More Readable Code
             - Avoid Duplicated Code

             How to Declare, Implement and Invoke a Method?
             Three different actions related to existing of a method: declaring, implementation (creation) and calling of a method.
             Method Declaration - [static] <return_type> <method_name>([<param_list>])

             Modifiers - A modifier is a keyword in C#, which gives additional information to the compiler for a certain code.
             Method can NOT be declared inside the body of another method.
             Whenever we declare a variable inside the body of a method, we call that variable local variable for the method. */

            PrintLogo();

            // When a method executes it takes control over the program.
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
            PrintCompanyInformation();
        }

        static void PrintCompanyInformation()
        {
            // Invoking the PrintLogo() method
            PrintLogo();
            Console.WriteLine("Address: One, Microsoft Way");
        }
    }
}