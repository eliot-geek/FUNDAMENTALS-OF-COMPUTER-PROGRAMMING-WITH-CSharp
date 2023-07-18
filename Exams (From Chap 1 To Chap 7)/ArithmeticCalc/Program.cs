namespace ArithmeticCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arithmetic Calculations (Switch)
            /* This C# program reads three input values from the user: a double a, an integer b, and another double c. 
             * Based on the value of b, the program performs specific calculations and outputs the results r and k.
            
            Read three input values: a, b, and c, from the user.
            Initialize two double variables, r and k, to store the results of the calculations.
            Use a switch statement to determine the calculation based on the value of b:
            If b is 3, calculate r as the sum of a and c.
            If b is 6, calculate r as the product of a and c.
            If b is 9, calculate r as the remainder of a divided by c.
            For any other value of b, do nothing (default case).
            Assign the value of r to the variable k.
            Check if r is divisible by 3:
            If yes, divide r by 3 and store the result back in r.
            If no, calculate the remainder of r divided by 3 and store the result back in r.
            Output the final values of r and k to the console.*/
            #endregion

            // Read input values from the user
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            // Initialize variables to store the results
            double r = 0;
            double k = 0;

            // Perform calculations based on the value of 'b'
            switch (b)
            {
                case 3:
                    r = a + c;  // If 'b' is 3, calculate 'r' as the sum of 'a' and 'c'
                    break;
                case 6:
                    r = a * c;  // If 'b' is 6, calculate 'r' as the product of 'a' and 'c'
                    break;
                case 9:
                    r = a % c;  // If 'b' is 9, calculate 'r' as the remainder of 'a' divided by 'c'
                    break;
                default:
                    break;  // For any other value of 'b', do nothing
            }

            // Assign the value of 'r' to variable 'k'
            k = r;

            // Check if 'r' is divisible by 3
            if ((r % 3) == 0)
            {
                r = r / 3;  // If 'r' is divisible by 3, divide 'r' by 3 and store the result back in 'r'
            }
            else
            {
                r = r % 3;  // If 'r' is not divisible by 3, calculate the remainder of 'r' divided by 3 and store the result back in 'r'
            }

            // Output the final values of 'r' and 'k'
            Console.WriteLine("Final r: " + r);
            Console.WriteLine("k: " + k);
        }
    }
}