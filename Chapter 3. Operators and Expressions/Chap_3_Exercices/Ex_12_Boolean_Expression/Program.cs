using System;

namespace Ex_12_Boolean_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.*/

            int v = 5;          // v = 00000101 in binary
            int p = 1;          // p = 00000001 in binary
            int i = 1;          // i = 00000001 in binary          
            int mask = i << p;  // mask = 00000010 in binary (after shifting i left by 1 position)
            // Use bitwise AND operator to check if the bit on position p in v is 1
            bool hasBitOne = (v & mask) != 0 ? true : false;        //  00000101 AND 00000010 = 00000000 (0 in decimal)
            // Output the result
            Console.WriteLine("The bit on position {0} in the integer {1} has value 1? {2}", p, v, hasBitOne);
        }
    }
}
