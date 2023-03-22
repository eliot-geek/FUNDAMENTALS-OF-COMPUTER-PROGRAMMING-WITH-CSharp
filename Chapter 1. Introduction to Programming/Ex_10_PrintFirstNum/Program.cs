namespace Ex_10_PrintFirstNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercice 10 - Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.....

            // Loop through the integers 2 to 100 (inclusive)
            for (int i = 2; i <= 100; i++)
            {
                // If the integer is even, print it as it is
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
                // If the integer is odd, print its negative value
                else
                {
                    Console.Write("{0} ", -i);
                }
            }
        }
    }
}