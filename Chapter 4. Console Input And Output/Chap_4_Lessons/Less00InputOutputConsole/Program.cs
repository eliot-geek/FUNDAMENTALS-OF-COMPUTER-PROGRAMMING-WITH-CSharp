using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Less00InputOutputConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The so called operating system "shells" can be split into two main categories according to the type of interface they can provide to the operating system:
            - CLI – Command Line Interface – is a console for commands(such as cmd.exe in Windows and bash in Linux).
            - GUI – Graphical User Interface – is a graphical work environment(such as Windows Explorer). */

            Console.Out.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine(5);
            Console.WriteLine(3.14159265358979); Console.ReadKey(); Console.WriteLine();

            // Using Console.Write(…) and Console.WriteLine(…)
            Console.WriteLine("I love");
            Console.Write("this ");
            Console.Write("Book!"); Console.ReadKey(); Console.WriteLine();

            // Concatenation of Strings - concatenates (joins) two strings and returns as result a new string
            string age = "twenty six";
            string text = "He is " + age + " years old.";
            Console.WriteLine(text); Console.ReadKey();

            // Concatenation of Mixed Types
            int age1 = 26;
            string text1 = "He is " + age1 + " years old.";
            Console.WriteLine(text1); Console.ReadKey();

            // Some Features of String Concatenation
            string s = "Four: " + 2 + 2;
            Console.WriteLine(s);           // Four: 22
            string s1 = "Four: " + (2 + 2);
            Console.WriteLine(s1);          // Four: 4
            Console.ReadKey();

            // Formatted Output with Write(…) and WriteLine(…)
            string str = "Hello World!";
            // Print (the normal way)
            Console.Write(str);
            // Print (through formatting string)
            Console.Write("{0}", str); Console.ReadKey(); Console.WriteLine();
            // The expression {0} is called a placeholder, i.e. a place that will be replaced by a specific value while printing.
            string name = "John";
            int age2 = 18;
            string town = "Seattle";
            Console.Write("{0} is {1} years old from {2}!\n", name, age2, town);
            Console.Write("{1} is {0} years old from {3}!", 18, "John", 0, "Seattle"); Console.ReadKey(); Console.WriteLine();

            // Formatting Items
            // The following formation scheme represents the general syntax of formatting items: {index[,alignment][:formatString]} - only the index component is mandatory.
            // 1. The index component is an integer and indicates the position of the argument from the argument list. The first argument is indicated by "0", the second by "1", etc.
            // 2. The alignment component is optional and indicates the string alignment. It is a positive or negative integer and the positive values indicate alignment to the right
            // and the negative – alignment to the left. The value of the number indicates the number of positions in which to align the number. If the string we want to represent
            // has a length greater than or equal to the value of the number, then this number is ignored. If it is less, however, the unfilled positions are filled in with spaces.
            Console.WriteLine("{0,6}", 123);
            Console.WriteLine("{0,6}", 1234);
            Console.WriteLine("{0,6}", 12);
            Console.Write("{0,-6}", 123);
            Console.WriteLine("--end"); Console.ReadKey();

            // 3. The "formatString" Component specifies the specific formatting of the string. It varies depending on the type of argument. There are three main types of formatString components:
            //  - for numerical types of arguments
            //  - for arguments of type date(DateTime)
            //  - for arguments of type enumeration(listed types)

            // Standard Numeric Formats
            // C or c for the currency
            // D or d an integer number
            // E or e an exponentiial notatiton
            // F or f for an integer or decimal number
            // N or n separator for thousands millions etc... with comma
            // P or p the percent character
            // X or x for the hexadecimal
            Console.WriteLine();
            Console.WriteLine("{0:C2}", 123.456);   //Output: $ 123,46  // the current “culture” settings is taken by default from the regional settings of the operating system.
            Console.WriteLine("{0:D6}", -1234);     //Output: -001234
            Console.WriteLine("{0:E2}", 123);       //Output: 1,23E+002
            Console.WriteLine("{0:F2}", -123.456);  //Output: -123,46
            Console.WriteLine("{0:N2}", 1234567.8); //Output: 1 234 567,80
            Console.WriteLine("{0:P}", 0.456);      //Output: 45,60 %
            Console.WriteLine("{0:X}", 254);        //Output: FE

            // Custom Formats for Numbers
            Console.WriteLine();
            Console.WriteLine("{0:0.00}", 1);                   //Output: 1.00
            Console.WriteLine("{0:#.##}", 0.234);               //Output: .23
            Console.WriteLine("{0:#####}", 12345.67);           //Output: 12346
            Console.WriteLine("{0:(0#) ### ## ##}", 29342525);  //Output: (02) 934 25 25
            Console.WriteLine("{0:%##}", 0.234);                //Output: %23

            // Standard Defined Date Formats - Since the standard defined formats are many we will list only few of them.
            // Custom Date Formats 
            Console.WriteLine();
            DateTime d = new DateTime(2023, 03, 28, 18, 30, 21);
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);            // 28.03.2023 18:30:21
            Console.WriteLine("{0:d.MM.yy}", d);                        // 28.03.23


            // Format String Enumeration Components - Enumerations (listed types) are data types that can take as value one of several predefined possible values (e.g. the seven days of the week).
            // G or g as a string
            // D or d as a number in decimal numeral
            // X or x as a number in hexadecimal numeral
            Console.WriteLine();
            Console.WriteLine("{0:G}", DayOfWeek.Wednesday);            // Wednesday
            Console.WriteLine("{0:D}", DayOfWeek.Wednesday);            // 3
            Console.WriteLine("{0:X}", DayOfWeek.Wednesday);            // 00000003

            // Formatting Strings and Localization - Localization in .NET is also called "culture" and can be changed manually by the class System.Globalization.CultureInfo.
            Console.WriteLine();
            DateTime date = new DateTime(2023, 12, 11, 14, 56, 44);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", date);

            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", date);

            //  1,234.560
            //  Monday, December 11, 2023
            //  1,234.560
            //  Monday, December 11, 2023
        }
    }
}
