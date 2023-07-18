namespace CharSummationCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task: Character Summation and Counting
            /* 
            Task: Character Summation and Counting
            Conditions:
            The program will read a string x from the user.
            It will initialize three variables sum, cnt, and i to 0.
            The program will loop through each character in the input string x.
            During the loop:
            a. If the character's position is an even index (0-based) and it is a digit, the program will:
            Increment the cnt variable by 1, to count the number of even-positioned digits.
            Add the numeric value of the digit to the sum variable.
            b. Increment the i variable to keep track of the current character's position.
            After the loop, the program will print the values of cnt and sum separated by a space to the console.*/
            #endregion


            Console.Write("Enter a string of numbers: ");
            string x = Console.ReadLine();

            // Initialize variables to store the sum and count of even-positioned digits
            double sum = 0, count = 0, i = 0;

            // Loop through each character in the input string 'x'
            foreach (var ch in x)
            {
                // Check if the current character's position is even (0-based) and it is a digit
                if ((i % 2 == 0) && char.IsDigit(ch))
                {
                    // Increment 'cnt' by 1 to count the number of even-positioned digits
                    count++;

                    // Add the numeric value of the digit to 'sum'
                    sum += (double.Parse(ch.ToString()) - double.Parse("0"));
                }

                // Increment 'i' to keep track of the current character's position
                i++;
            }

            // Output the count and sum of even-positioned digits to the console
            Console.WriteLine(count + " " + sum);
        }
    }
}