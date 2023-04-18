using System;

namespace Ex04Sort3RealNumbersDesce
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort 3 real numbers in descending order. Use nested if statements.
            // Guide : First find the smallest of the three numbers, and then swap it with the first one. Then check if the second is greater than the third number and if yes, swap them too.
            // Another approach is to check all possible orders of the numbers with a series of if-else checks: a≤b≤c, a≤c≤b, b≤a≤c, b≤c≤a, c≤a≤b and c≤b≤a.
            // A more complicated and more general solution of this problem is to put the numbers in an array and use the Array.Sort(…) method.You may read about arrays in the chapter “Arrays”.

            // First find the smallest of the three numbers, and then swap it with the first one. Then check if the second is greater than the third number and if yes, swap them too.
            Console.WriteLine("First Method");
            double num1 = 10;
            double num2 = 5;
            double num3 = 8;

            // Find the smallest number
            if (num2 < num1 && num2 < num3)
            {
                double temp = num1;
                num1 = num2;
                num2 = temp;
            }
            else if (num3 < num1 && num3 < num2)
            {
                double temp = num1;
                num1 = num3;
                num3 = temp;
            }

            // Check if the second number is greater than the third
            if (num3 < num2)
            {
                double temp = num2;
                num2 = num3;
                num3 = temp;
            }
            // Print the sorted numbers
            Console.WriteLine($"{num3}, {num2}, {num1}");
            Console.ReadKey();


            // Another approach is to check all possible orders of the numbers with a series of if-else checks: a≤b≤c, a≤c≤b, b≤a≤c, b≤c≤a, c≤a≤b and c≤b≤a.
            Console.WriteLine("\nSecond Method");
            double x = 10;
            double y = 5;
            double z = 7;

            if (x <= y && y <= z)
            {
                // z >= y >= x
                Console.WriteLine($"{z}, {y}, {x}");
            }
            else if (x <= z && z <= y)
            {
                // y >= z >= x
                Console.WriteLine($"{y}, {z}, {x}");
            }
            else if (y <= x && x <= z)
            {
                // z >= x >= y
                Console.WriteLine($"{z}, {x}, {y}");
            }
            else if (y <= z && z <= x)
            {
                // x >= z >= y
                Console.WriteLine($"{x}, {z}, {y}");
            }
            else if (z <= x && x <= y)
            {
                // y >= x >= z
                Console.WriteLine($"{y}, {x}, {z}");
            }
            else
            {
                // x >= y >= z
                Console.WriteLine($"{x}, {y}, {z}");
            }
            Console.ReadKey();


            // Put the numbers in an array and use the Array.Sort(…) method.
            Console.WriteLine("\nThird Method");
            // Define 3 double variables and initialize them with some values
            double p = 5;
            double q = 3;
            double r = 7;

            // Create an array of doubles and initialize it with the 3 variables above
            double[] arr = new double[] { p, q, r };
            // Sort the array of doubles in ascending order using the Array.Sort method
            Array.Sort(arr);
            // Reverse the array of doubles to get them in descending order
            Array.Reverse(arr);
            // Join the elements of the array into a single string separated by commas and print it to the console
            Console.WriteLine(string.Join(", ", arr));
            Console.ReadKey();


            Console.WriteLine("\nFourth Method");
            Console.Write("Enter first number : ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Enter third number : ");
            double c = Double.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("Descending order : {0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("Descending order : {0} {1} {2}", a, c, b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("Descending order : {0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("Descending order : {0} {1} {2}", b, c, a);
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("Descending order : {0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("Descending order : {0} {1} {2}", c, b, a);
                }
            }
            Console.ReadKey();


            // Print a message to the console indicating that the fifth method is being used
            Console.WriteLine("\nFifth Method");
            // Prompt the user to enter three numbers and read them from the console
            Console.Write("Enter first number : ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Enter third number : ");
            c = Double.Parse(Console.ReadLine());

            // Sort the numbers in descending order using nested if statements
            if (a < b)
            {
                if (a < c)
                {
                    // Swap a and c
                    a = a + c;
                    c = a - c;
                    a = a - c;

                    if (b > c)
                    {
                        // Swap a and b
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
                else if (a >= c)
                {
                    // Swap a and b
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a == b)
            {
                if (a < c)
                {
                    // Swap a and c
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b < c)
                {
                    // Swap b and c
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    // Swap a and b
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            // Print the sorted numbers to the console
            Console.WriteLine("Descending Order : {0} {1} {2}", a, b, c);
        }
    }
}
