using BankCreditExample.Customers;
using BankCreditExample.Visitors;

namespace BankCreditExample
{
    public class UsageCredit
    {
        public static void Mortgage(Customer customer)
        {
            customer.Accept(new MortgageVisitor());
        }

        public static void Leasing(Customer customer)
        {
            customer.Accept(new LeasingVisitor());
        }
    }
}
