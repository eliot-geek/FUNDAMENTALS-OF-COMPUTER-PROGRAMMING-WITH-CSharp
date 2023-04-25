using System;

namespace Ex16PrintNRandomOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 16
            // Write a program that by a given integer N prints the numbers from 1 to N in random order.
            // Guide: Search in the Internet for information about the class System.Random. Read in the Internet about arrays (or in the next chapter).
            // Create an array with N elements and write in it the numbers from 1 to N. After that a few times (think exactly how many)
            // swap two random pairs of elements from the array.

            // Random order means arranging the elements in an unpredictable order that is determined by chance.
            // The order of the elements in a random order is not based on any specific rule or pattern, but is determined randomly.
            // Random order is different from ascending or descending order because it does not follow any specific rule or pattern, but is determined randomly.
            #endregion

            Console.WriteLine("Solution 1");
            Console.Write("Enter number n : ");
            int N = Int32.Parse(Console.ReadLine());
            // Create an array of N elements
            int[] numbers = new int[N];
            // Write numbers from 1 to N in the array
            for (int i = 0; i < N; i++)
            {
                numbers[i] = i + 1;
            }
            // Print the numbers
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
            // Swap two random pairs of elements from the array
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                int index1 = rand.Next(N);
                int index2 = rand.Next(N);
                int tempor = numbers[index1];
                numbers[index1] = numbers[index2];
                numbers[index2] = tempor;
            }
            // Print the shuffled array
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
            Console.ReadKey();




            Console.WriteLine("\nSolution 2");
            //Create a new instance of the Random class
            Random random = new Random();
            //Prompt the user to enter an integer and store it in the variable n
            Console.Write("Enter number n : ");
            int n = Int32.Parse(Console.ReadLine());
            //Create an integer array of length n
            int[] array = new int[n];
            //Declare two integer variables
            int randomNumber;
            int temp;

            //Populate the array with values from 0 to n-1
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            //Print the original array to the console
            foreach (var item in array)
            {
                Console.Write(array[item] + " ");
            }
            //Wait for the user to press Enter before continuing
            Console.ReadLine();

            //Shuffle the array by swapping each element with another random element in the array
            foreach (var item in array)
            {
                //Generate a random number between 1 and n-1
                randomNumber = random.Next(1, n);

                //Swap the values at the current position and the randomly selected position
                temp = array[item];
                array[item] = array[randomNumber];
                array[randomNumber] = temp;
            }

            //Print the shuffled array to the console
            foreach (var item in array)
            {
                Console.Write(array[item] + " ");
            }
            //Wait for the user to press Enter before closing the console
            Console.ReadLine();
        }
    }
}
