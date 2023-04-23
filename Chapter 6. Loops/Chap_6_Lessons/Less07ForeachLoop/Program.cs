using System;

namespace Less07ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Foreach Loops - This programming construct serves to iterate over all elements of an array, list or other collection of elements (IEnumerable).
            // It passes through all the elements of the specified collection even if the collection is not indexed.

            // Here is how a foreach loop looks like:
            // foreach (type variable in collection)
            // {
            //     statements;
            // }

            // We create an array of numbers
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // An array of city names (strings)
            string[] towns = { "London", "Paris", "Milan", "Moscou", "New York" };
            foreach (string town in towns)
            {
                Console.Write(town + " ");
            }
            Console.ReadLine();

            // 2 3 5 7 11 13 17 19
            // London Paris Milan Moscou New York
        }
    }
}
