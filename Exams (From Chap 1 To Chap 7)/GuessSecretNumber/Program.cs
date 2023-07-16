namespace GuessSecretNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Guess the Secret Number
            /* The program is a simple number guessing game, where the player tries to guess a secret 4-digit number based on the given clues. 
             * The player can input the number of correct digits in the correct position (b) and the number of correct digits in the wrong position (c). 
             * The program then generates possible 4-digit numbers and checks them against the given clues to find the secret number.

            Conditions:
            Input:
            secretNumber: The secret 4-digit number. This is the number the player needs to guess.
            b: The number of correct digits in the correct position provided by the player.
            c: The number of correct digits in the wrong position provided by the player.
            
            Number Guessing Algorithm:
            The program uses a for loop to generate numbers from 1000 to 9999.
            For each generated number, it checks for certain conditions:
            It ensures that the generated number does not contain any zero digits (skip numbers with zeros).
            It compares each digit of the generated number to each digit of the secret number:
            If the digit matches both in value and position, it increments the count of correct digits in the correct position (countb).
            If the digit matches in value but not in position, and the digit is not already counted as a correct digit in the wrong position (countc), 
            it increments the count of correct digits in the wrong position (countc) and remembers the current digit to avoid counting it twice.
            If the count of correct digits in the correct position (countb) matches the input (b) and the count of correct digits in the wrong position (countc) 
            matches the input (c), the program considers the number a possible candidate for the secret number.
            
            Output:
            If there is at least one possible candidate for the secret number based on the given clues, the program prints the candidate numbers separated by spaces.
            If no candidates are found based on the given clues, the program prints "No."
            The program essentially tries to deduce the secret number by generating all possible 4-digit numbers and checking them against the given hints (b and c) 
            to find the ones that match. It then displays the potential secret numbers that meet the given conditions.*/
            #endregion

            int secretNumber, b, c;

            // Read the secret number from the user input
            Console.WriteLine("Enter the secret 4-digit number");
            if (!int.TryParse(Console.ReadLine(), out secretNumber))
            {
                Console.WriteLine("Invalid input for secretNumber. Please enter a valid integer.");
                return;
            }

            // Read the number of correct digits in the correct position (b) and in the wrong position (c)
            Console.WriteLine("Enter the number of correct digits in the correct position");
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input for b. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter the number of correct digits in the wrong position");
            if (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Invalid input for c. Please enter a valid integer.");
                return;
            }

            // A flag to indicate if any candidate numbers were found
            bool nums = false;
            // Convert the secret number to a string for digit comparison
            string num = secretNumber.ToString();

            int temp = 0; // Temporary variable to remember digits to avoid counting them twice

            // Loop through all 4-digit numbers from 1000 to 9999
            for (int i = 1000; i <= 9999; i++)
            {
                int countb = 0; // Counter for the number of correct digits in the correct position
                int countc = 0; // Counter for the number of correct digits in the wrong position

                string n = i.ToString(); // Convert the generated number to a string for digit comparison

                // Skip numbers that contain zero digits, as they are not valid candidates
                // 48 in the code is for converting character representations of digits to their corresponding integer values, allowing for accurate numeric comparisons.
                // In the ASCII character encoding, the characters '0' to '9' are represented by consecutive values from 48 to 57.
                // Without this conversion, the comparison between characters would be a character comparison rather than a numeric comparison.
                if (n[0] - 48 == 0 || n[1] - 48 == 0 || n[2] - 48 == 0 || n[3] - 48 == 0)
                {
                    continue;
                }

                // Compare each digit of the generated number to each digit of the secret number
                for (int k = 0; k < 4; k++)
                {
                    // Get the current digit of the generated number
                    int digit = n[k] - 48;
                    for (int d = 0; d < 4; d++)
                    {
                        // Check if the digit matches both in value and position
                        if (digit == num[d] - 48)
                        {
                            if (num[k] - 48 == n[k] - 48)
                            {
                                countb++; // Increment count for correct digits in the correct position
                                break;
                            }
                            // Check if the digit matches in value but not in position, and the digit is not already counted as a correct digit in the wrong position
                            else if (num[d] - 48 != n[d] - 48 && n[k] - 48 != temp)
                            {
                                temp = n[k] - 48; // Remember the digit to avoid counting it twice
                                countc++;   // Increment count for correct digits in the wrong position
                                break;
                            }
                        }
                    }
                }
                // Check if the generated number is a possible candidate based on the given clues (b and c)
                if (countb == 0 && countc == 0)
                {
                    nums = true; // At least one candidate number is found
                    Console.Write("{0} ", i); // Print the candidate number
                }
            }
            // If no candidates are found based on the given clues, print "No."
            if (nums == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}