using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhoneNumber = Console.ReadLine();
        string companyFaxNumber = Console.ReadLine();
        string companyWebSite = Console.ReadLine();

        string managerFirstName = Console.ReadLine();
        string managerlastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerMobile = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + companyPhoneNumber);

        if (companyFaxNumber.Equals(""))
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: " + companyFaxNumber);
        }
        Console.WriteLine("Web site: " + companyWebSite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerlastName + " (age: " + managerAge + ", tel. " + managerMobile + ")");
    }
}