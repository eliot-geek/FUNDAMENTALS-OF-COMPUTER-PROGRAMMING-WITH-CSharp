using System;
using System.Runtime.Intrinsics.X86;

namespace Less01ReadAndReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Input - The standard input device is the part of the operating system that controls from where the program will receive its input data.
            // The class Console provides two methods Console.Read() and Console.ReadLine() that run on this stream and usually reading from the console is done by them.
            // Reading through Console.ReadLine()
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName); Console.ReadKey();

            // Reading through Console.Read() - As a beginning it reads only one character and not the entire line. 
            // The other significant difference is that the method does not return directly the read character but its code.
            // If we want to use the result as a character we must convert it to a character or use the method Convert.ToChar() on it.
            // There is one important characteristic: the character is read only when the [Enter] key is pressed.
            int codeRead = 0;
            do
            {
                Console.Write("\nEnter: ");
                codeRead = Console.Read();
                if (codeRead != 0)
                {
                    Console.Write((char)codeRead); // If we want to use the result as a character we must convert it to a character or use the method Convert.ToChar() on it.
                }
            }
            while (codeRead != 10); Console.ReadKey();

            Console.Write("\nEnter: ");      // 457
            int codeRead1 = Console.Read();
            Console.WriteLine(codeRead1);   // 52  - The code for the character '4' in ASCII (American Standard Code for Information Interchange) is 52 in decimal, or 0x34 in hexadecimal.
            Console.ReadKey();

            // Reading Numbers
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.Write("f = ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} / {2} = {3}", a, b, f, a * b / f); Console.ReadKey();

            Console.WriteLine();
            Console.Write("Enter a floating point number: ");
            string line = Console.ReadLine();
            double number = double.Parse(line);
            Console.WriteLine("You entered: {0}", number);

            // Parsing Numbers Conditionally
            // When parsing a sting can be done in two ways:
            // - by catching exceptions(see the chapter "Exception Handling");
            // - by conditional parsing(using the method TryParse(…)).

            Console.WriteLine();
            Console.Write("Enter a number: ");
            string str = Console.ReadLine();
            int intValue;
            bool parseSuccess = Int32.TryParse(str, out intValue);
            Console.WriteLine(parseSuccess ? "The square of the number is " + intValue * intValue + "." : "Invalid number!");

            // TryParse() as a result of its work returns simultaneously two values: the parsed number (as an output parameter) and a Boolean value as a result of the method invocation.
            // Returning multiple values at once is possible because one of the values is returned as an output parameter (out parameter).
            // When calling a method the output parameters must be preceded by the keyword out.
            // When calling a method the output parameters must be preceded by the keyword out.
        }
    }
}
