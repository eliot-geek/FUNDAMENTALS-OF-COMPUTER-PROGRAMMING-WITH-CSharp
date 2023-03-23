namespace Ex05CharUnicodeCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 
             * (use the Windows calculator in order to find hexadecimal representation of 72).*/

            // https://unicode-table.com/en/

            char ch = '\u0072';       // Initialize a char variable with the Unicode character U+0072, which represents the lowercase letter 'r'
            Console.WriteLine(ch);    // Output the value of the char variable to the console, which should display the character 'r'
        }
    }
}