using BankCreditExample.Customers;
using System;

namespace BankCreditExample.Visitors
{
    public class LeasingVisitor : IVisitor
    {
        public void Visit(Customer customer)
        {
            if (customer is PersonalCustomer)
                Console.WriteLine("Bireysel müşteri leasing kullanamaz");
            else if (customer is CorporateCustomer)
                Console.WriteLine("Kurumsal müşteri leasing kullanabilir.");
        }
    }
}
