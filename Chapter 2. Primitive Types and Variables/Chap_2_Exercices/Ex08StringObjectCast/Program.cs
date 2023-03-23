namespace Ex08StringObjectCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables 
             * of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize 
             * it with the value of the variable of type object (you should use type casting). 
              
            Guidelines : string str = (string)obj; 
            */

            // Declare String variables
            string str1 = "Hello";
            string str2 = "World";
            // concatenation with space and store in an object variable
            object obj = str1 + " " + str2;
            // type casting object variable to string and store in a third string variable
            string str = (string)obj;
            // print the third string variable
            Console.WriteLine("First: " + str);

            // type casting object variable to string and store in a third string variable
            string str3 = obj.ToString();
            Console.WriteLine("Second: " + str3);
        }
    }
}