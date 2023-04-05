using System;

namespace Less02ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading by Console.ReadKey() - waits for key pressing on the console
            // The result of invoking ReadKey() is information about the pressed key (or more accurately a key combination) as an object of type ConsoleKeyInfo.
            // The obtained object contains the character that is entered by the pressed key combination (property KeyChar)
            // along with information about the keys [Shift], [Ctrl] and [Alt] (property Modifiers).
            Console.WriteLine("Enter [Shift + (any letter)]: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();                                        // If we press [Shift+A]
            Console.WriteLine("Character entered: " + key.KeyChar);     // Character entered: A
            Console.WriteLine("Special keys: " + key.Modifiers);        // Special keys: Shift
            Console.ReadKey();

            // Printing a letter
            Console.WriteLine();
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter book's name: ");
            string book = Console.ReadLine();
            string from = "Author";
            Console.WriteLine("Dears {0},", name);
            Console.Write("I am happy to present you that \"{1}\" is the best book ever. {2}" +
                "The auther of the book wish you great luck {0}!{2}", name, book, Environment.NewLine);
            Console.WriteLine("Yours,");
            Console.WriteLine("{0}", from);

            // Area of a Rectangle or a Triangle 
            Console.WriteLine("\nThis program calculates the erea of a triangle or a rectangle");
            Console.WriteLine("Enter a and b (for rectangle) or a and h (for triangle): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1 for a rectangle or 2 for the triangle: ");
            int choice = int.Parse(Console.ReadLine());
            double area = (double)(a * b) / choice;
            Console.WriteLine("The area of your figure is " + area);
        }
    }
}
