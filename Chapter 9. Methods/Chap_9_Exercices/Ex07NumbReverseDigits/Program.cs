namespace Ex07NumbReverseDigits
{
    internal class Program
    {
        /// <summary>
        /// Method to print the digits of a given decimal number in reversed order
        /// </summary>
        /// <param name="num"></param>
        static void PrintDigitsReversed(int num)
        {
            // Check if the number is negative and handle it by taking its absolute value
            if (num < 0)
                num = Math.Abs(num);

            // If the number is 0, there is nothing to print, so handle this special case
            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }

            // Loop until num becomes 0
            while (num != 0)
            {
                // Get the last digit of the number (the remainder when divided by 10)
                int lastDigit = num % 10;
                // Print the last digit
                Console.Write(lastDigit);
                // Update the number by removing its last digit
                num /= 10;
            }
        }

        /// <summary>
        /// Method to print the digits of a given decimal number in reversed order
        /// </summary>
        /// <param name="num"></param>
        static void PrintDigitsReversed2(decimal num)
        {
            // Check if the number is negative and handle it by taking its absolute value
            if (num < 0)
                num = Math.Abs(num);

            // Convert the number to a string
            string numberStr = num.ToString();

            // Loop through the string in reverse order using a for-loop
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                // Get the current character (digit) from the string and convert it back to an integer
                int digit = int.Parse(numberStr[i].ToString());
                // Print the digit
                Console.Write(digit);
            }
        }

        static void Main(string[] args)
        {
            #region Task 07
            /* Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.
            Guide: First solution: Let the number is num. So while num ≠ 0 we print its last digit (num % 10) and then divide num by 10.
            Second solution: Convert the number into a string string and print it in a reverse order with a for-loop. This is a bit cheater’s approach.*/
            #endregion

            Console.WriteLine("First Solution");
            int number = 256;
            Console.Write("The reversed digits of the number {0} are: ", number);
            PrintDigitsReversed(number);
            Console.ReadLine();


            Console.WriteLine("\nSecond Solution");
            Console.Write("Enter the number: ");
            decimal num = decimal.Parse(Console.ReadLine());
            Console.Write("The reversed digits of the number {0} are: ", num);
            PrintDigitsReversed2(num);
            Console.ReadLine();
        }
    }
}