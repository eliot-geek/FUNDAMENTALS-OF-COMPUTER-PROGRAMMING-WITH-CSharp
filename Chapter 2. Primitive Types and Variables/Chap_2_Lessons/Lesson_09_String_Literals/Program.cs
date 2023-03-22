using System;

namespace Lesson_09_String_Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            // String literals are used for data of type string. They are a sequence of characters enclosed in double quotation marks.

            // String Literals – Examples
            string quotation = "\"Hello, Jude\", he said.";
            Console.WriteLine(quotation);

            string path = "C:\\Windows\\SublimeText.exe";
            Console.WriteLine(path);
            string verbatim = @"The \ is not escaped as \\.
            I am at a new line.";
            Console.WriteLine(verbatim);

        }
    }
}
