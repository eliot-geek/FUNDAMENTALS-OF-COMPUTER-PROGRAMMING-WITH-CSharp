using System;

namespace Less02PassingArgument
{
    internal class Program
    {
        /// <summary>
        /// Modifying the primitive-type parameter
        /// </summary>
        /// <param name="numberParam"></param>
        static void PrintNumber(int numberParam)
        {
            // Modifying the primitive-type parameter
            numberParam = 5;
            Console.WriteLine("in PrintNumber() method, after modification, numberParam is: {0}", numberParam);
        }

        /// <summary>
        /// Modifies the first element of an array that is passed as a parameter
        /// </summary>
        /// <param name="arrParam"></param>
        static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;
            Console.Write("In ModifyArray() the param is: ");
            PrintArray(arrParam);
        }

        /// <summary>
        /// Print array
        /// </summary>
        /// <param name="arrParam"></param>
        static void PrintArray(int[] arrParam)
        {
            Console.Write("[");
            int length = arrParam.Length;
            if (length > 0)
            {
                Console.Write(arrParam[0].ToString());
                for (int i = 1; i < length; i++)
                {
                    Console.Write(", {0}", arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }

        /// <summary>
        /// Method with Multiple Parameters
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            if (number2 > max)
            {
                max = number2;
            }
            Console.WriteLine("Maximal Number: " + max);
        }

        /// <summary>
        /// Method to Show whether a Number is Positive – Example
        /// </summary>
        /// <param name="number"></param>
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        static void PrintNumb(float number)
        {
            Console.WriteLine("The float number is: {0}", number);
        }

        static void Main(string[] args)
        {
            // Passing Arguments of a Primitive Type - If the declared parameter is of a primitive type, the usage of the arguments does not change the argument itself, i.e. the argument value will not change for the code after the method has been invoked.
            int numberArg = 3;
            // Copying the value 3 of the argument numberArg to the parameter numberParam
            PrintNumber(numberArg);
            Console.WriteLine("in the Main() method numberArg is: " + numberArg); Console.ReadLine();


            // Passing Arguments of Reference Type - An array, as any other reference type, consists of a variable-pointer (object reference) and a value – the real information kept in the computer’s memory (we call it an object).
            // Whenever an argument of a reference type is passed to a method, the method’s parameter receives the reference itself. 
            int[] arrArg = new int[] { 1, 2, 3 };
            Console.Write("Before ModifyArray() the argument is: ");
            PrintArray(arrArg);
            // Modifying the array's argument
            ModifyArray(arrArg);
            Console.Write("After ModifyArray() the argument is: ");
            PrintArray(arrArg); Console.ReadLine();

            // By passing the argument that are of reference type, the only thing that is copied is the variable that keeps the reference to the object, but not the object data.
            // If the invoked method modifies the object, to which a reference is passed, this may affect the execution of the code after the method invocation
            // primitive types are passed by their values, the objects, however, are passed by reference.


            // Passing of Expressions as Method Arguments
            PrintSign(2 + 3);
            float oldQuantity = 3;
            float quantity = 2;
            PrintMax(oldQuantity * 5, quantity * 2); Console.ReadLine();

            // Passing of Arguments Compatible with the Parameter Type - We must know that we can pass only arguments that are of type compatible with the related parameter, declared in the method’s parameters list.
            PrintNumb(5); Console.ReadLine();

            // Compatibility of the Method Parameter and the Passed Value 
            // Keeping the Declaration Sequence of the Arguments Types - Values, that are passed to the method, in the time of its invocation, must be in the same order as the
            // parameters are declared in the parameters list. This is due to the method signature.
            // Wrong sequence of arguments - Program.PrintNameAndAge(25, "John");
            Program.PrintNameAndAge("John", 25);
        }

        /// <summary>
        /// Print Name And Age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine("I am {0}, {1} year(s) old.", name, age);
        }
    }
}