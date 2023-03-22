using System;

namespace Lesson_07_Value_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value and Reference Types and the Memory - we will illustrate how value and reference types are represented in memory.

            int i = 42;
            char ch = 'A';
            bool result = true;                 //  == picture (stack heap memory 1
            object obj = 42;
            string str = "Hello";
            byte[] bytes = { 1, 2, 3 };


            i = 0;
            ch = 'B';
            result = false;                     //  == picture (stack heap memory 1
            obj = null;
            str = "Bye";
            bytes[1] = 0;
        }
    }
}
