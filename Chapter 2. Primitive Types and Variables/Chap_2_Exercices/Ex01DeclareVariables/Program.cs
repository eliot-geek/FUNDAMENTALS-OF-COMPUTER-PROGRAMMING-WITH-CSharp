namespace Ex01DeclareVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare several variables by selecting for each one of them the most appropriate of the types sbyte, 
             * byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 
             * 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
             */


            sbyte sb1 = -115;
            sbyte sb2 = -44;
            sbyte sb3 = 112;
            byte b1 = 97;
            byte b2 = 224;
            byte b3 = 112;
            short sh1 = -10_000;
            short sh2 = 20_000;
            double doubl = 52.130;
            ushort ush2 = 1992;
            int i = -1_000_000;
            uint ui1 = 4825932;
            uint ui2 = 970700000;
            long l = 123456789123456789;

            Console.WriteLine($" {sb1} \n {sb2} \n {sb3} \n {b1} \n {b2} \n {b3} \n {sh1} \n {sh2} \n {doubl} \n {ush2} \n {i} \n {ui1} \n {ui2} \n {l}");
        }
    }
}