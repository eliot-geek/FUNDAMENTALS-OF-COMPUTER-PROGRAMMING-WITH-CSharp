using System;

namespace Ex09SubsetsWhoseSum0
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0.Examples:
            //- If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1 is 0.
            //- If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets with sum 0.
            // Guide: Use nested if statements or series of 31 comparisons, in order to check all the sums of the 31 subsets of the given numbers(without the empty one).
            // Note that the problem in general(with N numbers) is complex and using loops will not be enough to solve it.

            // Input 5 numbers
            Console.WriteLine("Enter five integer numbers, separated by a space:");
            string[] inputNumbers = Console.ReadLine().Split();
            int[] numbers = new int[inputNumbers.Length];

            // Convert the input strings to integers
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }

            // Check all 31 non-empty subsets of the given numbers
            bool hasSubsetWithSumZero = false;
            for (int i = 1; i <= 31; i++)
            {
                int sum = 0;
                string subset = "";
                for (int j = 0; j < 5; j++)
                {
                    // The >> operator shifts the bits of i to the right by j places. In this case, j=0, so the value of i >> j is simply i.
                    // Therefore, we can replace (i >> j) with i and simplify the expression to: i & 1
                    // 0001 & 0001 = 0001 - Therefore, i & 1 is equal to 1.
                    // (i >> j) & 1 == 1   ====  (1) & 1 == 1  ====  if i=1 and j=0, then (i >> j) & 1) == 1 is true. etc..
                    if (((i >> j) & 1) == 1)
                    {
                        sum += numbers[j];
                        subset += numbers[j] + " ";
                    }
                }
                if (sum == 0)
                {
                    Console.WriteLine("Subset with sum 0: {0}", subset);
                    hasSubsetWithSumZero = true;
                }
            }

            // If no subset with sum 0 is found, print a message
            if (!hasSubsetWithSumZero)
            {
                Console.WriteLine("No subset with sum 0.");
            }
            Console.ReadKey();



            Console.WriteLine("\nSecond Solution");
            //Console.Write("Enter first number: ");
            //int first = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int second = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //int third = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter fourth number: ");
            //int fourth = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter fifth number: ");
            //int fifth = Int32.Parse(Console.ReadLine());

            double first = 3, second = -2, third = 1, fourth = 1, fifth = 8;
            Console.WriteLine("\nThe five (5) integer numbers are : {0}, {1}, {2}, {3}, {4}", first, second, third, fourth, fifth);

            if (first + second == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, second);
            }
            else if (first + third == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, third);
            }
            else if (first + fourth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, fourth);
            }
            else if(first + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, fifth);
            }
            else if(second + third == 0)
            {
                Console.WriteLine("{0} + {1} = 0", second, third);
            }
            else if(second + fourth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", second, fourth);
            }
            else if(second + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", second, fifth);
            }
            else if(third + fourth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", third, fourth);
            }
            else if(third + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", third, fifth);
            }
            else if(fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", fourth, fifth);
            }
            else if(first + second + third == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, third);
            }
            else if(first + second + fourth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, fourth);
            }
            else if(first + second + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, fifth);
            }
            else if(first + third + fourth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, third, fourth);
            }
            else if(first + third + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, third, fifth);
            }
            else if(first + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, fourth, fifth);
            }
            else if(second + third + fourth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", second, third, fourth);
            }
            else if(second + third + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", second, third, fifth);
            }
            else if(second + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", second, fourth, fifth);
            }
            else if(third + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", third, fourth, fifth);
            }
            else
            {
                Console.WriteLine("There is no subsets with sum 0");
            }

            Console.ReadLine();
        }
    }
}
