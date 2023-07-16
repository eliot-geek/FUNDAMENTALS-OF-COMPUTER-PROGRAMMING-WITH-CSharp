namespace PatternsCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Creating Patterns with Characters
            /* The program generates a specific pattern using characters #, -, \, /, and . based on the input n. The pattern consists of three parts:
            The first part is an inverted pyramid-like shape with the apex at the center. It contains # characters forming a diamond shape.
            The second part is a horizontal line consisting of - characters.
            The third part is another pyramid-like shape, but this time with the apex at the bottom. It contains \ and / characters forming an X-shaped pattern.
            
            Conditions:
            Input:
            n: An integer representing the size of the pattern.
            
            Logic:
            The program generates the first part by using two nested loops. The outer loop (i) goes from 1 to n - n / 4, and the inner loop (k) goes from 1 to n.
            In the first part, # characters are printed at positions n / 2 + 1 - i and n / 2 + i in each row, forming a diamond shape.
            For the second part, a horizontal line of - characters is printed using a single loop that runs n times.
            The third part is generated with two nested loops. The outer loop (i) goes from 1 to n / 2, and the inner loop (k) goes from 1 to n.
            In the third part, \ characters are printed from positions i to n / 2, and / characters are printed from positions n - i + 2 to n / 2 + 1.
            
            Output:
            The program prints the pattern to the console using the characters #, -, \, /, and . to create the desired shape.  */
            #endregion


            Console.Write("Enter the size of the pattern (n): ");
            int n = int.Parse(Console.ReadLine());

            // Generate the first part - Inverted pyramid-like shape with the apex at the center
            for (int i = 1; i <= n - n / 4; i++)
            {
                // Loop through each column in a row
                for (int k = 1; k <= n; k++)
                {
                    // Check if the current position is where a '#' should be placed
                    if (k == n / 2 + 1 - i || k == n / 2 + i)
                    {
                        Console.Write('#'); // Print '#' character
                    }
                    else if (i >= n / 2 + 1 && (k == n + n / 2 + 1 - i || k == i - n / 2))
                    {
                        Console.Write('#'); // Print '#' character for the bottom part of the pattern
                    }
                    else
                    {
                        Console.Write('.'); // Print '.' character for other positions
                    }
                }
                Console.WriteLine(); // Move to the next row
            }

            // Generate the second part - Horizontal line of '-' characters
            for (int i1 = 1; i1 <= n; i1++)
            {
                Console.Write('-'); // Print '-' character to form a horizontal line
            }
            Console.WriteLine(); // Move to the next row

            // Generate the third part - Pyramid-like shape with the apex at the bottom
            for (int i = 1; i <= n / 2; i++)
            {
                // Loop through each column in a row
                for (int k = 1; k <= n; k++)
                {
                    // Check if the current position is where a '\' should be placed
                    if (k <= n / 2 && k >= i)
                    {
                        Console.Write('\\'); // Print '\' character
                    }
                    // Check if the current position is where a '/' should be placed
                    else if (k < n - i + 2 && k >= n / 2 + 1)
                    {
                        Console.Write('/'); // Print '/' character
                    }
                    else
                    {
                        Console.Write('.'); // Print '.' character for other positions
                    }
                }
                Console.WriteLine(); // Move to the next row
            }
        }
    }
}