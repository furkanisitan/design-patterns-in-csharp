using BankCreditExample.Visitors;

namespace BankCreditExample.Customers
{
    public class PersonalCustomer : Customer
    {
        public PersonalCustomer(string name, string surname) : base(name, surname) { }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
