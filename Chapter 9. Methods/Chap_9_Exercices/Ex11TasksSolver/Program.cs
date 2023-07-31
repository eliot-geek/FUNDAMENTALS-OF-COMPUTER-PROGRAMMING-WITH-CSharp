namespace Ex11TasksSolver
{
    internal class Program
    {
        /// <summary>
        /// Ensures that the user enters a valid menu option (1, 2, 3, or 4) and continues to prompt the user until a valid input is received. 
        /// </summary>
        /// <returns></returns>
        static int GetValidOption()
        {
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }
            return option; 
        }

        /// <summary>
        /// Reverse Digits
        /// </summary>
        static void ReverseDigits()
        {
            Console.Write("Enter a positive integer number between 1 and 50,000,000: ");
            int number = GetValidPositiveInteger(); 

            int reversedNumber = ReverseNumberDigits(number); 
            Console.WriteLine($"Reversed number: {reversedNumber}");
        }

        /// <summary>
        /// Get a valid positive integer from the user
        /// </summary>
        /// <returns></returns>
        static int GetValidPositiveInteger()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0 || number > 50000000)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer between 1 and 50,000,000.");
            }
            return number;
        }

        /// <summary>
        /// Calculate the reversed number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int ReverseNumberDigits(int number)
        {
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit; 
                number /= 10;
            }
            return reversedNumber; 
        }

        /// <summary>
        /// Calculate Average
        /// </summary>
        static void CalculateAverage()
        {
            Console.Write("Enter a sequence of numbers separated by spaces: ");
            string input = Console.ReadLine();

            string[] numbersArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (numbersArray.Length == 0)
            {
                Console.WriteLine("Error: The sequence of numbers cannot be empty.");
                return;
            }

            double sum = 0;
            foreach (string numStr in numbersArray)
            {
                if (double.TryParse(numStr, out double number))
                {
                    sum += number; // Calculate the sum of numbers in the sequence
                }
                else
                {
                    Console.WriteLine($"Invalid number: {numStr}");
                    return;
                }
            }

            double average = sum / numbersArray.Length; // Calculate the average
            Console.WriteLine($"Average: {average}");
        }

        /// <summary>
        /// Solve Linear Equation
        /// </summary>
        static void SolveLinearEquation()
        {
            Console.Write("Enter the coefficient a (non-zero): ");
            double a = GetValidNonZeroCoefficient(); 

            Console.Write("Enter the constant term b: ");
            double b = double.Parse(Console.ReadLine());

            double x = -b / a; 
            Console.Write($"Solution: x = {x}");
        }

        /// <summary>
        /// Get Valid Non Zero Coefficient
        /// </summary>
        /// <returns></returns>
        static double GetValidNonZeroCoefficient()
        {
            double coefficient;
            while (!double.TryParse(Console.ReadLine(), out coefficient) || coefficient == 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-zero value for coefficient a.");
            }
            return coefficient; 
        }

        static void Main(string[] args)
        {
            #region Task 11
            /* Write a program that solves the following tasks:
            - Put the digits from an integer number into a reversed order.
            - Calculate the average of given sequence of numbers.
            - Solve the linear equation a * x + b = 0.
            Create appropriate methods for each of the above tasks.
            Make the program show a text menu to the user. By choosing an option of that menu, the user will be able to choose which task to be invoked.
            
             Perform validation of the input data:
            - The integer number must be a positive in the range [1…50,000,000].
            - The sequence of numbers cannot be empty.
            - The coefficient a must be non-zero.
            
             Guide: Firstly, create the necessary methods. To create the menu display a list in which the actions are represented as numbers 
            (1 – reverse, 2 – average, 3 – equation). Ask the user to choose from 1 to 3.*/
            #endregion

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Reverse digits of an integer number");
                Console.WriteLine("2. Calculate average of a sequence of numbers");
                Console.WriteLine("3. Solve a linear equation (a * x + b = 0)");
                Console.WriteLine("4. Exit");

                int option = GetValidOption(); 
                switch (option)
                {
                    case 1:
                        ReverseDigits(); 
                        break;
                    case 2:
                        CalculateAverage(); 
                        break;
                    case 3:
                        SolveLinearEquation(); 
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        return; 
                }
            }
        }
    }
}