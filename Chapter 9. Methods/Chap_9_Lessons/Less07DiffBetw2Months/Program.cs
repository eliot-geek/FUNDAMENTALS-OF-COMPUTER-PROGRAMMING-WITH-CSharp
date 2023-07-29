namespace Less07DiffBetw2Months
{
    internal class Program
    {
        /// <summary>
        /// Getting Month Name
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        static string GetMonthName(int month)
        {
            string monthName;
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    Console.WriteLine("Invalid month!");
                    return null;
            }
            return monthName;
        }

        /// <summary>
        /// Calculate Difference between Two Months
        /// </summary>
        /// <param name="startMonth"></param>
        /// <param name="endMonth"></param>
        static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                // Fix negative distance
                period = period + 12;
            }
            Console.WriteLine("There is {0} months period from {1} to {2}.", period, GetMonthName(startMonth), GetMonthName(endMonth));
        }

        /// <summary>
        /// Validate Hours
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        static bool ValidateHours(int hours)
        {
            bool result = (hours >= 0) && (hours < 24);
            return result;
        }
        /// <summary>
        /// Validate Minutes
        /// </summary>
        /// <param name="minutes"></param>
        /// <returns></returns>
        static bool ValidateMinutes(int minutes)
        {
            bool result = (minutes >= 0) && (minutes <= 59);
            return result;
        }

        static void Main(string[] args)
        {
            // Difference between Two Months
            Console.Write("First  month (1-12): ");
            int firstMonth = int.Parse(Console.ReadLine());
            Console.Write("Second month (1-12): ");
            int secondMonth = int.Parse(Console.ReadLine());
            SayPeriod(firstMonth, secondMonth);
            Console.ReadLine();


            // Input Data Validation
            Console.WriteLine("What time is it?");
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);
            if (isValidTime)
            {
                Console.WriteLine("The time is {0}:{1} now.", hours, minutes);
            }
            else
            {
                Console.WriteLine("Incorrect time!");
            }
        }
    }
}