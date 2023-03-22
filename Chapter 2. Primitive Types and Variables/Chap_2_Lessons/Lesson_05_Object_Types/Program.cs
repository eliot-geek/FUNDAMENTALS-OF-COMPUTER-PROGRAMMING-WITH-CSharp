using System;

namespace Lesson_05_Object_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Type – Object type is a special type, which is the parent of all other types in the .NET Framework.
            // Declared with the keyword object, it can take values from any other type. It is a reference type, i.e. an index (address) of a memory area which stores the actual value.
            // This makes the object type a universal data container.

            // Declare some variables
            object container1 = 5;
            object container2 = "Five";

            // Print the results on the console
            Console.WriteLine("The value of container1 is: " + container1);
            Console.WriteLine("The value of container2 is: " + container2);
        }
    }
}
