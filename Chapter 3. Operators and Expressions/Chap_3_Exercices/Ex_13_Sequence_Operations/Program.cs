using System;

namespace Ex_13_Sequence_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, 
             * so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
             
            Guide: Use bitwise operations by analogy with the previous two problems. You can reset the bit at position p in the number n as follows:
            n = n & (~(1 << p)); 
            You can set bits in the unit at position p in the number n as follows: 
            n = n | (1 << p); */

            int n = 35;
            int p = 5;
            int v = 0;
            n = (v == 0) ? n & (~(1 << p)) : n | (1 << p);
            Console.WriteLine("The new value of n is : {0}", n); // Should output 3 (00000011 in binary)

            int n1 = 35;   // 00100011 in binary
            int p1 = 2;
            int v1 = 1;
            // Reset the bit at position p in the number n
            // The ~ operator is the bitwise NOT operator, which inverts all the bits in its operand. So ~(1 << p) gives a mask where all the bits are 1,
            // except for the bit at position p, which is 0. When you AND this mask with n, it resets the bit at position p to 0.
            n1 = n1 & (~(1 << p1));
            // Set the bit at position p in the number n to the value of v
            // The second operation sets the bit at position p to the value of v (either 0 or 1).
            // Since v is either 0 or 1, you can just shift it left by p positions to get the correct bit mask, and then OR it with n.
            n1 = n1 | (v1 << p1);
            Console.WriteLine("The new value of n is: {0}", n1);   // Should output 39 (00100111 in binary) 

        }
    }
}
