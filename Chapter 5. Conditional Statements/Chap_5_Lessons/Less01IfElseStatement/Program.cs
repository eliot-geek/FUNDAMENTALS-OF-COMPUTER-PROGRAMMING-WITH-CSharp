using System;

namespace Less01IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional Statements "if" and "if-else"
            // Conditional Statement "if"
            Console.WriteLine("Enter two numbers for comparaison");
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int biggerNumber = firstNumber;
            if (secondNumber > firstNumber)
            {
                biggerNumber = secondNumber;
            }
            Console.WriteLine("The bigger number is : {0}", biggerNumber);

            // Bad practice: misleading code
            int a = 6;
            if(a > 5)
                Console.WriteLine("\nThe variable is greater than 5.");
            Console.WriteLine("This code will always execute!");


            // Conditional Statement "if-else"
            int x = 2;
            if (x > 3)
            {
                Console.WriteLine("\nx is greater than 3");
            }
            else
            {
                Console.WriteLine("\nx is not greater than 3");
            }


            // Nested if else statements
            int first = 5;
            int second = 3;
            if (first == second)
            {
                Console.WriteLine("\nThese two numbers are equal.");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("\nThe first number is greater.");
                }
                else
                {
                    Console.WriteLine("\nThe second number is greater.");
                }
            }
            Console.WriteLine();

            /* Conditional "if" Statements – Good Practices - Here are some guidelines, which we recommend for writing if, structures: 
            - Use blocks, surrounded by curly brackets {} after if and else in order to avoid ambiguity
            - Always format the code correctly by offsetting it with one tab inwards after if and else, for readability and avoiding ambiguity.
            - Prefer switch-case structure to of a series of if-else-if-else-… structures or nested if-else statement, if possible.   */

            // Sequences of if-else-if-else
            char ch = 'X';
            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("Vowel [ei]");
            }
            else if (ch == 'E' || ch == 'e')
            {
                Console.WriteLine("Vowel [i:]");
            }
            else if (ch == 'I' || ch == 'i')
            {
                Console.WriteLine("Vowel [ai]");
            }
            else if (ch == 'O' || ch == 'o')
            {
                Console.WriteLine("Vowel [ou]");
            }
            else if (ch == 'U' || ch == 'u')
            {
                Console.WriteLine("Vowel [ju:]");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            Console.WriteLine();


            // Conditional Statement "Switch-case"
            // The switch statement is a clear way to implement selection among many options. It requires a selector, which is calculated to a certain value.
            // The selector type could be an integer number, char, string or enum.
            // If we want to use for example an array or a float as a selector, it will not work. For non-integer data types, we should use a series of if statements.
            int numb = 6;
            switch (numb)
            {
                case 1:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("The number is not prime");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("The number is prime");
                    break;
                default:
                    Console.WriteLine("Unknown number!");
                    break;
            }
            Console.ReadLine();

            /* Good Practices When Using "switch-case"
            - A good practice when using the switch statement is to put the default statement at the end, in order to have easier to read code.
            - It’s good to place first the cases, which handle the most common situations. Case statements, which handle situations occurring rarely, 
            can be placed at the end of the structure.
            - If the values in the case labels are integer, it’s recommended that they be arranged in ascending order.
            - If the values in the case labels are of character type, it’s recommended that the case labels are sorted alphabetically.
            - It’s advisable to always use a default block to handle situations that cannot be processed in the normal operation of the program. 
            If in the normal operation of the program the default block should not be reachable, you could put in it a code reporting an error. */
        }
    }
}
