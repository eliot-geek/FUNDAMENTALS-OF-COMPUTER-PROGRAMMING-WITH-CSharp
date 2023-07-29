namespace Less04MethodOverload
{
    internal class Program
    {
        static void DrawString(string str)
        {
            // Draw string
        }
        static void DrawInt(int number)
        {
            // Draw integer
        }
        static void DrawFloat(float number)
        {
            // Draw float number
        }

        // Overloads - The method Draw(…) is also called overloaded
        static void Draw(string str)
        {
            // Draw string
        }
        static void Draw(int number)
        {
            // Draw integer
        }
        static void Draw(float number)
        {
            // Draw float number
        }


        // Since we have declared methods with the same name and different signatures, we can invoke each of them as any other method – just by using their name and arguments
        static void PrintNumbers(int intValue, float floatValue)
        {
            Console.WriteLine(intValue + "; " + floatValue);
        }
        static void PrintNumbers(float floatValue, int intValue)
        {
            Console.WriteLine(floatValue + "; " + intValue);
        }


        static void Main(string[] args)
        {
            // Method Overloading - When in a class a method is declared and its name coincides with the name of another method, but their signatures differ by their parameters list
            // we say that there are different variations / overloads of that method (method overloading).

            // Method Parameters and Method Signature - there are only two things required in C# to specify a method signature: the parameter type and the order in which the parameters are listed.
            // The names of the method’s parameters are not significant for the method’s declaration.

            // These two lines will cause an error - because the parameter type in each of their parameters is the same – int and float. So the names of the variables we are using – param1 and param2 or p1 and p2, are not significant
            //static void DoSomething(int param1, float param2) { }
            //static void DoSomething(int p1, float p2) { }

            // If we change the parameter type they will count as two absolutely different methods
            //static void DoSomething(int p1, float p2) { }
            //static void DoSomething(int param1, int param2) { }

            // if we type the same name for the parameters, the compiler will accept this declaration, because they are practically different methods
            //static void DoSomething(int param1, float param2) { }
            //static void DoSomething(int param1, int param2) { }

            // if we declare two variations of the method, but this time we are going to change the order of the parameters instead of their type - The compiler will accept the code again
            //static void DoSomething(int param1, float param2) { }
            //static void DoSomething(float param2, int param1) { }


            // Overloaded Methods Invocation - Which method will be invoked depends on the type of the used parameters
            PrintNumbers(2.71f, 2);
            PrintNumbers(5, 3.14159f);
            Console.ReadLine();

            // The lines will not compile and execute because the compiler tries to convert both integer numbers to suitable types before passing them to any of the methods named PrintNumbers
            // In this case, however, these conversions are not equal. There are two possible options – either to convert the first parameter to float and call the method PrintNumbers(float, int)
            // or to convert the second parameter to float and call the method PrintNumbers(int, float).
            //PrintNumbers(2, 3);
            PrintNumbers((float)2, (short)3); // refer to – PrintNumbers(float, int)
            Console.ReadLine();


            // Methods with Coinciding Signatures - 
            //static int Sum(int a, int b)
            //{
            //    return a + b;
            //}
            //static long Sum(int a, int b)
            //{
            //    return a + b;
            //}
            //Console.WriteLine(Sum(2, 3)); - The code will show an error message upon compilation process,
            //because there are two methods with same parameters lists (i.e. with same signature) which return results of different types.

        }
    }
}