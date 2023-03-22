using System;

namespace Lesson_00_Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integers Types (sbyte, byte, short, ushort, int, uint, long and ulong.)

            // Declare some variables
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;
            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + " days, or " + hours + " hours. ");

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue);  // 18446744073709551615
        }
    }
}