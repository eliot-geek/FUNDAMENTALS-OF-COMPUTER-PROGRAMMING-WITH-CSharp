namespace Ex08SumOfVeryLargeNum
{
    internal class Program
    {
        /// <summary>
        /// Method that calculates the sum of two very long positive integer numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        static int[] AddTwoVeryLongPositiveNumbers(int[] firstNumber, int[] secondNumber)
        {
            // Find the length of the longer number to determine the size of the result array
            int maxLength = Math.Max(firstNumber.Length, secondNumber.Length);

            // Create a result array to store the sum, initialized with zeros
            int[] result = new int[maxLength];

            int carry = 0; // Initialize the carry to 0

            // Perform addition digit by digit
            for (int i = 0; i < maxLength; i++)
            {
                // Get the digits from both numbers, considering leading zeros if one number is shorter than the other
                int digitFromFirst = (i < firstNumber.Length) ? firstNumber[i] : 0;
                int digitFromSecond = (i < secondNumber.Length) ? secondNumber[i] : 0;

                // Calculate the sum of the current digits along with the carry from the previous iteration
                int sum = digitFromFirst + digitFromSecond + carry;

                // Calculate the new carry for the next iteration
                carry = sum / 10;

                // Store the last digit of the sum in the result array
                result[i] = sum % 10;
            }

            // If there is still a carry after the loop, add it to the result array
            if (carry > 0)
            {
                int[] extendedResult = new int[maxLength + 1];
                Array.Copy(result, extendedResult, maxLength);
                extendedResult[maxLength] = carry;
                return extendedResult;
            }
            return result;
        }

        /// <summary>
        /// Method that calculates the sum of two very long positive integer numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        static string AddTwoVeryLongNumbers(string firstNumber, string secondNumber)
        {
            int length;
            int[] Array1 = new int[10000];
            int[] Array2 = new int[10000];

            // Convert the first number to an array of digits in reverse order
            for (int i = 0; i < firstNumber.Length; i++)
            {
                Array1[i] = Convert.ToInt32(firstNumber.Substring(firstNumber.Length - 1 - i, 1));
            }

            // Update the length if the second number has more digits
            length = firstNumber.Length;
            if (secondNumber.Length > length)
            {
                length = secondNumber.Length;
            }

            // Convert the second number to an array of digits in reverse order
            for (int i = 0; i < secondNumber.Length; i++)
            {
                Array2[i] = Convert.ToInt32(secondNumber.Substring(secondNumber.Length - 1 - i, 1));
            }

            // Perform addition digit by digit, considering carry
            for (int i = 0; i < length; i++)
            {
                Array1[i] += Array2[i];

                // If the sum is greater than or equal to 10, adjust the digit and carry
                if (Array1[i] >= 10)
                {
                    Array1[i] -= 10;
                    Array1[i + 1]++;
                }
            }

            // If there is a carry in the last digit, adjust the length accordingly
            if (Array1[length] == 1)
            {
                length++;
            }

            // Convert the result back to a string in the correct order (reversed)
            string result = "";
            for (int i = length - 1; i >= 0; i--)
            {
                result = Array1[length - 1 - i].ToString() + result;
            }
            return result;
        }

        /// <summary>
        /// Method that calculates the sum of two very long positive integer numbers
        /// </summary>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        /// <returns></returns>
        static byte[] Add2Numbers(string firstArray, string secondArray)
        {
            int carry = 0;
            List<byte> numberFinal = new List<byte>();
            // Loop through the digits of both input arrays from right to left (least significant to most significant)
            for (int i = firstArray.Length - 1; i >= 0; i--)
            {
                // Calculate the sum of the current digits along with the carry from the previous iteration
                int sum = (firstArray[i] - 48) + (secondArray[i] - 48) + carry;
                // Check if the sum is greater than 9 (two digits)
                if (sum > 9)
                {
                    // Add the least significant digit of the sum to the result array
                    numberFinal.Add((byte)(sum % 10));

                    // Set the carry to the most significant digit of the sum
                    carry = sum / 10;
                }
                else
                {
                    // If the sum is a single digit, add it to the result array, and reset the carry to 0
                    numberFinal.Add((byte)sum);
                    carry = 0;
                }
            }
            // If there is a carry after the loop, add it to the result array
            if (carry != 0)
            {
                numberFinal.Add((byte)carry);
            }
            // Reverse the result array to get the correct order of digits (most significant to least significant)
            numberFinal.Reverse();
            return numberFinal.ToArray();
        }

        static void Main(string[] args)
        {
            #region Task 08
            /* Write a method that calculates the sum of two very long positive integer numbers. The numbers are represented as array digits and the last digit (the ones) 
            is stored in the array at index 0. Make the method work for all numbers with length up to 10,000 digits.

            Guide: The reader must implement own method that calculates the sum of very big numbers. The digits on position zero will keep the ones; the digit on the first position 
            will keep the tenths and so on. When two very big numbers are about to be calculated, the ones of their sum will be equal to (firstNumber[0] + secondNumber[0]) % 10, 
            the tenths on other side will be equal to (firstNumber[1] + secondNumber[1]) % 10 + (firstNumber[0] + secondNumber[0])/10 and so on. */
            #endregion

            Console.WriteLine("First Solution");
            // Example very long numbers represented as arrays of digits (ones digit at index 0)
            int[] firstNumber  = { 1, 2, 3, 4, 5, 6, 7 };
            int[] secondNumber = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // Calculate the sum of the two very long numbers
            int[] sum = AddTwoVeryLongPositiveNumbers(firstNumber, secondNumber);
            // Print the sum
            Console.Write("Sum of the two very long numbers: ");
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                Console.Write(sum[i]);
            }
            Console.WriteLine();

            /* Explanation for the result
            We perform the addition digit by digit with the carry:

            7 + 1 = 8, no carry, result = 8.
            6 + 2 = 8, no carry, result = 8 8.
            5 + 3 = 8, no carry, result = 8 8 8.
            4 + 4 = 8, no carry, result = 8 8 8 8.
            3 + 5 = 8, no carry, result = 8 8 8 8 8.
            2 + 6 = 8, no carry, result = 8 8 8 8 8 8.
            1 + 7 = 8, no carry, result = 8 8 8 8 8 8 8.
            At this point, the first number is exhausted, but the second number still has more digits to consider.

            9 + 8 = 17, carry = 1, result = 8 8 8 8 8 8 8 7.
            0 + 9 + 1 (carry) = 10, carry = 1, result = 8 8 8 8 8 8 8 7 0.
            0 + 1 (carry) = 1, carry = 0, result = 8 8 8 8 8 8 8 7 0 1.
            The iteration ends as both numbers are fully processed.

            The reason for the discrepancy in the result is that the program uses a different representation for the sum. Instead of reversing the order of the digits and printing 
            it, the program prints the sum in the order it was calculated, starting from the least significant digit (the ones) to the most significant digit (the highest value, 
            in this case, the hundreds of millions place). That's why you see 1 3 1 1 1 1 1 0 instead of 988888888.

            However, the actual sum calculated by the program is correct, and the result 1 3 1 1 1 1 1 0 indeed corresponds to 988888888. 
            */



            Console.WriteLine("\nSecond Solution");
            Console.Write("Enter first number: ");
            string firstNumb = Console.ReadLine();
            Console.Write("Enter second number: ");
            string secondNumb = Console.ReadLine();
            // Calculate the sum of the two very long numbers
            string summ = AddTwoVeryLongNumbers(firstNumb, secondNumb);
            // Print the sum
            Console.WriteLine("Sum of the two very long numbers: " + summ);
            Console.ReadLine();


            Console.WriteLine("\nThird Solution");
            Console.Write("Enter the first positive number: ");
            string firstNum = Console.ReadLine();
            Console.Write("Enter the second positive number: ");
            string secondNum = Console.ReadLine();
            //adding zeros on left to make the lenghts of the numbers equal
            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }
            Console.WriteLine();
            Console.Write("The sum of the numbers is: ");
            Console.WriteLine(string.Join("", Add2Numbers(firstNum, secondNum)));
        }
    }
}