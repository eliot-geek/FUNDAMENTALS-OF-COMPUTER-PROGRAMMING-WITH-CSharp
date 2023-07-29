namespace Less06FahrCelsiusConv
{
    internal class Program
    {
        /// <summary>
        /// Convert Fahrenheit To Celsius
        /// </summary>
        /// <param name="temperatureF"></param>
        /// <returns></returns>
        static double ConvertFahrenheitToCelsius(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
        }

        static void Main(string[] args)
        {
            // Fahrenheit to Celsius Conversion
            Console.Write("Enter your body temperature in Fahrenheit degrees: ");
            double temperature = double.Parse(Console.ReadLine());

            temperature = ConvertFahrenheitToCelsius(temperature);
            Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);
            
            if (temperature >= 37)
            {
                Console.WriteLine("You are ill!");
            }
        }
    }
}