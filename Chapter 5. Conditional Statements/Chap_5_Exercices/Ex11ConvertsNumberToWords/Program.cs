using System;

namespace Ex11ConvertsNumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
            //-   0-- > "Zero"
            //-  12-- > "Twelve"
            //-  98-- > "Ninety eight"
            //- 273-- > "Two hundred seventy three"
            //- 400-- > "Four hundred"
            //- 501-- > "Five hundred and one"
            //- 711-- > "Seven hundred and eleven"
            // Guide: Use nested switch statements. Pay special attention to the numbers from 0 to 19 and those that end with 0.There are many special cases!
            // You might benefit from using methods to reuse the code you write, because printing a single digit is part of printing a 2 - digit number which is
            // part of printing 3 - digit number.You may read about methods in the chapter “Methods”.


            // Prompt the user to enter a number between 0 and 999
            Console.Write("Enter a number from 0 to 999 : ");
            // Read in the number entered by the user and convert it to an integer
            int number = Int32.Parse(Console.ReadLine());
            // Check if the number is out of range
            if (number < 0 || number > 999)
            {
                Console.WriteLine("Error: Number out of range");
                return;
            }
            
            // Create variables for the hundreds, tensAndOnes, and ones places
            int hundreds = (number / 100);
            int tensAndOnes;
            if (number > 99)
            {
                tensAndOnes = number % 100;
            }
            else
            {
                tensAndOnes = number * 1;
            }

            int ones = number % 10;
            // Handle the hundreds place
            switch (hundreds)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
            }

            if (hundreds >= 1 && tensAndOnes >= 1)
            {
                Console.Write("and ");
            }
            if (tensAndOnes >= 20 && tensAndOnes < 30)
            {
                Console.Write("Twenty");
            }
            else if (tensAndOnes >= 30 && tensAndOnes < 40)
            {
                Console.Write("Thirty");
            }
            else if (tensAndOnes >= 40 && tensAndOnes < 50)
            {
                Console.Write("Fourty");
            }
            else if (tensAndOnes >= 50 && tensAndOnes < 60)
            {
                Console.Write("Fifty");
            }
            else if (tensAndOnes >= 60 && tensAndOnes < 70)
            {
                Console.Write("Sixty");
            }
            else if (tensAndOnes >= 70 && tensAndOnes < 80)
            {
                Console.Write("Seventy");
            }
            else if (tensAndOnes >= 80 && tensAndOnes < 90)
            {
                Console.Write("Eighty");
            }
            else if (tensAndOnes >= 90 && tensAndOnes < 100)
            {
                Console.Write("Ninety");
            }

            switch (tensAndOnes)
            {
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                case 10:
                    Console.Write("Ten");
                    break;
                case 11:
                    Console.Write("Eleven");
                    break;
                case 12:
                    Console.Write("Twelve");
                    break;
                case 13:
                    Console.Write("Thirteen");
                    break;
                case 14:
                    Console.Write("Fourteen");
                    break;
                case 15:
                    Console.Write("Fifteen");
                    break;
                case 16:
                    Console.Write("Sixteen");
                    break;
                case 17:
                    Console.Write("Seventeen");
                    break;
                case 18:
                    Console.Write("Eighteen");
                    break;
                case 19:
                    Console.Write("Nineteen");
                    break;
            }
            if (tensAndOnes > 20)
            {
                switch (ones)
                {
                    case 1:
                        Console.Write("-one");
                        break;
                    case 2:
                        Console.Write("-two");
                        break;
                    case 3:
                        Console.Write("-three");
                        break;
                    case 4:
                        Console.Write("-four");
                        break;
                    case 5:
                        Console.Write("-five");
                        break;
                    case 6:
                        Console.Write("-six");
                        break;
                    case 7:
                        Console.Write("-seven");
                        break;
                    case 8:
                        Console.Write("-eight");
                        break;
                    case 9:
                        Console.Write("-nine");
                        break;
                }
            }
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            Console.ReadLine();




            Console.WriteLine("\nSecond Method");
            // Prompt the user to enter a number between 0 and 999
            Console.Write("Enter a number (0 to 999): ");
            // Read the user's input as an integer
            int number1 = int.Parse(Console.ReadLine());

            // Declare two arrays to hold the English words for numbers from 0 to 19 and from 20 to 90 in increments of 10
            string[] ones1 =
            {
            "Zero", "One", "Two", "Three", "Four",
            "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            };

            string[] tens =
            {
            "", "", "Twenty", "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
            };
            // Initialize an empty string to hold the English words for the given number
            string words = "";

            // Use conditional statements to check which range the number falls into and convert it to its English pronunciation
            if (number1 == 0)
            {
                words = ones1[0];
            }
            else if (number1 > 0 && number1 <= 19)
            {
                words = ones1[number1];
            }
            else if (number1 >= 20 && number1 <= 99)
            {
                // If the number is between 20 and 99, separate the tens and ones digits
                int tensDigit = number1 / 10;
                int onesDigit = number1 % 10;
                // If the number ends in 0, only use the English word for the tens digit
                if (onesDigit == 0)
                {
                    words = tens[tensDigit];
                }
                else
                {
                    // If the number does not end in 0, concatenate the English words for the tens and ones digits, separated by a space
                    words = tens[tensDigit] + " " + ones1[onesDigit].ToLower();
                }
            }
            else if (number1 >= 100 && number1 <= 999)
            {
                // If the number is between 100 and 999, separate the hundreds, tens, and ones digits
                int hundredsDigit = number1 / 100;
                int tensDigit = (number1 / 10) % 10;
                int onesDigit = number1 % 10;

                if (tensDigit == 0 && onesDigit == 0)
                {
                    // If the number ends in 00, concatenate the English word for the hundreds digit and "Hundred"
                    words = ones1[hundredsDigit] + " Hundred";
                }
                else if (tensDigit == 0)
                {
                    // If the number ends in a non-zero ones digit, concatenate the English words for the hundreds digit, "Hundred", and ones digit, separated by "and"
                    words = ones1[hundredsDigit] + " Hundred and " + ones1[onesDigit].ToLower();
                }
                else if (tensDigit == 1)
                {
                    // If the number ends in a ones digit between 1 and 9, concatenate the English words for the hundreds digit, "Hundred", and the ones and tens digits together, separated by "and"
                    words = ones1[hundredsDigit] + " Hundred and " + ones1[number1 % 100].ToLower();
                }
                else if (onesDigit == 0)
                {
                    // If the number ends in a 0 ones digit, concatenate the English words for the hundreds digit, "Hundred", and the tens digit
                    words = ones1[hundredsDigit] + " Hundred and " + tens[tensDigit];
                }
                else
                {
                    words = ones1[hundredsDigit] + " Hundred and " + tens[tensDigit] + " " + ones1[onesDigit].ToLower();
                }
            }
            else
            {
                words = "Invalid number. Please enter a number between 0 and 999.";
            }
            Console.WriteLine(words);
        }
    }
}
