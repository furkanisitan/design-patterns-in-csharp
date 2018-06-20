using BankCreditExample.Customers;

namespace BankCreditExample.Visitors
{
    public interface IVisitor
    {
        void Visit(Customer customer);
    }
}
