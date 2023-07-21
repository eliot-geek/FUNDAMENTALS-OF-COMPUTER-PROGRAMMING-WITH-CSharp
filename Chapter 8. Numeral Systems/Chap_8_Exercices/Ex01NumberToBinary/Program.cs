namespace Ex01NumberToBinary
{
    internal class Program
    {
        /// <summary>
        /// Decimal To Binary
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static string DecimalToBinaryFunc(int number)
        {
            int remainder;
            string result = string.Empty;

            while (number > 0)
            {
                remainder = number % 2;
                result = remainder.ToString() + result;
                number /= 2;
            }

            return result;
        }

        /// <summary>
        /// DecimalToBinary
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <returns></returns>
        static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0"; // Special case for input value of 0

            string binary = string.Empty;
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;          // Get the remainder when dividing by 2
                binary = remainder.ToString() + binary;     // Add the remainder to the binary string (in reverse order)
                decimalNumber /= 2;                         // Update the decimal number by dividing it by 2
            }
            // Return the binary representation of the decimal number
            return binary; 
        }

        static void Main(string[] args)
        {
            #region Task 01: Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system. 
            /* Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system. 
            
            Solutions and Guidelines : Use the methods for conversion from one numeral system to another. You can check your results with the help of the Windows built-in calculator, 
            which supports numeral systems in "Programmer" mode. The results are: 10010111, 100011, 101011, 11111011, 1111111111 and 10000000000. */
            #endregion

            Console.WriteLine("First Method");
            Console.WriteLine("0151 to binary {0}", Convert.ToString(0151, 2));
            Console.WriteLine("0035 to binary {0}", Convert.ToString(0035, 2));
            Console.WriteLine("0043 to binary {0}", Convert.ToString(0043, 2));
            Console.WriteLine("0251 to binary {0}", Convert.ToString(0251, 2));
            Console.WriteLine("1023 to binary {0}", Convert.ToString(1023, 2));
            Console.WriteLine("1024 to binary {0}", Convert.ToString(1024, 2));
            Console.ReadKey(); Console.WriteLine();


            Console.WriteLine("\nSecond Method");
            int[] numbers = { 151, 35, 43, 251, 1023, 1024 };
            Console.WriteLine("Decimal\t\tBinary");
            foreach (int num in numbers)
            {
                string binary = DecimalToBinary(num); // Convert the decimal number to binary
                Console.WriteLine($"{num}\t\t{binary}");
            }
            Console.ReadKey(); Console.WriteLine();


            Console.WriteLine("\nThird Method");
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of {0} is {1}", number, DecimalToBinaryFunc(number));
            Console.ReadKey(); Console.WriteLine();


            Console.WriteLine("\nFourth Method");
            // The ? is to declare the array N as an array of nullable bytes
            // The number is of type int, so the length is 32 bits
            byte?[] N = new byte?[32]; 
            // Initialize the array with zeros
            for (byte i = 0; i < N.Length; i++)
            {
                N[i] = 0;
            }

            // Read the integer number from the user
            Console.Write("Please, enter an integer decimal number: ");
            int numb = int.Parse(Console.ReadLine());
            int temp = numb;
            // If the number is negative, handle it as two's complement representation
            if (numb < 0)
            {
                numb = int.MaxValue + numb + 1;
                N[N.Length - 1] = 1; // Sets 1 on the leftmost bit to represent the sign
            }

            // Convert the decimal number to binary representation using an array of bytes
            while (numb > 0)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    // Find the position of the highest bit that needs to be set to 1
                    if (Math.Pow(2, i + 1) > numb)
                    {
                        N[i] = 1; // Sets 1 for this bit
                        numb -= (int)Math.Pow(2, i); // Decrease the number by this bit value
                        break;
                    }
                }
            }
            Array.Reverse(N); // Reverse the array to get the correct binary representation

            // Remove leading zeros from positive numbers
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] == 0)
                    N[i] = null; // Set zeros to null to be ignored when printing
                else
                    break; // Stop removing zeros when the first 1 is encountered
            }

            // Print the result: Binary representation of the entered number
            Console.Write("Binary representation of this number is: ");
            if (temp != 0)
            {
                foreach (var item in N)
                {
                    Console.Write(item); // Print the binary representation
                }
            }
            else
            {
                Console.Write(0); // If the number entered was 0, print 0 as binary representation
            }
            Console.WriteLine();
        }
    }
}