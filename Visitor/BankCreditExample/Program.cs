using BankCreditExample.Customers;
using System;

namespace BankCreditExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer pc = new PersonalCustomer("Furkan", "Işıtan");
            Customer cc = new CorporateCustomer("Test", "Username", "Example");

            UsageCredit.Leasing(pc);
            UsageCredit.Leasing(cc);
            UsageCredit.Mortgage(pc);
            UsageCredit.Mortgage(cc);

            Console.ReadKey();
        }
    }
}
