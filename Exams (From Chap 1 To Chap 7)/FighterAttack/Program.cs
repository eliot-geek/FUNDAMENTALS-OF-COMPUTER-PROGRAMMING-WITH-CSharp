namespace FighterAttack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task: Fighter Attack
            /* Conditions:
            There are two points (px1, py1) and (px2, py2) representing the opposite corners of a rectangle.
            There is a fighter jet located at point (fx, fy) and it fires a missile towards the right direction with a distance 'd'.
            The fighter jet's missile has a rectangular area of impact, which consists of four cells: center, upper, lower, and front.
            The center cell is located at (fx + d, fy).
            The upper cell is located at (fx + d, fy + 1).
            The lower cell is located at (fx + d, fy - 1).
            The front cell is located at (fx + d + 1, fy).
            The program needs to calculate the total damage caused by the missile to the rectangular area defined by (px1, py1) and (px2, py2).
            The rectangular area has the opposite corners at (px1, py1) and (px2, py2). Note that (px1, py1) might not always be the bottom-left corner, and (px2, py2) might not always be the top-right corner.
            The program should output the total damage as a percentage of the maximum possible damage, which is 275. */
            #endregion

            // Read input values for the opposite corners of the rectangle (px1, py1) and (px2, py2)
            int px1 = int.Parse(Console.ReadLine());
            int py1 = int.Parse(Console.ReadLine());
            int px2 = int.Parse(Console.ReadLine());
            int py2 = int.Parse(Console.ReadLine());

            // Read input values for the fighter jet position (fx, fy) and missile distance 'd'
            int fx = int.Parse(Console.ReadLine());
            int fy = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            // Calculate the coordinates of the four cells of the missile impact: center, upper, lower, and front
            int missleCenterX = fx + d;
            int missleCenterY = fy;
            int missleUpperX = fx + d;
            int missleUpperY = fy + 1;
            int missleDownX = fx + d;
            int missleDownY = fy - 1;
            int missleFrontX = fx + d + 1;
            int missleFrontY = fy;

            // Initialize a variable to store the total damage caused by the missile
            int totalDamage = 0;

            // Reorder the corner points (px1, py1) and (px2, py2) if necessary so that px1 <= px2 and py1 <= py2
            if (py1 < py2)
            {
                int temp = py2;
                py2 = py1;
                py1 = temp;
            }

            if (px2 < px1)
            {
                int temp = px2;
                px2 = px1;
                px1 = temp;
            }

            // Check if each of the four cells of the missile impact lies within the rectangular area defined by (px1, py1) and (px2, py2)
            if (missleCenterX >= px1 && missleCenterX <= px2 && missleCenterY >= py2 && missleCenterY <= py1)
            {
                totalDamage += 100; // Add 100 to the total damage for the center cell hit
            }
            if (missleDownX >= px1 && missleDownX <= px2 && missleDownY >= py2 && missleDownY <= py1)
            {
                totalDamage += 50; // Add 50 to the total damage for the lower cell hit
            }
            if (missleUpperX >= px1 && missleUpperX <= px2 && missleUpperY >= py2 && missleUpperY <= py1)
            {
                totalDamage += 50; // Add 50 to the total damage for the upper cell hit
            }
            if (missleFrontX >= px1 && missleFrontX <= px2 && missleFrontY >= py2 && missleFrontY <= py1)
            {
                totalDamage += 75; // Add 75 to the total damage for the front cell hit
            }

            // Output the total damage as a percentage of the maximum possible damage (275)
            Console.WriteLine("{0}%", totalDamage);
        }
    }
}