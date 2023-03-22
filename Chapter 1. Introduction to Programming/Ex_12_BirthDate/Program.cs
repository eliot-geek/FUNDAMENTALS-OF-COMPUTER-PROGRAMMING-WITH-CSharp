namespace Ex_12_BirthDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program to read your birthday date from the console and print how old you are now and how old you will be after 10 years.

            // Automatically
            // Initialize a DateTime variable baseDate to November 21st, 2018 at 5:30 am
            DateTime baseDate = new DateTime(2018, 11, 21, 05, 30, 00);
            // Print the baseDate to the console with a message
            Console.WriteLine("Your birthday's date is {0}", baseDate);
            // Add 10 years to baseDate using the AddYears() method and print the result to the console
            Console.WriteLine("Your birthday's date in 10 years will be {0}", baseDate.AddYears(10));


            // From the console
            // Prompts the user to enter their birthdate in the format yyyy/mm/dd
            Console.Write("Enter birthdate yyyy/mm/dd: ");
            // Reads the birthdate input from the console and parses it into a DateTime object
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            // Calculates the user's age by subtracting their birth year from the current year
            int ageold = DateTime.Now.Year - birthDate.Year;
            // Outputs the user's current age
            Console.WriteLine("Your age now is: {0}", ageold);
            // Calculates the user's age in 10 years by adding 10 to their current age and Outputs the user's age in 10 years
            Console.WriteLine("Your age in 10 years: {0}", ageold + 10);


            //Console.Write("Enter your birthday date in the format yyyy/mm/dd: ");
            //DateTime birthDay = new DateTime();
            //birthDay = DateTime.Parse(Console.ReadLine());
            //TimeSpan myCurrentAge = new TimeSpan();
            //myCurrentAge = (DateTime.Now - birthDay);
            //int aged = (int)(myCurrentAge.Days / 365 + 10);
            //Console.WriteLine("Your age in ten years will be: " + aged);
            //Console.ReadLine();

            #endregion
        }
    }
}