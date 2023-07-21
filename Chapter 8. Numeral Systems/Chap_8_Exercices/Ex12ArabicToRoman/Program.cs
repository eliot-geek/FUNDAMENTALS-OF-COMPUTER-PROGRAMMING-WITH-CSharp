namespace Ex12ArabicToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that converts Arabic digits to Roman ones
            // Guide: Take a look at the numbers from 1 to 9 and their corresponding Roman representation with the digits "I", "V" and "X":
            // 1->I 2->II 3->III 4->IV 5->V 6->VI 7->VII 8->VIII 9->IX
            // We have exactly the same correspondence for the numbers 10, 20, …, 90 with their Roman representation "X", "L" and "C".
            // The same is valid for the numbers 100, 200, …, 900 and their Roman representation with "C", "D" and "M" and so on.
            // We are now ready to convert the number N into the Roman numeral system. It must be in the range [1…3999], otherwise we should report an error.
            // First we separate the thousands (N / 1000) and replace them with their Roman counterpart. After that we separate the hundreds (N / 100) % 10)
            // and separate them with their Roman counterpart and so on.
            #endregion

            Console.Write("Enter an Arabic number (1 to 3999): ");
            int arabicNumber = int.Parse(Console.ReadLine());
            // Check if the input number is within the valid range [1...3999]
            if (arabicNumber < 1 || arabicNumber > 3999)
            {
                Console.WriteLine("Error: The input number must be in the range [1...3999].");
            }
            else
            {
                // Convert the Arabic number to Roman numeral
                string romanNumeral = ConvertArabicToRoman(arabicNumber);
                Console.WriteLine($"Roman numeral: {romanNumeral}");
            }
            Console.ReadLine();



            Console.WriteLine("\nSecond Solution");
            String result = "";
            Console.Write("Enter Arabic number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int thousands = i / 1000;
            int hundreds = (i / 100) % 10;
            int tens = (i / 10) % 10;
            int ones = i % 10;

            switch (thousands)
            {
                case 1: result += "M"; break;
                case 2: result += "MM"; break;
                case 3: result += "MMM"; break;
            }

            switch (hundreds)
            {
                case 1: result += "C"; break;
                case 2: result += "CC"; break;
                case 3: result += "CCC"; break;
                case 4: result += "CD"; break;
                case 5: result += "D"; break;
                case 6: result += "DC"; break;
                case 7: result += "DCC"; break;
                case 8: result += "DCCC"; break;
                case 9: result += "CM"; break;
            }

            switch (tens)
            {
                case 1: result += "X"; break;
                case 2: result += "XX"; break;
                case 3: result += "XXX"; break;
                case 4: result += "XL"; break;
                case 5: result += "L"; break;
                case 6: result += "LX"; break;
                case 7: result += "LXX"; break;
                case 8: result += "LXXX"; break;
                case 9: result += "XC"; break;
            }

            switch (ones)
            {
                case 1: result += "I"; break;
                case 2: result += "II"; break;
                case 3: result += "III"; break;
                case 4: result += "IV"; break;
                case 5: result += "V"; break;
                case 6: result += "VI"; break;
                case 7: result += "VII"; break;
                case 8: result += "VIII"; break;
                case 9: result += "IX"; break;
            }
            Console.WriteLine("Roman number is " + result);
        }


        static string ConvertArabicToRoman(int arabicNumber)
        {
            // Define arrays to represent the Roman numeral components for thousands, hundreds, tens, and units.
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            // Construct the Roman numeral by extracting each digit from the Arabic number and using the corresponding arrays
            string romanNumeral = thousands[arabicNumber / 1000] +
                                  hundreds[(arabicNumber % 1000) / 100] +
                                  tens[(arabicNumber % 100) / 10] +
                                  units[arabicNumber % 10];

            return romanNumeral;
        }
    }
}