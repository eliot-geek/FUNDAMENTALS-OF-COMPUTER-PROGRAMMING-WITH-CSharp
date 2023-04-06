using System;

namespace Ex03ReadInfoAboutCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. 
             Write a program that reads information about the company and its manager and then prints it on the console.
             Guide: Format the text with Write(…) or WriteLine(…) similar to the example with the letter that we looked at.*/

            Console.Write("Enter the company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter the company address: ");
            string compAddress = Console.ReadLine();
            Console.Write("Enter the company number: ");
            double compNumber = Double.Parse(Console.ReadLine());
            Console.Write("Enter the company fax number: ");
            int compFaxNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the company website: ");
            string compWebsite = Console.ReadLine();
            Console.Write("Enter the company manager's name: ");
            string managerName = Console.ReadLine();
            Console.Write("Enter the company manager's surname: ");
            string managerSurname = Console.ReadLine();
            Console.Write("Enter the company manager's phone number: ");
            double managerNumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("Company: \nName - {0} \nAddress - {1} \nNumber Number - {2} \nFax - {3} \nWebsite - {4} \nManager - {5}", 
                compName, compAddress, compNumber, compFaxNumber, compWebsite, managerName);
            Console.WriteLine("\nManager: \nName - {0} \nSurname - {1} \nPhone Number - {2}", managerName, managerSurname, managerNumber);


            Console.WriteLine(); Console.ReadKey();
            // Prompt the user to enter information about the company
            Console.WriteLine("Please enter information about the company:");
            Console.Write("Name: ");
            string companyName = Console.ReadLine();
            Console.Write("Address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string companyFaxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string companyWebsite = Console.ReadLine();
            // Prompt the user to enter information about the manager
            Console.WriteLine("Please enter information about the manager:");
            Console.Write("Name: ");
            string managerName1 = Console.ReadLine();
            Console.Write("Surname: ");
            string managerSurname1 = Console.ReadLine();
            Console.Write("Phone number: ");
            string managerPhoneNumber = Console.ReadLine();
            // Print the information about the company and its manager to the console
            Console.WriteLine("\nCompany information:");
            Console.WriteLine("Name: {0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Phone number: {0}", companyPhoneNumber);
            Console.WriteLine("Fax number: {0}", companyFaxNumber);
            Console.WriteLine("Web site: {0}", companyWebsite);
            Console.WriteLine("Manager information:");
            Console.WriteLine("Name: {0} {1}", managerName1, managerSurname1);
            Console.WriteLine("Phone number: {0}", managerPhoneNumber);
        }
    }
}
