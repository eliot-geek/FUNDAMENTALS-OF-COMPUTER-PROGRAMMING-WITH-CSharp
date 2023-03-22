namespace Lesson_11_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            /* 
            A variable is a named area of memory, which stores a value from a particular data type, and that area of memory is accessible in the program by its name.
            Variables can be stored directly in the operational memory of the program(in the stack) or in the dynamic memory in which larger objects are stored(such as character strings and arrays).
            Primitive data types(numbers, char, bool) are called value types because they store their value directly in the program stack.
            Reference data types(such as strings, objects and arrays) are an address, pointing to the dynamic memory where their value is stored.
            They can be dynamically allocated and released i.e.their size is not fixed in advance contrary to the case of value types.

            - Naming Variables – Rules (name / - first_Name / _name1)
            - Naming Variables – Recommendations (Variables should have names, which briefly explain their purpose.)
            
            The syntax for declaring variables in C# is as follows:
            <data type> <identifier> [= <initialization>];
            string name;

            Assigning a Value
            name = "John Smith";
            */

            // Declare and initialize some variables
            byte centuries = 20;
            ushort years = 2000;
            decimal decimalPI = 3.141592653589793238m;
            bool isEmpty = true;
            char ch = 'a';
            string firstName = "Anders";
            ch = (char)5;
            char secondChar;

            // Here we use an already initialized variable and reassign it
            secondChar = ch;

            // Data types in C# are two types: value and reference.

            /*
            Value types are stored in the program execution stack and directly contain their value. Value types are the primitive numeric types, the character type and the Boolean type: 
            sbyte, byte, short, ushort, int, long, ulong, float, double, decimal, char, bool. The memory allocated for them is released when the program exits their range, i.e. 
            when the block of code in which they are defined completes its execution.
            
            Reference types keep a reference (address), in the program execution stack, and that reference points to the dynamic memory (heap), where their value is stored.
            An example of a value at address in the stack for execution is 0x00AD4934. it is a strongly typed pointer. All reference types can hold a null value. 
            This is a special service value, which means that there is no value.
            Reference types allocate dynamic memory for their creation. They also release some dynamic memory for a memory cleaning (garbage collector), when it is no longer used by the program.
            Since the allocation and release of memory is a slow operation, it can be said that the reference types are slower than the value ones.
            As reference data types are allocated and released dynamically during program execution, their size might not be known in advance.

            Reference types are all classes, arrays and interfaces such as the types: object, string, byte[]. 
            It is enough to know that all types, which are not value, are reference and their values are stored in the heap (the dynamically allocated memory).

            */
        }
    }
}