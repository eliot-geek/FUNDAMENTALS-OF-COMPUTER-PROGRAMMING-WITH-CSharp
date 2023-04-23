using System;

namespace Less10LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lucky Numbers 

            // Our purpose is to find and print all four-digit numbers of the type ABCD, where: A+B = C+D
            // (we call them lucky numbers). We will implement it with four for-loops – one for each digit.
            // The outermost loop will define the thousands. It will start from 1 and the rest of the loops – from 0.
            // They will determine the hundreds, the tens and the units.

            // The following code will print out all four-digit numbers whose sum of the first two digits is equal to the sum of the last two digits
            Console.WriteLine("Lucky Numbers\n");
            // It does this by iterating through all possible combinations of digits using four nested for loops
            for (int a = 1; a <= 9; a++) // Loops through all possible values for the first digit (1-9)
            {
                for (int b = 0; b <= 9; b++)  // Loops through all possible values for the second digit (0-9)
                {
                    for (int c = 0; c <= 9; c++) // Loops through all possible values for the third digit (0-9)
                    {
                        for (int d = 0; d <= 9; d++) // Loops through all possible values for the fourth digit (0-9)
                        {
                            if ((a + b) == (c + d))  // Checks if the sum of the first two digits is equal to the sum of the last two digits
                            {
                                Console.WriteLine(a + " " + b + " " + c + " " + d); // Prints out the lucky number combination
                            }
                        }
                    }
                }
            }

            // Result

            // 1 0 0 1
            // 1 0 1 0
            // 1 1 0 2
            // 1 1 1 1
            // 1 1 2 0
            // 1 2 0 3
            // 1 2 1 2
            // ....
            // ....
            // ....
            // 9 8 8 9
            // 9 8 9 8
            // 9 9 9 9
        }
    }
}
