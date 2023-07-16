namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task Coffee Machine Simulator
            /* Write a program, which simulates a coffee machine where customers can purchase different products by inserting money. 
             * The coffee machine has five types of coins (denominations): 0.05, 0.10, 0.20, 0.50, and 1.00 units. The customer can use these coins to make a payment. 
             * The coffee machine can hold a limited number of each coin type, and the user must specify the initial quantities of each coin type when running the program.*/
            #endregion

            Console.WriteLine("Enter the 5 integer values: ");
            int n1, n2, n3, n4, n5;
            // Read the initial quantity of each coin type from the user input and validate the input
            if (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Invalid input for n1. Please enter a valid integer.");
                return;
            }

            if (!int.TryParse(Console.ReadLine(),out n2))
            {
                Console.WriteLine("Invalid input for n2. Please enter a valid integer.");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out n3))
            {
                Console.WriteLine("Invalid input for n3. Please enter a valid integer.");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out n4))
            {
                Console.WriteLine("Invalid input for n4. Please enter a valid integer.");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out n5))
            {
                Console.WriteLine("Invalid input for n5. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter the amount of money and the price");
            // Read the amount of money inserted by the customer and the product price
            double a, p;
            // Amount of money inserted by the customer
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input for a. Please enter a valid integer.");
                return;
            }
            // Product price
            if (!double.TryParse(Console.ReadLine(), out p))
            {
                Console.WriteLine("Invalid input for p. Please enter a valid integer.");
                return;
            }

            // Calculate the total amount of money in the coin tray
            double amount = n1 * 0.05 + n2 * 0.1 + n3 * 0.2 + n4 * 0.5 + n5 * 1.00;

            // Check if the customer inserted enough money and there is enough change in the tray
            if (a >= p && amount + p > a)
            {
                // Calculate the change to be returned to the customer and display the result
                Console.WriteLine("Yes {0:F2}", (double) a - p);
            }

            // Check if the customer didn't insert enough money
            if (a < p)
            {
                // Calculate the additional amount of money needed to purchase the product
                double more = p - a;
                Console.WriteLine("More {0:F2}", more);
            }

            // Check if the customer inserted more money than the product price, but there's not enough change
            if (a >= p && amount + p < a)
            {
                // Calculate the amount short to complete the transaction and display the result
                Console.WriteLine("No {0:F2}", (double)Math.Abs(amount + p - a));
            }
            Console.WriteLine();
        }
    }
}