using System;

    class BankAccountData
    {
        static void Main()
        {
        string firstName = "Dimitar";
        string middleName = "Petkov";
        string lastName = "Yanev";

        decimal balanceInBank = 125654m;

        string bankName = "Alpha Bank";
        string IBAN = "BG92CITY123456789";

        long firstCreditCardNumber = 1000123454655696;
        string secondCreditCardNumber = "0000123454655696";
        long thirdCreditCardNumber = 0000123454655696;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName, lastName, balanceInBank, IBAN, bankName, firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
        }
    }