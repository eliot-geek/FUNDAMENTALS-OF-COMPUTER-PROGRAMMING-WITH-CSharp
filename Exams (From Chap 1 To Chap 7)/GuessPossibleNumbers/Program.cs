namespace GuessPossibleNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Number Guessing Game - Find Possible Numbers
            /* The program is designed to solve a number guessing game, where the player provides the number of "bulls" and "cows" obtained from a secret 4-digit number. 
             * The program aims to find all possible numbers that could be the secret number based on the given "bulls" and "cows" clues.
             
            Conditions:
            Input:
            guessNum: A string representing the player's guess of the secret number (length is always 4).
            targetBulls: An integer representing the number of "bulls" given by the player (correct digits in the correct positions).
            targetCows: An integer representing the number of "cows" given by the player (correct digits in the wrong positions).
            
            Logic:
            The program iterates through all possible 4-digit numbers from 1111 to 9999.
            For each number, it checks if it contains the digit "0"; if so, it is invalid, and the program skips to the next number.
            For the valid numbers, the program compares each digit of the guess (guessNum) with the corresponding digit of the current number.
            If a digit is in the correct position (matching "bulls"), it marks both digits as visited (isGuessVisited[i] = true and isNumVisited[i] = true).
            If a digit is not in the correct position (matching "cows"), it checks for matching digits between the guess and the current number (that are not already visited) and marks them as visited as well.
            After checking all digits, the program compares the count of bulls and cows with the target values (targetBulls and targetCows).
            If the count of bulls and cows matches the target values, the current number is a possible solution, and it is printed.
            
            Output:
            If there are valid solutions (numbers that match the clues), the program prints the possible solutions as space-separated integers.
            If no valid solutions are found, the program prints "No".*/
            #endregion

            Console.Write("Enter player's guess number: ");
            string guessNum = Console.ReadLine();               // Player's guess of the secret number (length is always 4)
            Console.Write("Enter target number of bulls: ");
            int targetBulls = int.Parse(Console.ReadLine());    // Number of "bulls" given by the player (correct digits in the correct positions)
            Console.Write("Enter target number of cows: ");
            int targetCows = int.Parse(Console.ReadLine());     // Number of "cows" given by the player (correct digits in the wrong positions)

            // Variables to track if a solution is found and to format the output
            bool hasSolution = false;
            bool isFirst = true;

            // Iterate through all possible 4-digit numbers from 1111 to 9999
            for (int num = 1000; num <= 9999; num++)
            {
                // Variables to count the number of "bulls" and "cows" for the current number
                int bulls = 0;
                int cows = 0;

                // Convert the current number to a character array for easier digit extraction
                char[] numStr = num.ToString().ToCharArray();

                // Arrays to keep track of visited digits in both guess and the current number
                bool[] isGuessVisited = new bool[numStr.Length]; // Tracks visited digits in the guess
                bool[] isNumVisited = new bool[numStr.Length];   // Tracks visited digits in the current number

                // Check if the current number contains the digit '0'; if so, it's invalid, and we skip to the next number
                if (numStr.Contains('0'))
                {
                    continue;
                }

                // Count bulls - compare digits in the guess with the digits in the current number at the same position
                for (int i = 0; i < guessNum.Length; i++)
                {
                    if (guessNum[i] == numStr[i])
                    {
                        bulls++;
                        isGuessVisited[i] = true; // Mark the guess digit as visited
                        isNumVisited[i] = true;   // Mark the current number digit as visited
                    }
                }

                // Count cows - compare digits in the guess with digits in the current number at different positions
                for (int i = 0; i < guessNum.Length; i++)
                {
                    for (int j = 0; j < numStr.Length; j++)
                    {
                        if (i != j &&                     // Avoid comparing the same digit at the same position
                            !isNumVisited[j] &&           // Check if the digit in the current number is not visited
                            !isGuessVisited[i] &&         // Check if the digit in the guess is not visited
                            guessNum[i] == numStr[j])    // Compare digits for a match
                        {
                            cows++;
                            isGuessVisited[i] = true; // Mark the guess digit as visited
                            isNumVisited[j] = true;   // Mark the current number digit as visited
                        }
                    }
                }

                // Compare the count of bulls and cows with the target values
                if (bulls == targetBulls && cows == targetCows)
                {
                    // If the counts match, the current number is a possible solution
                    hasSolution = true;
                    if (!isFirst)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(num);
                    isFirst = false;
                }
            }

            // Output the results - either the possible solutions or "No" if no valid solutions are found
            if (!hasSolution)
            {
                Console.WriteLine("No");
            }
        }
    }
}