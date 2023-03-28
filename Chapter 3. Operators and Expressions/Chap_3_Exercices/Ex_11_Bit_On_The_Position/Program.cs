using System;

namespace Ex_11_Bit_On_The_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on 
            the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
            Guidelines: Use bitwise operations */


            int n = 35;         // 00100011 
            int p = 5;
            int i = 1;          // 00000001 
            int mask = i << p;  // Move the 1-st bit left by p positions
            // If i & mask are positive then the p-th bit of n is 1 
            Console.WriteLine((n & mask) != 0 ? 1 : 0);

            /* To move the 1-st bit left by 5 positions, you can use the left shift operator (<<) in C#. 
            In this case, i << 5 will shift the binary representation of i (which is 00000001) to the left by 5 positions, resulting in 00100000.
            So, mask will be assigned the integer value 32, which in binary representation is 00100000. 
            (n=00100011 AND mask=00100000 = 00100000  in binary represents the number 32 in decimal.
            
            To move the 1st bit left by 6 positions, you can use the left shift operator (<<) with a shift count of 6:
            int i = 1;          // 00000001
            int mask = i << 6;  // 01000000 
            After the left shift operation, the value of mask would be 01000000 in binary, which is 64 in decimal. 
            The result of the bitwise AND operation between 00100011 and 01000000 is 00000000 which in binary is 0. */
        }
    }
}
