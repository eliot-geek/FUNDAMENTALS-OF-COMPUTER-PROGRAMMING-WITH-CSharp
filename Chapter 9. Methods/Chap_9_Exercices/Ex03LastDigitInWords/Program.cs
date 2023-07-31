namespace Ex03LastDigitInWords
{
    internal class Program
    {
        /// <summary>
        /// Method to get the English name of the last digit of the input number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static string GetLastDigitName(int number)
        {
            // Calculate the last digit of the number using remainder (%) operation with 10
            int lastDigit = number % 10;
            // Use a switch statement to map the last digit to its corresponding English name
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Invalid input number.";
                    // Throw an exception if the last digit is not in the range of 0 to 9 (should not happen)
                    // throw new ArgumentException("Invalid input number.");
            }
        }

        static void Main(string[] args)
        {
            #region Task 03
            /* Write a method that returns the English name of the last digit of a given number. Example: for 512 prints "two"; for 1024 --> "four".
            Guide: Use the reminder of division by 10 and then a switch statement.*/
            #endregion

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            // Get the English name of the last digit using the GetLastDigitName method
            string lastDigitName = GetLastDigitName(number);
            Console.WriteLine("The English name of the last digit is: " + lastDigitName);
        }
    }
}