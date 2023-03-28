using System;

namespace Ex_15_Exchange_ValuesBits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that exchanges the values of the bits on positions 3, 4 and 5 with 
             * bits on positions 24, 25 and 26 of a given 32-bit unsigned integer.
             
            Guide: Use 3 times a combination of getting and setting a bit at a given position. The first exchange is given below:
            int bit3 = (num >> 3) & 1; 
            int bit24 = (num >> 24) & 1; 
            num = num & (~(1 << 24)) | (bit3 << 24); 
            num = num & (~(1 << 3)) | (bit24 << 3); */

            /*
            The hexadecimal number 0x12345678 is a 32-bit unsigned integer in hexadecimal notation. To convert it to decimal notation, we can use the following formula:
            decimal number = (d1 * 16^7) + (d2 * 16^6) + (d3 * 16^5) + (d4 * 16^4) + (d5 * 16^3) + (d6 * 16^2) + (d7 * 16^1) + (d8 * 16^0)
            where d1 to d8 represent the hexadecimal digits of the number, from left to right.
            Using this formula, we can calculate the decimal value of 0x12345678 as follows:
            decimal number = (1 * 16^7) + (2 * 16^6) + (3 * 16^5) + (4 * 16^4) + (5 * 16^3) + (6 * 16^2) + (7 * 16^1) + (8 * 16^0)
            = (1 * 268435456) + (2 * 16777216) + (3 * 1048576) + (4 * 65536) + (5 * 4096) + (6 * 256) + (7 * 16) + (8 * 1)
            = 305419896
            Therefore, the hexadecimal number 0x12345678 is equal to the decimal number 305419896.
             */


            // The given 32-bit unsigned integer
            // In decimal notation, the number 0x12345678 is equal to 305419896
            uint num = 0x12345678;
            // The Convert.ToString(num, 2) method call converts the num value to a binary string representation. The second parameter 2 specifies that the output should be in binary format.
            // The PadLeft(32, '0') method call ensures that the binary string representation is left-padded with zeros to a total length of 32 characters. 
            Console.WriteLine($"Original number: 0x{num:X}");
            Console.WriteLine("Original number: " + Convert.ToString(num, 2).PadLeft(32, '0'));

            // Exchange bits 3 and 24 using a combination of getting and setting a bit
            // To isolate the bit on position 3, we perform a bitwise AND operation (&) with the number 1.
            // This sets all bits in the result to 0, except for the least significant bit, which is set to the value of the bit on position 3.
            // (1u << 24): Left shift the integer value 1 by 24 positions, which results in a 32-bit integer with all bits set to 0 except the 24th bit which is set to 1.
            // ~(1u << 24): Bitwise NOT operation on the integer value obtained in the previous step, which results in a 32-bit integer with all bits set to 1 except the 24th bit which is set to 0.
            // (num & (~(1u << 24))): Bitwise AND operation between num and the result of ~(1u << 24). This clears the 24th bit of num to 0 while leaving all other bits unchanged.
            // ((uint)bit3 << 24): Left shift the value of bit3 by 24 positions, which results in a 32-bit integer with all bits set to 0 except the 24th bit which is set to the value of bit3.
            // (num & (~(1u << 24))) | ((uint)bit3 << 24): Bitwise OR operation between the previous results. 
            
            int bit3 = (int)((num >> 3) & 1);                   // get the value of bit 3
            int bit24 = (int)((num >> 24) & 1);                 // get the value of bit 24
            num = (num & (~(1u << 24))) | ((uint)bit3 << 24);   // set bit 24 to the value of bit 3
            num = (num & (~(1u << 3))) | ((uint)bit24 << 3);    // set bit 3 to the value of bit 24

            // Exchange bits 4 and 25 using a combination of getting and setting a bit
            int bit4 = (int)((num >> 4) & 1);                   // get the value of bit 4
            int bit25 = (int)((num >> 25) & 1);                 // get the value of bit 25
            num = (num & (~(1u << 25))) | ((uint)bit4 << 25);   // set bit 25 to the value of bit 4
            num = (num & (~(1u << 4))) | ((uint)bit25 << 4);    // set bit 4 to the value of bit 25

            // Exchange bits 5 and 26 using a combination of getting and setting a bit
            int bit5 = (int)((num >> 5) & 1);                   // get the value of bit 5
            int bit26 = (int)((num >> 26) & 1);                 // get the value of bit 26
            num = (num & (~(1u << 26))) | ((uint)bit5 << 26);   // set bit 26 to the value of bit 5
            num = (num & (~(1u << 5))) | ((uint)bit26 << 5);    // set bit 5 to the value of bit 26

            Console.WriteLine("New New number:  " + Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine($"New New number:  0x{num:X}");

            //Position 0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 
            //Before   0  0  0  1  0  0  1  0  0  0  1   1  0  1  0  0  0  1  0  1  0  1  1  0  0  1  1  1  1  0  0  0
            //After    0  0  0  1  0  1  1  1  0  0  1   1  0  1  0  0  0  1  0  1  0  1  1  0  0  1  0  1  0  0  0  0
        }
    }
}
