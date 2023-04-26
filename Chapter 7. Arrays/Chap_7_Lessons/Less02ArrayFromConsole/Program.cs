using System;

namespace Less02ArrayFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading an Array from the Console

            Console.Write("Enter n elements of the array : ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the {i} element of the array : ");
                array[i] = Int32.Parse(Console.ReadLine()); 
            }
            Console.WriteLine();

            Console.WriteLine("The array is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
