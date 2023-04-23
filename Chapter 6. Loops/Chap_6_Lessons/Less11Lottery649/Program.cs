using System;

namespace Less11Lottery649
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lottery 6/49 - We will find all possible combinations of the lottery game "6/49".

            int count = 0; // counter for the number of combinations
            for (int num1 = 1; num1 <= 44; num1++) // first number loop
            {
                for (int num2 = num1 + 1; num2 <= 45; num2++) // second number loop
                {
                    for (int num3 = num2 + 1; num3 <= 46; num3++) // third number loop
                    {
                        for (int num4 = num3 + 1; num4 <= 47; num4++) // fourth number loop
                        {
                            for (int num5 = num4 + 1; num5 <= 48; num5++) // fifth number loop
                            {
                                for (int num6 = num5 + 1; num6 <= 49; num6++) // sixth number loop
                                {
                                    count++; // increment the counter for each combination
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Total number of combinations: {0}", count); // print the total number of combinations
            Console.ReadLine();
            
            
            // We have to find and print all possible extracts of 6 different numbers, each of which is in the range [1…49].
            // We will use 6 for-loops. The numbers cannot be repeated.
            // To avoid repetitions we will strive for each subsequent number to be larger than the previous.
            // Therefore, the internal loops will not start from 1 but from the number to which the previous loop got + 1.
            // We will have to go through the first loop until it reaches 44 (and not to 49), the second – 45, etc.
            // The last loop will be up to 49.If you make all loops to 49 you will receive matching numbers in certain combinations.
            // For the same reason, each subsequent cycle starts from the previous loop counter +1.

            Console.WriteLine("LOTTERY GAME 6/49\n");

            for (int i1 = 1; i1 <= 44; i1++)  // Loops through possible values for the first number in the combination (1-44)
            {
                for (int i2 = i1; i2 <= 45; i2++)  // Loops through possible values for the second number in the combination (i1-45)
                {
                    for (int i3 = i2; i3 <= 46; i3++)  // Loops through possible values for the third number in the combination (i2-46)
                    {
                        for (int i4 = i3; i4 <= 47; i4++)  // Loops through possible values for the fourth number in the combination (i3-47)
                        {
                            for (int i5 = i4; i5 <= 48; i5++) // Loops through possible values for the fifth number in the combination (i4-48)
                            {
                                for (int i6 = i5; i6 <= 49; i6++) // Loops through possible values for the sixth number in the combination (i5-49)
                                {
                                    // Prints out the combination of 6 numbers
                                    Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6);
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();

            /* Everything looks correct. Let’s run the program. It seems to work but there is one problem – 
             * there are too many combinations and the program does not end (it is so slow, that hardly anyone is going to wait). 
             * This is correct and it is one of the reasons why there is Lottery 6/49 – there really are lots of combinations. */

            // ..........
            // 44 45 46 46 48 48
            // 44 45 46 46 48 49
            // 44 45 46 47 47 47
            // 44 45 46 47 47 48
            // 44 45 46 47 47 49
            // 44 45 46 47 48 48
            // 44 45 46 47 48 49

        }
    }
}
