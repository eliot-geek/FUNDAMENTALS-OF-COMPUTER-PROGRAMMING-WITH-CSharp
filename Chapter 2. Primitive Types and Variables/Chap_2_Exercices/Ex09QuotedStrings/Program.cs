namespace Ex09QuotedStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” 
             * (without the outer quotes). In one of the variables use quoted string and in the other do not use it.
             
             Guidelines: It is necessary to use the escaping character \" or verbatim strings. */


            // Using double quotes to define the string and escaping the inner quotes with a backslash (\)
            string strWithQuotes = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(strWithQuotes);
            // Using verbatim string literal (@) to avoid escaping the inner quotes
            string strWithoutQuotes = @"The 'use' of quotations causes difficulties.";
            Console.WriteLine(strWithoutQuotes);

            // Using verbatim string literal (@) to avoid escaping the inner quotes
            string verbatim = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(verbatim);
        }
    }
}