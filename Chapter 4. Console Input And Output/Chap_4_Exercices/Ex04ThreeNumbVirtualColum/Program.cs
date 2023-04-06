using System;

namespace Ex04ThreeNumbVirtualColum
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the 
            numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; 
            and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
            Guide : Use the format strings explained in the “Composite Formatting” section and the method Console.WriteLine(). Below is a piece of the code:
            int hexNum = 2013; 
            Console.WriteLine("|0x{0,-8:X}|", hexNum); 
            double fractNum = -1.856; 
            Console.WriteLine("|{0,-10:f2}|", fractNum); */

            int hexNum = 2023;
            Console.WriteLine("|0x{0,-8:X}|", hexNum);
            double fractNumPos = 1.856;
            Console.WriteLine("|{0,-10:f2}|", fractNumPos);
            double fractNumNeg = -1.856;
            Console.WriteLine("|{0,-10:f2}|", fractNumNeg);
            Console.WriteLine(); Console.ReadKey();

            int hexNumb = 2023;         // declare an integer variable hexNum and assign it the value 2023
            double fractPos = 3.14159;  // declare a double variable fractPos and assign it the value 3.14159
            double fractNeg = -1.856;   // declare a double variable fractNeg and assign it the value -1.856
            // print the values of hexNum, fractPos, and fractNeg in three columns with a width of 10 characters each
            Console.WriteLine("|{0,-10:X}|{1,-10:f2}|{2,-10:f2}|", hexNumb, fractPos, fractNeg);
            Console.WriteLine("|0x{0,-8:X}|{1,-10:f2}|{2,-10:f2}|", hexNumb, fractPos, fractNeg);
            // the first column displays hexNum in hexadecimal format with left alignment
            // the second and third columns display fractPos and fractNeg as floating-point numbers with left alignment and two decimal places
            // the placeholders {0}, {1}, and {2} in the format string correspond to the values of hexNum, fractPos, and fractNeg, respectively
        }
    }
}
