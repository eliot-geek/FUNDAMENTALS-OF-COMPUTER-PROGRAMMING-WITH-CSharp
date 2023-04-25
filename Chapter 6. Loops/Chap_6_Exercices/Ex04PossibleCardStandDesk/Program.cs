using System;

namespace Ex04PossibleCardStandDesk
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 4
            // Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
            // Guide: Number the cards from 2 to 14 (these numbers will match the cards 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A). Number the suits from 1 to 4
            // (1 – club, 2 – diamond, 3 – heart and 4 – spades). Now you can use the two nested loops and print each of the cards with two switch statements.
            #endregion

            Console.WriteLine("All possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards) ");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    switch (i)
                    {
                        case 1:
                            Console.Write("Club ");
                            break;
                        case 2:
                            Console.Write("Diamond ");
                            break;
                        case 3:
                            Console.Write("Heart ");
                            break;
                        case 4:
                            Console.Write("Spades ");
                            break;
                    }
                    switch (j)
                    {
                        case 2:
                            Console.WriteLine("2");
                            break;
                        case 3:
                            Console.WriteLine("3");
                            break;
                        case 4:
                            Console.WriteLine("4");
                            break;
                        case 5:
                            Console.WriteLine("5");
                            break;
                        case 6:
                            Console.WriteLine("6");
                            break;
                        case 7:
                            Console.WriteLine("7");
                            break;
                        case 8:
                            Console.WriteLine("8");
                            break;
                        case 9:
                            Console.WriteLine("9");
                            break;
                        case 10:
                            Console.WriteLine("10");
                            break;
                        case 11:
                            Console.WriteLine("J");
                            break;
                        case 12:
                            Console.WriteLine("Q");
                            break;
                        case 13:
                            Console.WriteLine("K");
                            break;
                        case 14:
                            Console.WriteLine("A");
                            break;
                    }
                }
            }
            Console.WriteLine();


            Console.WriteLine("\nSolution 2");
            for (int suit = 1; suit <= 4; suit++)
            { 
                // iterate through the suits
                for (int rank = 2; rank <= 14; rank++)
                { 
                    // iterate through the ranks
                    string suitString = ""; // initialize an empty string for the suit
                    switch (suit)
                    { 
                        // determine the suit based on the current iteration
                        case 1:
                            suitString = "club";
                            break;
                        case 2:
                            suitString = "diamond";
                            break;
                        case 3:
                            suitString = "heart";
                            break;
                        case 4:
                            suitString = "spade";
                            break;
                    }
                    string rankString = ""; // initialize an empty string for the rank
                    switch (rank)
                    { 
                        // determine the rank based on the current iteration
                        case 2:
                            rankString = "2";
                            break;
                        case 3:
                            rankString = "3";
                            break;
                        case 4:
                            rankString = "4";
                            break;
                        case 5:
                            rankString = "5";
                            break;
                        case 6:
                            rankString = "6";
                            break;
                        case 7:
                            rankString = "7";
                            break;
                        case 8:
                            rankString = "8";
                            break;
                        case 9:
                            rankString = "9";
                            break;
                        case 10:
                            rankString = "10";
                            break;
                        case 11:
                            rankString = "J";
                            break;
                        case 12:
                            rankString = "Q";
                            break;
                        case 13:
                            rankString = "K";
                            break;
                        case 14:
                            rankString = "A";
                            break;
                    }
                    Console.WriteLine(rankString + " of " + suitString); // print the current card
                }
            }
        }
    }
}
