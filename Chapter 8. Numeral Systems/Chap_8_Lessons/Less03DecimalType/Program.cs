namespace Less03DecimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Decimal Type - Even though the decimal type has a higher precision than the floating-point types, it has a smaller value range
            decimal calc = 20.4m; Console.WriteLine(calc);
            decimal result = 5.0M; Console.WriteLine(result);
            // Let’s use decimal instead of float / double in the example from before
            decimal sum = 0.0m;
            for (int i = 1; i <= 10000000; i++)
            {
                sum += 0.0000001m;
            }
            Console.WriteLine(sum); // 1.0000000

            // Character Data (Strings) - Character (text) data in computing is text, encoded using a sequence of bytes. There are different encoding schemes used to encode text data.
            // Such encoding schemes are ASCII (127 characters), Windows-1251 (256 characters), UTF-8 and UTF-16.
            // The UTF-8 encoding is completely different. All characters in the Unicode standard – the letters and symbols used in all widely spread languages in the world
            // (Cyrillic, Latin, Arabian, Chinese, Japanese, Korean and many other languages and writing systems) – can be encoded in it. The UTF-8 encoding contains over half a million symbols.
            // The UTF-16 encoding, like UTF-8 can depict text of all commonly used languages and writing systems, described in the Unicode standard. In UTF-16,
            // every symbol is written in 16 bits (2 bytes) and some of the more rarely used symbols are presented as a sequence of two 16-bit values.

            // Presenting a Sequence of Characters
            // The most common method for writing text in the memory is to write in 2 or 4 bytes its length, followed by a sequence of bytes, which presents the text itself in some sort of encoding (for example Windows-1251 or UTF-8).

            // Char Type - The char type in the C# language is a 16-bit value, in which a single Unicode character or part of it is coded.
            char ch = 'A';
            Console.WriteLine(ch);

            // String Type - The string type in C# holds text, encoded in UTF-16. A single string in C# consists of 4 bytes length and a sequence of characters written as 16-bit values of the char type.
            string str = "Example";
            Console.WriteLine(str);

        }
    }
}