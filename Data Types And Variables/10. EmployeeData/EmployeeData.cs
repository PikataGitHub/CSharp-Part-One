using System;

    class EmployeeData
    {
        static void Main()
        {
        string firstName = "Dimitar";
        string lastName = "Yanev";
        byte age = 31;
        char gender = 'm';
        long personalIDnumber = 8407056649;
        uint employeeNumber = 27569999;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", firstName, lastName, age, gender, personalIDnumber, employeeNumber);
        }
    }