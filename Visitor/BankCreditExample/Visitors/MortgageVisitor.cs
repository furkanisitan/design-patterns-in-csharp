using BankCreditExample.Customers;
using System;

namespace BankCreditExample.Visitors
{
    public class MortgageVisitor : IVisitor
    {
        public void Visit(Customer customer)
        {
            if (customer is PersonalCustomer)
                Console.WriteLine("Bireysel müşteri mortgage yapabilir");
            else if(customer is CorporateCustomer)
                Console.WriteLine("Kurumsal müşteri mortgage yapamaz.");
        }
    }
}
