using System;

namespace Ex_16_Exchanges_Bits
{
    class Program
    {
        /*  Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer
        Guide: Extend the solution of the previous problem to perform a sequence of bit exchanges in a loop. Read about loops in the chapter “Loops”. */

        /// <summary>
        /// We define a static method ModifyNumber() that takes four parameters
        /// </summary>
        /// <param name="number">the input number</param>
        /// <param name="p">the starting position p</param>
        /// <param name="q">the starting position q</param>
        /// <param name="k">the number of bits to exchange k</param>
        /// <returns>This method returns the modified number after exchanging the specified bits</returns>
        private static uint ModifyNumber(uint number, int p, int q, int k)
        {
            // We define two arrays pBits and qBits of length k to store the bits to be exchanged
            int[] pBits = new int[k];
            int[] qBits = new int[k];

            // We initialize these arrays using a loop, where we use another helper method PthBit() to retrieve the value of the bit at the given position position
            for (int position = p, i = 0; i < pBits.Length; position++, i++)
            {
                pBits[i] = PthBit(number, position);
            }
            for(int position = q, i = 0; i < qBits.Length; position++, i++)
            {
                qBits[i] = PthBit(number, position);
            }

            // We exchange the bits from the q position to the p position.
            // To achieve this, we use another helper method ModifiedNumber() to modify the bits at each position position using the corresponding value qBits[i].
            for (int position = p, i = 0; i < qBits.Length; position++, i++)
            {
                number = ModifiedNumber(number, position, qBits[i]);
            }

            // We exchange the bits from the p position to the q position.
            // To achieve this, we use the same method ModifiedNumber() to modify the bits at each position position using the corresponding value pBits[i].
            for (int position = p, i = 0; i < pBits.Length; position++, i++)
            {
                number = ModifiedNumber(number, position, pBits[i]);
            }
            return number;
        }

        /// <summary>
        /// The method PthBit() takes two parameters: the input number and the position of the bit to retrieve. 
        /// </summary>
        /// <param name="number">the input number</param>
        /// <param name="position">the position of the bit to modify</param>
        /// <returns>This method returns the value of the bit at the given position.</returns>
        private static int PthBit(uint number, int position)
        {
            // We first shift the input number number to the right by position bits, and then perform a bitwise AND operation with the number 1.
            uint pthBit = (number >> position) & 1;
            return (int)pthBit;
        }

        /// <summary>
        /// The method ModifiedNumber() takes three parameters
        /// </summary>
        /// <param name="number">the input number</param>
        /// <param name="position">the position of the bit to modify</param>
        /// <param name="bitValue">the new value of the bit</param>
        /// <returns>This method returns the modified number after modifying the bit at the given position.</returns>
        private static uint ModifiedNumber(uint number, int position, int bitValue)
        {
            // we first create a mask by shifting the number 1 to the left by position bits and negating it.
            // Then, we AND the input number number with this mask to clear the bit at the given position.
            // Finally, we OR the result with the new bit value bitValue shifted to the left by position bits to set the modified bit.
            uint actualP = (uint)bitValue << position;
            number = number & (~((uint)1 << position));
            uint result = number | actualP;
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter p: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter q: ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            // The program checks whether p is less than q. If it is not, it swaps the values of p and q using a temporary variable.
            if (p < q)
            {
                int oldValue = p;
                p = q;
                q = oldValue;
            }

            // The program also checks if the range to be modified overlaps. If it does, it recalculates the length of the range to be modified and the ending position of the q sequence.
            if (p + k >= q)
            {
                k += p - q - 1;
                q += p + k + 1;
            }

            number = ModifyNumber(number, p, q, k);
            Console.WriteLine("Number: {0} \nP: {1} \nQ: {2} \nK: {3}", number, p, q, k);
            Console.WriteLine("The number is : {0}", number);
        }
    }
}
