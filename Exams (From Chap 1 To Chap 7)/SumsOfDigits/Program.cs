namespace SumsOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sum of Digits - Compare Sums of Two Halves
            /* The program takes an integer n as input, which represents the number of rounds to be processed. In each round, the program takes an integer num as input. 
             * The task is to calculate the sum of the digits in the first half and the sum of the digits in the second half of the given number num. 
             * Then, the program compares the two sums and determines the result based on the following conditions:*/
            #endregion

            Console.Write("Enter the number of rounds (n) to be processed: ");
            int n = int.Parse(Console.ReadLine());

            // Variables to store the sum of digits in the first half and the second half
            int sumV = 0; // Sum of digits in the second half
            int sumM = 0; // Sum of digits in the first half

            // Process each round
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the number for the current round (num): ");
                int num = int.Parse(Console.ReadLine());

                // Convert the number to its absolute value to handle negative numbers
                num = Math.Abs(num);

                // Convert the number to a string to extract its digits
                string numto = num.ToString();

                // Check if the number of digits is even or odd
                if (numto.Length % 2 == 0)
                {
                    // If the number has an even number of digits, divide it into two halves and calculate the sum of each half
                    // Calculate the sum of digits in the first half (from the beginning to the middle)
                    for (int k = 0; k <= numto.Length / 2 - 1; k++)
                    {
                        sumM += numto[k] - 48; // Convert the character to its integer value and add it to sumM
                    }

                    // Calculate the sum of digits in the second half (from the middle to the end)
                    for (int k = numto.Length / 2; k <= numto.Length - 1; k++)
                    {
                        sumV += numto[k] - 48; // Convert the character to its integer value and add it to sumV
                    }
                }
                else
                {
                    // If the number has an odd number of digits, consider the middle digit as part of both halves
                    // Calculate the sum of digits in the first half (from the beginning to the middle)
                    for (int k = 0; k <= numto.Length / 2; k++)
                    {
                        sumM += numto[k] - 48; // Convert the character to its integer value and add it to sumM
                    }

                    // Calculate the sum of digits in the second half (from the middle to the end)
                    for (int k = numto.Length / 2; k <= numto.Length - 1; k++)
                    {
                        sumV += numto[k] - 48; // Convert the character to its integer value and add it to sumV
                    }
                }
            }
            // Output the result of the comparison between the sums of the two halves
            if (sumM == sumV)
            {
                Console.WriteLine("No {0}", sumM + sumV);
            }
            else if (sumM > sumV)
            {
                Console.WriteLine("Left M {0}", sumM - sumV);
            }
            else if (sumM < sumV)
            {
                Console.WriteLine("Right V {0}", sumV - sumM);
            }
        }
    }
}