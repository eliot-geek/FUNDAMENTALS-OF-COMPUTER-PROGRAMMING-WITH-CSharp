namespace PatternsCharacters2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task: Creating Geometric Patterns with Characters
            /*The program generates a specific pattern using characters #, '-', '', and '.' based on the input n. The pattern consists of four parts:
            The first part is an upper triangle with the apex at the top. It contains # characters and periods (.) arranged to form a pattern.
            The second part is a lower triangle with the apex at the bottom. It also contains # characters and periods (.) arranged to form a pattern.
            The third part is a horizontal line consisting of '-' characters.
            The fourth part is another lower triangle with the apex at the bottom. It contains a combination of '' and '/' characters arranged to form a pattern.

            Conditions:
            Input:
            n: An integer representing the size of the pattern.
            
            Logic:
            The program uses nested loops to generate the four parts of the pattern.
            For the first part (upper triangle), the program prints periods (.) and # characters based on the current row and column positions.
            For the second part (lower triangle), the program prints periods (.) and # characters based on the current row and column positions.
            For the third part (horizontal line), the program prints '-' characters n times to create the line.
            For the fourth part (another lower triangle), the program prints periods (.), '', and '/' characters based on the current row and column positions.
            
            Output:
            The program prints the pattern to the console using the characters #, '-', '', and '.' to create the desired shape.*/
            #endregion

            Console.Write("Enter the size of the pattern (n): ");
            int n = int.Parse(Console.ReadLine());

            // Generate the first part - Upper triangle with the apex at the top
            for (int i = (n / 2); i > 0; i--)
            {
                // Print periods and '#' characters for each row in the upper triangle
                for (int j = (n / 2) - i; j < (n / 2) - 1; j++)
                    Console.Write(".");
                Console.Write("#");
                for (int j = i; j < (n / 2); j++)
                    Console.Write(".");
                for (int j = i; j < (n / 2); j++)
                    Console.Write(".");
                Console.Write("#");
                for (int j = (n / 2) - i; j < (n / 2) - 1; j++)
                    Console.Write(".");
                Console.WriteLine();
            }

            // Generate the second part - Lower triangle with the apex at the bottom
            for (int i = 0; i < (n / 4); i++)
            {
                // Print periods and '#' characters for each row in the lower triangle
                for (int j = 0; j < i; j++)
                    Console.Write(".");
                Console.Write("#");
                for (int j = 0; j < (n / 2) - 1 - i; j++)
                    Console.Write(".");
                for (int j = 0; j < (n / 2) - 1 - i; j++)
                    Console.Write(".");
                Console.Write("#");
                for (int j = 0; j < i; j++)
                    Console.Write(".");
                Console.WriteLine();
            }

            // Generate the third part - Horizontal line of '-' characters
            for (int i = 0; i < n; i++)
                Console.Write("-"); // Print '-' character to form a horizontal line
            Console.WriteLine(); // Move to the next row

            // Generate the fourth part - Another lower triangle with the apex at the bottom
            for (int i = 0; i < (n / 2); i++)
            {
                // Print periods, '\', and '/' characters for each row in the second lower triangle
                for (int j = (n / 2) - i; j < (n / 2); j++)
                    Console.Write(".");
                for (int j = 0; j < (n / 2) - i; j++)
                    Console.Write("\\");
                for (int j = 0; j < (n / 2) - i; j++)
                    Console.Write("/");
                for (int j = (n / 2) - i; j < (n / 2); j++)
                    Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}