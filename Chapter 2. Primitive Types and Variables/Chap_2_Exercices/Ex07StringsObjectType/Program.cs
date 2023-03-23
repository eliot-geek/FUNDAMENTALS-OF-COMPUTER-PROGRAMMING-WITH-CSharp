namespace Ex07StringsObjectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. 
             * Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. 
             * Print the variable of type object.
             */

            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;  // concatenation with space
            Console.WriteLine(obj);  // print the object variable
        }
    }
}