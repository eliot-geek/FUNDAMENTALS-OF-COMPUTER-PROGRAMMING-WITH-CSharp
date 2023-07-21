namespace Ex11RomanToArabic
{
    internal class Program
    {
        static int ConvertRomanToArabic(string romanNumeral)
        {
            int arabicNumber = 0;
            int prevValue = 0; // Store the previous decimal value to determine adding or subtracting

            // Iterate through the Roman numeral from right to left
            for (int i = romanNumeral.Length - 1; i >= 0; i--)
            {
                char currentDigit = romanNumeral[i];
                int currentValue = 0;

                // Convert the current Roman digit to its corresponding Arabic value using a switch-case
                switch (currentDigit)
                {
                    case 'I':
                        currentValue = 1;
                        break;
                    case 'V':
                        currentValue = 5;
                        break;
                    case 'X':
                        currentValue = 10;
                        break;
                    case 'L':
                        currentValue = 50;
                        break;
                    case 'C':
                        currentValue = 100;
                        break;
                    case 'D':
                        currentValue = 500;
                        break;
                    case 'M':
                        currentValue = 1000;
                        break;
                    default:
                        Console.WriteLine("Invalid Roman numeral.");
                        return -1;
                }

                // Determine whether to add or subtract the current value
                if (currentValue < prevValue)
                {
                    arabicNumber -= currentValue;
                }
                else
                {
                    arabicNumber += currentValue;
                }
                prevValue = currentValue; // Update the previous value for the next iteration
            }
            return arabicNumber;
        }

        static void Main(string[] args)
        {
            #region Write a program that converts Roman digits to Arabic ones.
            // Scan the digits of the Roman number from left to right and add them up to a sum, which is initialized with a 0.
            // When processing each Roman digit, take it with a positive or negative sign, depending on the digit after it (whether it has a bigger or smaller decimal value).
            #endregion

            Console.Write("Enter a Roman numeral: ");
            string romanNumeral = Console.ReadLine().ToUpper();
            int arabicNumber = ConvertRomanToArabic(romanNumeral);
            Console.WriteLine($"Arabic number: {arabicNumber}");
            Console.ReadLine();



            Console.WriteLine("\nSecond Solution");
            int result = 0;
            Console.Write("Enter a Roman number: ");
            String str = Console.ReadLine();
            // convert the input string str, into an array of strings. Each element of the array represents a single character of the Roman numeral 
            string[] chars = str.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == "m" || chars[i] == "M")
                    result += 1000;
                if (chars[i] == "d" || chars[i] == "D")
                    result += 500;
                if (chars[i] == "c" || chars[i] == "C")
                {
                    // Add 100 to the result
                    result += 100;

                    // Check if the next character is 'd' or 'm' to handle subtractive notation
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "d" || chars[i + 1] == "D")
                            result -= 200; // Subtract 200 when the next character is 'd'
                        if (chars[i + 1] == "m" || chars[i + 1] == "M")
                            result -= 200; // Subtract 200 when the next character is 'm'
                    }
                }

                if (chars[i] == "l" || chars[i] == "L")
                    result += 50;
                if (chars[i] == "x" || chars[i] == "X")
                {
                    // Add 10 to the result
                    result += 10;

                    // Check if the next character is 'l' or 'c' to handle subtractive notation
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "l" || chars[i + 1] == "L")
                            result -= 20; // Subtract 20 when the next character is 'l'
                        if (chars[i + 1] == "c" || chars[i + 1] == "C")
                            result -= 20; // Subtract 20 when the next character is 'c'
                    }
                }

                if (chars[i] == "v" || chars[i] == "V")
                    result += 5;
                if (chars[i] == "i" || chars[i] == "I")
                {
                    // Add 1 to the result
                    result++;

                    // Check if the next character is 'v' or 'x' to handle subtractive notation
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "v" || chars[i + 1] == "V")
                            result -= 2; // Subtract 2 when the next character is 'v'
                        if (chars[i + 1] == "x" || chars[i + 1] == "X")
                            result -= 2; // Subtract 2 when the next character is 'x'
                    }
                }
            }
            Console.WriteLine("Arabic number is " + result);
        }
    }
}