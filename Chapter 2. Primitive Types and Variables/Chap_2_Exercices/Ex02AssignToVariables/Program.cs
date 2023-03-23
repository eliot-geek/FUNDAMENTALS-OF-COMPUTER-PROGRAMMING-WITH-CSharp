namespace Ex02AssignToVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Which of the following values can be assigned to variables of type float, double and decimal: 
             * 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
             * 
             * Guidelines:
             * Consider the number of digits after the decimal point. 
             * Refer to the table that describes the sizes of the types float, double and decimal.
             */

            float flo = 12.345f;
            double dou = 5;
            double dou1 = -5.01;
            double dou2 = 34.567839023d;
            double dou3 = 8923.1234857d;
            decimal dec = 3456.091124875956542151256683467m;

            Console.WriteLine($" {flo} \n {dou} \n {dou1} \n {dou2} \n {dou3} \n {dec}");
        }
    }
}