using System;

namespace Ex_07_Weight_Man_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            // The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program
            // that calculates the weight of a man on the moon by a given weight on the Earth.
            // Use the following code to read the number from the console: Then multiply by 0.17 and print it.

            // Define a constant for the moon's gravitational field
            const double MoonGravity = 0.17;
            // Prompt the user to enter their weight on Earth
            Console.Write("Enter your weight on Earth (in kg): ");
            // Read the user's input and convert it to a double
            double weightOnEarth = Convert.ToDouble(Console.ReadLine());
            // Calculate the weight on the Moon by multiplying the weight on Earth by the Moon's gravity
            double weightOnMoon = weightOnEarth * MoonGravity;
            // Output the weight on the Moon to the console
            Console.WriteLine("Your weight on Earth is {0} kg \nYour weight on the Moon would be: {1} kg", weightOnEarth, weightOnMoon);
            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
