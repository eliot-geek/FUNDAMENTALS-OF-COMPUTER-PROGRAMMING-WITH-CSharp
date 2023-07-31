using System.Numerics;

namespace Ex10NumbFactorial
{
    internal class Program
    {
        /// <summary>
        /// Method to calculate the factorial of n using BigInteger
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static BigInteger CalculateFactorial2(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        /// <summary>
        /// Method to calculate the factorial of n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int[] Factorial(int n)
        {
            // in numberFinal is saved every digit in the current iteration
            List<int> numberFinal = new List<int>();

            // in num is saved the value of the number after the multiplication
            string num = "1";

            // Calculating the factorial
            for (int i = 1; i <= n; i++)
            {
                // Clear the list and fill it again with the current iteration
                numberFinal.Clear();
                int carry = 0;

                // Loop through the digits of the current number (in string format)
                for (int j = 0; j < num.Length; j++)
                {
                    int currentDigit = num[j] - 48; // Convert the character to an integer digit

                    // Perform the multiplication digit by digit and handle carry
                    if (currentDigit * i + carry > 9)
                    {
                        numberFinal.Add((currentDigit * i + carry) % 10); // Add the least significant digit to the list
                        carry = (currentDigit * i + carry) / 10; // Update the carry for the next iteration
                    }
                    else
                    {
                        numberFinal.Add((currentDigit * i) + carry); // Add the product to the list (no carry)
                        carry = 0; // Reset the carry
                    }
                }

                // If there is a carry after the loop, add it to the list
                if (carry != 0)
                {
                    if (carry > 9)
                    {
                        // If the carry is greater than 9, split it into individual digits and add them to the list
                        while (carry >= 1)
                        {
                            byte remainder = (byte)(carry % 10);
                            carry /= 10;
                            numberFinal.Add(remainder);
                        }
                    }
                    else
                    {
                        numberFinal.Add(carry); // Add the carry to the list
                    }
                }

                // Save the current number for the next iteration
                num = string.Join("", numberFinal.ToArray());
            }
            // Convert the list to an array and reverse it to get the correct order of digits (most significant to least significant)
            int[] array = new int[numberFinal.Count];
            numberFinal.CopyTo(array);
            Array.Reverse(array);

            return array;
        }

        static void Main(string[] args)
        {
            #region Task 10
            /* Write a program that calculates and prints the n! for any n in the range [1…100].
            
            Guide: The reader must implement own method that calculates the product of very big numbers, because the value of 100! does not fit in variable of type ulong or decimal. 
            The numbers can be represented in an array of reversed digits (one digit in each element). For example, the number 512 can be represented as {2, 1, 5}. 
            Then the multiplication can be implemented in the way done in the elementary school (multiply digit by digit and then calculate the sum).
            Another easier way to work with extremely large numbers such as 100! is by using the library System.Numerics.dll (you have to add a reference to it in your project). 
            Look for Information in internet about how to use the class System.Numerics.BigInteger.
            Finally calculate in a loop k! for k = 1, 2, …, n. */
            #endregion

            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid input. n must be in the range [1...100].");
            }
            else
            {
                BigInteger factorial2 = CalculateFactorial2(n);
                Console.WriteLine(n + "! = " + factorial2);
                Console.ReadLine();
            }



            Console.WriteLine("\nSecond Method with the range [1....n]");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join("", Factorial(numb)));
            Console.ReadLine();
        }
    }
}