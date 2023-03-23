namespace Ex12EmployeeRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – 
             * first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed 
             * to maintain the information for an employee by using the appropriate data types and attribute names.*/

            string firstName = "Anders";            // the first name of the employee
            string lastName = "Hejlsberg";          // the last name of the employee
            byte age = 59;                          // the age of the employee
            char gender = 'm';                      // the gender of the employee ('m' or 'f')
            int uniqueEmployeeNumber = 27560002;    // the unique employee number (27560000 to 27569999)

            Console.WriteLine($"{firstName} \n{lastName} \n{age} \n{gender} \n{uniqueEmployeeNumber}");
        }
    }
}