namespace Ex13BaseConversion
{
    internal class Program
    {
        /// <summary>
        /// ConvertBaseNumber
        /// </summary>
        /// <param name="numberStr"></param>
        /// <param name="baseS"></param>
        /// <param name="baseD"></param>
        /// <returns></returns>
        static string ConvertBaseNumber(string numberStr, int baseS, int baseD)
        {
            int decimalNumber = ConvertToDecimal(numberStr, baseS); // Convert the given number from base S to decimal (base 10)
            string convertedNumber = ConvertFromDecimal(decimalNumber, baseD);  // Convert the decimal number to the target base D
            return convertedNumber;
        }

        /// <summary>
        /// ConvertToDecimal
        /// </summary>
        /// <param name="numberStr"></param>
        /// <param name="baseS"></param>
        /// <returns></returns>
        static int ConvertToDecimal(string numberStr, int baseS)
        {
            int decimalNumber = 0;
            int power = 1;

            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                int digit = GetDecimalValue(numberStr[i]);

                if (digit >= baseS)
                {
                    Console.WriteLine("Invalid input: The number contains a digit that is greater than or equal to the base.");
                    Environment.Exit(0);
                }
                decimalNumber += digit * power;
                power *= baseS;
            }
            return decimalNumber;
        }

        /// <summary>
        /// ConvertFromDecimal
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <param name="baseD"></param>
        /// <returns></returns>
        static string ConvertFromDecimal(int decimalNumber, int baseD)
        {
            string convertedNumber = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseD;
                convertedNumber = GetDigitValue(remainder) + convertedNumber;
                decimalNumber /= baseD;
            }
            return convertedNumber;
        }

        /// <summary>
        /// GetDecimalValue
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        static int GetDecimalValue(char digit)
        {
            if (char.IsDigit(digit))
                return int.Parse(digit.ToString());
            else
                return char.ToUpper(digit) - 'A' + 10;
        }

        /// <summary>
        /// GetDigitValue
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static char GetDigitValue(int value)
        {
            if (value >= 0 && value <= 9)
                return value.ToString()[0];
            else
                return (char)(value - 10 + 'A');
        }


        static void Main(string[] args)
        {
            #region Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N from an S-based numeral system to a D based numeral system.
            // You can convert first from S-based system to decimal number and then from decimal number to D-based system.
            #endregion

            Console.Write("Enter the number: ");
            string numberStr = Console.ReadLine();
            Console.Write("Enter the base of the given number (S): ");
            int baseS = int.Parse(Console.ReadLine());
            Console.Write("Enter the target base (D): ");
            int baseD = int.Parse(Console.ReadLine());

            string convertedNumber = ConvertBaseNumber(numberStr, baseS, baseD);
            Console.WriteLine($"Converted number: {convertedNumber}");
            Console.ReadLine();


            Console.WriteLine("\nSecond Solution");
            Console.Write("Choose a numeral system to convert FROM: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("value of the number: ");
            string number = Console.ReadLine();
            Console.Write("Choose a numeral system to convert TO: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine(BaseStoDecimal(number, s, d));
            Console.ReadLine();
        }


        /// <summary>
        /// BaseStoDecimal
        /// </summary>
        /// <param name="num"></param>
        /// <param name="s"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        static string BaseStoDecimal(string num, int s, int d)
        {
            int numToDecimal = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                int power = Convert.ToInt32(Math.Pow(s, num.Length - 1 - i));
                char symbol = num[i];
                symbol = Char.ToUpper(symbol);

                if (symbol >= 'A' && symbol <= 'F')
                {
                    switch (symbol)
                    {
                        case 'A':
                            numToDecimal += power * 10;
                            break;
                        case 'B':
                            numToDecimal += power * 11;
                            break;
                        case 'C':
                            numToDecimal += power * 12;
                            break;
                        case 'D':
                            numToDecimal += power * 13;
                            break;
                        case 'E':
                            numToDecimal += power * 14;
                            break;
                        case 'F':
                            numToDecimal += power * 15;
                            break;
                    }
                }
                else
                {
                    int digit = num[i] - 48;
                    numToDecimal += power * digit;
                }
            }
            return DecimalToDBase(numToDecimal, d);
        }

        /// <summary>
        /// DecimalToDBase
        /// </summary>
        /// <param name="decimalNum"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        static string DecimalToDBase(int decimalNum, int d)
        {

            string numToDBase = string.Empty;
            int digit;

            while (decimalNum > 0)
            {
                digit = decimalNum % d;

                if (digit > 9 && digit < 16)
                {
                    switch (digit)
                    {
                        case 10:
                            numToDBase = 'A' + numToDBase;
                            break;
                        case 11:
                            numToDBase = 'B' + numToDBase;
                            break;
                        case 12:
                            numToDBase = 'C' + numToDBase;
                            break;
                        case 13:
                            numToDBase = 'D' + numToDBase;
                            break;
                        case 14:
                            numToDBase = 'E' + numToDBase;
                            break;
                        case 15:
                            numToDBase = 'F' + numToDBase;
                            break;
                    }
                }
                else
                {
                    numToDBase = digit + numToDBase;
                }
                decimalNum /= d;
            }
            return numToDBase;
        }
    }
}