namespace Ex_16_Exchange_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer
            Guide: Extend the solution of the previous problem to perform a sequence of bit exchanges in a loop. Read about loops in the chapter “Loops”. */

            uint num = 0x12345678;                  // input number in hexadecimal representation
            int[] positions1 = { 3, 4, 5 };         // array - positions of the first sequence of bits to exchange
            int[] positions2 = { 24, 25, 26 };      // array - positions of the second sequence of bits to exchange

            Console.WriteLine($"Original number: 0x{num:X}"); // The format item specifies that the value of the variable num should be formatted as a hexadecimal string (using the X format specifier).
            Console.WriteLine("Original number: " + Convert.ToString(num, 2).PadLeft(32, '0'));

            for (int i = 0; i < positions1.Length; i++)
            {
                int p = positions1[i];
                int q = positions2[i];
                int k = 2; // number of bits to exchange

                // Exchange bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}
                for (int j = 0; j < k; j++)
                {
                    int bit1 = (int)((num >> (p + j)) & 1);                     // get the value of bit p+j
                    int bit2 = (int)((num >> (q + j)) & 1);                     // get the value of bit q+j
                    num = (num & (~(1u << (q + j)))) | ((uint)bit1 << (q + j)); // set bit q+j to the value of bit p+j
                    num = (num & (~(1u << (p + j)))) | ((uint)bit2 << (p + j)); // set bit p+j to the value of bit q+j
                }
            }
            Console.WriteLine("New New number:  " + Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine($"New New number:  0x{num:X}"); // print the result
        }
    }
}