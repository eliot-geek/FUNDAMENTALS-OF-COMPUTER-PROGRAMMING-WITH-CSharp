namespace Less01RepresentOfNumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Representation of Numbers
            /* Bit is a binary unit of information with a value of either 0 or 1. Information in the memory is grouped in sequences of 8 bits, which form a single byte.
            
            Representing Integer Numbers in the Memory
            When numbers are represented with a sign, a signed order is introduced. 
            It is the highest-order and has the value of 1 for negative numbers and the value of 0 for positive numbers.
            In the case of a number without a sign, all bits are used to represent its value.

            Unsigned Integers
            For unsigned integers 1, 2, 4 or 8 bytes are allocated in the memory. all integers in the range [0, 2n-1]
            
            Representing Negative Numbers
            For negative numbers 1, 2, 4 or 8 bytes are allocated in the memory of the computer. integers are within the range: [-2n-1, 2n-1-1]. 
            Positive numbers are always represented in the same way and the straight, reversed and additional code all coincide for them.

            Straight code (signed magnitude) is the simplest representation of the number.
            The number 3 in signed magnitude is represented as an eight-bit-long number 00000011.
            The number -3 in signed magnitude is represented in an eight-bit-long number as 10000011.
            
            Reversed code (one’s complement) is formed from the signed magnitude of the number by inversion (replacing all ones with zeros and vice-versa).
            The number -127 in signed magnitude is represented as 1 1111111 and in one’s complement as 1 0000000.
            The number 3 in signed magnitude is represented as 0 0000011, and in one’s complement looks like 0 1111100.
            
            Additional code (two’s complement) is a number in reversed code to which one is added (through addition). 
            Example: The number -127 is represented with additional code as 1 0000001.

            
            */

            Console.WriteLine("Hello, Representation of Numbers!");
        }
    }
}