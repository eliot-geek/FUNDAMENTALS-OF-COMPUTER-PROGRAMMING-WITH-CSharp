using System;

namespace Ex15AllLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 15
            /* Write a program, which creates an array containing all Latin letters. The user inputs a word from the console and as result 
            the program prints to the console the indices of the letters from the word.
            
            Guide: We can solve this problem with two nested for-loops (one for the words and one for the letters of the current word). There is a solution 
            without using an array: we can calculate the index of a given uppercase Latin letter ch using the expression: (int) ch – (int) 'A'.
             */
            #endregion
            
            
            Console.WriteLine("Write a program, which creates an array containing all Latin letters");
            // create an array containing all Latin letters
            char[] alphabet1 = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
                'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            
            Console.Write("Enter a word : ");
            char[] word = (Console.ReadLine()).ToCharArray();
            // loop through each letter of the word and print its index
            for (int i = 0; i < word.Length; i++)
            {
                // loop through each letter of the alphabet to find a match
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.Write("{0} ", j); // print the index of the letter
                    }
                }
            }
            Console.ReadLine();



            Console.WriteLine("\nSolution 2");
            char[] letters = new char[26];      // create an array to store Latin letters
            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)('a' + i); // fill the array with Latin letters
            }

            Console.Write("Enter a word: ");
            string wor = Console.ReadLine();

            for (int i = 0; i < wor.Length; i++) // loop through each letter in the word
            {
                char letter = wor[i];
                for (int j = 0; j < 26; j++) // loop through each letter in the Latin letters array
                {
                    if (letter == letters[j]) // if the letter is found in the Latin letters array
                    {
                        Console.Write(j + " "); // print the index of the letter
                        break; // exit the inner loop
                    }
                }
            }
            Console.ReadLine();



            // There is a solution without using an array: we can calculate the index of a given uppercase Latin letter ch using the expression: (int) ch – (int) 'A'.
            Console.WriteLine("\nSolution 3");
            // Create an array containing all Latin letters
            char[] latinLetters = new char[26];
            for (int i = 0; i < 26; i++)
            {
                latinLetters[i] = (char)('A' + i);
            }

            // Get input word from the user
            Console.Write("Enter a word: ");
            string wordd = Console.ReadLine().ToUpper();

            // Print the indices of the letters from the word
            Console.Write("Indices of letters: ");
            for (int i = 0; i < wordd.Length; i++)
            {
                int index = wordd[i] - 'A'; // Calculate index of the letter
                Console.Write(index + " ");
            }
            Console.WriteLine();
        }
    }
}
