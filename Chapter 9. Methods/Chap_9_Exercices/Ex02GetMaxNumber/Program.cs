namespace Ex02GetMaxNumber
{
    internal class Program
    {
        /// <summary>
        /// Get Max from two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int GetMax(int a, int b)
        {
            return a >= b ? a : b;
        }

        /// <summary>
        /// Get Max from three numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int GetMax(int a, int b, int c)
        {
            return GetMax(GetMax(a, b), c);
        }

        /// <summary>
        /// Test the GetMax method with some example cases
        /// </summary>
        static void TestGetMax()
        {
            Console.WriteLine("Testing GetMax method...");
            int result1 = GetMax(1, 2);
            Console.WriteLine("GetMax(1, 2) = " + result1); // Expected output: 2
            int result2 = GetMax(3, -1);
            Console.WriteLine("GetMax(3, -1) = " + result2); // Expected output: 3
            int result3 = GetMax(-1, -1);
            Console.WriteLine("GetMax(-1, -1) = " + result3); // Expected output: -1
            int result4 = GetMax(1, 2, 444444);
            Console.WriteLine("GetMax(1, 2, 444444) = " + result4); // Expected output: 444444
            int result5 = GetMax(5, 2, 1);
            Console.WriteLine("GetMax(5, 2, 1) = " + result5); // Expected output: 5
            int result6 = GetMax(-1, 6, 5);
            Console.WriteLine("GetMax(-1, 6, 5) = " + result6); // Expected output: 6
            int result7 = GetMax(0, 0, 0);
            Console.WriteLine("GetMax(0, 0, 0) = " + result7); // Expected output: 0
            int result8 = GetMax(-10, -10, -10);
            Console.WriteLine("GetMax(-10, -10, -10) = " + result8); // Expected output: -10
            int result9 = GetMax(2000000000, -2000000001, 2000000002);
            Console.WriteLine("GetMax(2000000000, -2000000001, 2000000002) = " + result9); // Expected output: 2000000001
            Console.WriteLine("Testing complete.");
        }

        static void Main(string[] args)
        {
            #region Task 02
            /* Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. 
            Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. 
            Write a test program that validates that the methods works correctly.
             
            Guide: Use the expression Max(a, b, c) = Max(Max(a, b), c).
            To test the code check whether the results from the invoked methods is correct for a set of examples that cover the most interesting cases, e.g. 
            Max(1,2)=2; Max(3,-1)=3; Max(-1,-1)=-1; Max(1,2,444444)=444444; Max(5,2,1)=5; Max(-1,6,5)=6; Max(0,0,0)=0; Max(-10,-10,-10)=-10; 
            Max(2000000000,-2000000001,2000000002)=2000000002; etc.
            You may write a generic method that works not just for int but for any other type T using the following declaration: 
            static T Max<T>(T a, T b) where T : IComparable<T> { … }
            Read more about the concept of generic methods in the section “Generic Methods” of chapter “Defining Classes”.
            Instead of creating a program that checks whether the method works correctly, you can search in Internet for information about "unit testing" 
            and write unit tests for your methods. You may also read about unit testing in the section “Unit Testing” of chapter “High-Quality Code”.*/
            #endregion

            // Read three numbers from the console
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());
            // Find the maximum of the three numbers using the GetMax method
            int max = GetMax(GetMax(num1, num2), num3);
            Console.WriteLine("The biggest number is: " + max);
            // Test the GetMax method with some example cases
            TestGetMax();


            Console.WriteLine("\nSecond Solution");
            // Find the maximum of the three numbers using the generic Max method
            int maxi = Max(Max(num1, num2), num3);
            Console.WriteLine("The biggest number is: " + maxi);
            // Test the generic Max method with some example cases
            TestMax();
        }


        /// <summary>
        /// Generic method to find the maximum of two values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        /// <summary>
        /// Overload the generic method to find the maximum of three values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            return Max(Max(a, b), c);
        }

        /// <summary>
        /// Test the generic Max method with some example cases
        /// </summary>
        static void TestMax()
        {
            Console.WriteLine("Testing Max method...");
            int result1 = Max(1, 2);
            Console.WriteLine("Max(1, 2) = " + result1); // Expected output: 2
            int result2 = Max(3, -1);
            Console.WriteLine("Max(3, -1) = " + result2); // Expected output: 3
            int result3 = Max(-1, -1);
            Console.WriteLine("Max(-1, -1) = " + result3); // Expected output: -1
            int result4 = Max(1, 2, 444444);
            Console.WriteLine("Max(1, 2, 444444) = " + result4); // Expected output: 444444
            int result5 = Max(5, 2, 1);
            Console.WriteLine("Max(5, 2, 1) = " + result5); // Expected output: 5
            int result6 = Max(-1, 6, 5);
            Console.WriteLine("Max(-1, 6, 5) = " + result6); // Expected output: 6
            int result7 = Max(0, 0, 0);
            Console.WriteLine("Max(0, 0, 0) = " + result7); // Expected output: 0
            int result8 = Max(-10, -10, -10);
            Console.WriteLine("Max(-10, -10, -10) = " + result8); // Expected output: -10
            int result9 = Max(2000000000, -2000000001, 2000000002);
            Console.WriteLine("Max(2000000000, -2000000001, 2000000002) = " + result9); // Expected output: 2000000002
            Console.WriteLine("Testing complete.");
        }
    }
}