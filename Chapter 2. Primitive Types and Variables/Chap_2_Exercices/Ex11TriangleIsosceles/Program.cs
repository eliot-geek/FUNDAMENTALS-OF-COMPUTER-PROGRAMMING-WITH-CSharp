namespace Ex11TriangleIsosceles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".*/

            //  setting the output encoding of the console to UTF-8 encoding using the UTF8 property of the Encoding class in the System.Text namespace.
            //  UTF-8 is a character encoding that can represent all possible characters in Unicode

            Console.WriteLine("First Method");
            // Set the output encoding of the console to UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char ch = '\u00A9';
            string str1 = "    " + ch;
            string str2 = "   " + ch + ch + ch;
            string str3 = "  " + ch + ch + ch + ch + ch;
            string str4 = " " + ch + ch + ch + ch + ch + ch + ch;
            string str5 = "" + ch + ch + ch + ch + ch + ch + ch + ch + ch;
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);


            Console.WriteLine("\nSecond Method");
            Console.WriteLine("    ©");
            Console.WriteLine("   ©©©");
            Console.WriteLine("  ©©©©©");
            Console.WriteLine(" ©©©©©©©");
            Console.WriteLine("©©©©©©©©©");


            Console.WriteLine("\nThird Method");
            // Set the output encoding of the console to UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = 6; // number of rows
            for (int i = 1; i <= n; i++)
            {
                // Print spaces before the copyright symbol
                // The number of spaces decreases with each row
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                // Print the copyright symbol
                // The number of copyright symbols increases with each row
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("©");
                }
                // move to the next line
                Console.WriteLine(); 
            }
            // The outer loop iterates over each row of the triangle, and the inner loops print the appropriate number of spaces and "©" characters for each row.
        }
    }
}