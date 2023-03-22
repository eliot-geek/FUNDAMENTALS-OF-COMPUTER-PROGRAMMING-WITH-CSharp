using System;

namespace Lesson_08_Escaping_Sequen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escaping sequences are literals. They are a sequence of special characters, which describe a character that cannot be written directly in the source code.
            // Here are some of the most frequently used escaping sequences:
            //  - \' – single quote
            //  - \" – double quotes
            //  - \\ – backslash
            //  - \n – new line
            //  - \t – offset(tab)
            //  - \uXXXX – char specified by its Unicode number, for example \u03A7.


            // Escaping Sequences – Examples

            char character = 'a'; Console.WriteLine(character); // An ordinary character
            character = '\u003A'; Console.WriteLine(character); // Unicode character code in a hexadecimal format
            character = '\''; Console.WriteLine(character);  // Assigning the single quotiation character (escaped as \')
            character = '\\'; Console.WriteLine(character);  // Assigning the backslash character (escaped as \\)
        }
    }
}
