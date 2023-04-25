using System;

namespace Ex03SmallestLargestDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 3
            // Write a program that reads from the console a series of integers and prints the smallest and largest of them.
            // Guide: First read the count of numbers, for example in a variable n. Then consequently enter n numbers with one for loop.
            // While entering each new number, save in two variables the smallest and the largest number until this moment.
            // At the start initialize the smallest and the largest number with Int32.MaxValue and Int32.MinValue respectively.
            #endregion

            Console.Write("Enter number of integers : ");
            int n = Int32.Parse(Console.ReadLine());
            int smallest = Int32.MinValue;
            int largest = Int32.MaxValue;
            int input;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number : ", i);
                input = Int32.Parse(Console.ReadLine());

                if (i == 0)
                {
                    smallest = largest = input;
                }
                else
                {
                    if (smallest > input)
                    {
                        smallest = input;
                    }
                    if (largest < input)
                    {
                        largest = input;
                    }
                }
            }
            Console.WriteLine("The smallest numbers is : {0} \nThe largest number is : {1}", smallest, largest);
            Console.ReadLine();


            Console.WriteLine("\nSolution 2");
            Console.Write("Enter the count of numbers: ");
            int numb = Convert.ToInt32(Console.ReadLine()); // read the count of numbers

            int smal = Int32.MaxValue; // initialize smallest with the maximum value of integer
            int larg = Int32.MinValue; // initialize largest with the minimum value of integer

            // iterate numb times
            for (int i = 0; i < numb; i++)
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine()); // read the entered number

                // check if the entered number is smaller than the current smallest
                if (num < smal) 
                {
                    // if so, update smallest to the entered number
                    smal = num;
                }

                // check if the entered number is larger than the current largest
                if (num > larg)
                {
                    // if so, update largest to the entered number
                    larg = num;
                }
            }
            Console.WriteLine("Smallest number: " + smal); // print the smallest number
            Console.WriteLine("Largest number: " + larg); // print the largest number
        }
    }
}
