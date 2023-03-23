namespace Ex04InitializeHexadec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Initialize a variable of type int with a value of 256 in hexadecimal format 
             * (256 is 100 in a numeral system with base 16). 
             
             Guidelines: Look at the section about Integer Literals. To easily convert numbers to a different 
            numeral system use the built-in Windows calculator. For a hexadecimal representation of the literal use prefix 0x.
            */

            int numberInHex = 0x100;
            Console.WriteLine(numberInHex);
        }
    }
}