using BankCreditExample.Visitors;

namespace BankCreditExample.Customers
{
    public class CorporateCustomer : Customer
    {
        protected string company;

        public CorporateCustomer(string name, string surname, string company) : base(name, surname) { }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
