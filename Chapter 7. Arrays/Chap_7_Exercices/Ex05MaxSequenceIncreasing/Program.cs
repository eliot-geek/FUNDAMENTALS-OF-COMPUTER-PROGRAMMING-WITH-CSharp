using System;

namespace Ex05MaxSequenceIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 5
            // Write a program, which finds the maximal sequence of consecutively placed increasing integers. 
            // Example: {3, 2, 3, 4, 2, 2, 4} --> {2, 3, 4}.
            // Guide : This exercise is very similar to the previous one, but we have a continuation of the current sequence when the next element is bigger
            #endregion


            Console.WriteLine("Write a program, which finds the maximal sequence of consecutively placed increasing integers");
            int[] arr = { 3, 2, 3, 4, 2, 2, 4 };
            int maxLength = 1;                      // length of the maximal sequence found so far
            int maxStartIndex = 0;                  // start index of the maximal sequence found so far
            int currentLength = 1;                  // length of the current increasing sequence being examined
            int currentStartIndex = 0;              // start index of the current increasing sequence being examined

            Console.Write("Source sequence : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();

            // loop through the array
            for (int i = 1; i < arr.Length; i++)
            {
                // if the current element is greater than the previous one
                if (arr[i] > arr[i - 1])
                { 
                    currentLength++; // increment the length of the current increasing sequence
                }
                // if the current element is not greater than the previous one
                else
                {
                    // if the length of the current sequence is greater than the maximal length found so far
                    if (currentLength > maxLength)
                    { 
                        maxLength = currentLength;          // update the maximal length
                        maxStartIndex = currentStartIndex;  // update the start index of the maximal sequence
                    }
                    currentLength = 1;      // reset the length of the current sequence
                    currentStartIndex = i;  // set the start index of the current sequence to the current index
                }
            }

            // check one last time if the length of the current sequence is greater than the maximal length found so far
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = currentStartIndex;
            }

            // create a new array containing the maximal sequence found, using Array.Copy to copy the relevant portion of arr
            int[] result = new int[maxLength];
            Array.Copy(arr, maxStartIndex, result, 0, maxLength);
            // output the maximal sequence
            Console.WriteLine("Maximal sequence: {" + string.Join(", ", result) + "}");
            Console.ReadLine();




            Console.WriteLine("\nSolution 2");
            Console.Write("Enter the array's length : ");
            int length = Int32.Parse(Console.ReadLine());
            // initialize variables to keep track of the maximal sequence found so far
            int[] array = new int[length];
            int sames = 1;          // length of the current increasing sequence being examined
            int bestSames = 1;      // length of the maximal sequence found so far
            int bestStart = 0;      // start index of the maximal sequence found so far
            int lastElement = 0;    // index of the last element in the maximal sequence found so far

            // loop through the array and fill it with user input
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            // loop through the array and find the maximal sequence of increasing integers
            for (int i = 0; i < array.Length - 1; i++)
            {
                // if the current element is followed by an increasing element
                if (array[i] + 1 == array[i + 1])
                {
                    // increment the length of the current increasing sequence
                    sames++; 
                    // if the length of the current sequence is greater than the maximal length found so far
                    if (sames > bestSames)
                    { 
                        bestSames = sames;                          // update the maximal length
                        lastElement = i + 1;                        // update the index of the last element in the maximal sequence
                        bestStart = lastElement - bestSames + 1;    // update the start index of the maximal sequence
                    }
                }
                // if the current element is not followed by an increasing element
                else
                {
                    // reset the length of the current sequence
                    sames = 1; 
                }
            }
            // Output the maximal sequence
            for (int i = bestStart; i < bestSames + bestStart; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadLine();
        }
    }
}
